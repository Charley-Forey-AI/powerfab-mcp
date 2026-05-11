# PowerFab MCP Server

An [MCP](https://modelcontextprotocol.io) server, written in C# / .NET 8 and
hosted on ASP.NET Core, that exposes [Tekla PowerFab](https://developer.tekla.com/tekla-powerfab/documentation)
operations as tools an LLM can call. The first tool, `create_work_package`,
wraps the PowerFab `WorkPackage_Insert` command.

The server uses the **MCP Streamable HTTP** transport so a single running
instance can serve many concurrent clients (Cursor, Claude Desktop, internal
scripts, CI), can sit next to the PowerFab Remote Service on the same LAN, and
fronts behind a standard reverse proxy.

```
LLM client (Cursor / Claude Desktop) ──HTTP/JSON-RPC──▶ /mcp endpoint
                                                              │
                                                  WorkPackageTools
                                                              │
                                                       PowerfabClient
                                                              │
                              Tekla.PowerFab.API (ITeklaPowerFabAPI.ExecuteRemote)
                                                              │
                                              PowerFab Remote Service ──▶ DB
```

## Repository layout

| Path | Purpose |
| --- | --- |
| [`src/PowerfabMcp.Server/`](src/PowerfabMcp.Server) | The MCP server (ASP.NET Core minimal API). |
| `src/PowerfabMcp.Server/Tools/` | One file per tool category; auto-discovered by `WithToolsFromAssembly()`. |
| `src/PowerfabMcp.Server/Powerfab/` | Connection caching + XML envelope around `Tekla.PowerFab.API`. |
| `src/PowerfabMcp.Server/Auth/` | Origin / bearer-token middleware (DNS-rebinding mitigation). |
| `src/PowerfabMcp.Server/Configuration/` | Strongly-typed options bound from env vars / `appsettings.json`. |
| [`tests/PowerfabMcp.Server.Tests/`](tests/PowerfabMcp.Server.Tests) | xUnit unit tests + a `WebApplicationFactory<Program>` integration test that POSTs an MCP `tools/call` to `/mcp`. |
| [`documentation/`](documentation) | Mirror of the public PowerFab developer docs. |
| [`powerfab-api/`](powerfab-api) | Mirror of the PowerFab API class reference. |
| [`mcp-docs.txt`](mcp-docs.txt) | Snapshot of modelcontextprotocol.io docs (for offline reference). |

## Prerequisites

- .NET 8 SDK
- A reachable PowerFab Remote Service
- A PowerFab External User with permission to insert work packages (created
  in PowerFab Office under External Users)

## Configuration

All settings can be supplied via `appsettings.json`, command-line args
(`--Powerfab:Username=…`), environment variables (the double-underscore form),
or a `.env` file in the repo root. The defaults bind the server to **loopback
only** for safety.

### `.env` file (recommended for local dev)

The server loads a `.env` file from the working directory (and walks up the
parent directories) at startup. Real process environment variables always win
over `.env`, so containers, systemd units, and Cursor can still override.

```powershell
# One-time setup
Copy-Item .env.example .env
notepad .env  # fill in Powerfab__Username, Powerfab__Password, etc.
```

`.env` is gitignored; `.env.example` is committed and documents every
supported variable.

| Setting | Env var | Default | Notes |
| --- | --- | --- | --- |
| `Powerfab:Username` | `Powerfab__Username` | _required_ | External user. |
| `Powerfab:Password` | `Powerfab__Password` | _required_ | External user password. |
| `Powerfab:RemoteHost` | `Powerfab__RemoteHost` | `127.0.0.1` | PowerFab Remote Service host. |
| `Powerfab:RemotePort` | `Powerfab__RemotePort` | `8080` | PowerFab Remote Service port. |
| `Powerfab:ApiLog` | `Powerfab__ApiLog` | _empty_ | Set to `all` to record every command in PowerFab → Maintenance → Integration Settings → API Log. |
| `Powerfab:RequestTimeout` | `Powerfab__RequestTimeout` | `00:01:00` | Per-call timeout (`HH:mm:ss`). |
| `Hosting:BindUrl` | `Hosting__BindUrl` | `http://127.0.0.1:3000` | Kestrel listen URL. |
| `Hosting:McpPath` | `Hosting__McpPath` | `/mcp` | MCP endpoint path. |
| `Hosting:BearerToken` | `Hosting__BearerToken` | _empty_ | When set, every MCP request must include `Authorization: Bearer <token>`. **Required when binding to a non-loopback address.** |
| `Hosting:AllowedOrigins` | `Hosting__AllowedOrigins` | _empty_ | Comma-separated list. Loopback origins are auto-allowed when bound to loopback. |

## Run locally

```powershell
$env:Powerfab__Username = "your-external-user"
$env:Powerfab__Password = "your-password"
$env:Powerfab__RemoteHost = "10.0.0.50"      # your PowerFab Remote Service host
$env:Powerfab__RemotePort = "8080"

dotnet run --project src/PowerfabMcp.Server
```

The server starts on `http://127.0.0.1:3000`; the MCP endpoint is at
`http://127.0.0.1:3000/mcp` and there is a health probe at `/healthz`.

## Wire it into Cursor

Add this to your Cursor `mcp.json`:

```json
{
  "mcpServers": {
    "powerfab": {
      "type": "http",
      "url": "http://127.0.0.1:3000/mcp"
    }
  }
}
```

If you set `Hosting__BearerToken=somesecret`, also add:

```json
{
  "mcpServers": {
    "powerfab": {
      "type": "http",
      "url": "http://127.0.0.1:3000/mcp",
      "headers": { "Authorization": "Bearer somesecret" }
    }
  }
}
```

Other clients (Claude Desktop, MCP Inspector, etc.) follow the same pattern —
point them at the `/mcp` URL.

## Tools

### `create_work_package`

Backed by the PowerFab `WorkPackage_Insert` command (see
[`powerfab-api/fsreqWorkPackage_Insert_Class/_index.md`](powerfab-api/fsreqWorkPackage_Insert_Class/_index.md)).

| Parameter | Type | Required | Notes |
| --- | --- | --- | --- |
| `productionControlId` | int | yes | The job that will own the work package. |
| `workPackageNumber` | string | yes | Name / number of the new work package. |
| `description` | string | no | |
| `notes` | string | no | |
| `workshopId` | int | no | Schedule the work package to a workshop. |
| `status` | int | no | Status code (configured per PowerFab installation). |
| `priority` | `"Low"` \| `"Medium"` \| `"High"` | no | Defaults to `Medium`. |
| `isFuture` | bool | no | Mark as a future placeholder. |
| `startDate` | ISO date | no | |
| `dueDate` | ISO date | no | |
| `group1`, `group2` | string | no | |
| `idempotencyKey` | string | no | Stable key to make retries safe (auto-GUID if omitted). |

On success returns:

```json
{
  "workPackageId": 4242,
  "message": "Created work package 'WP-001' (id=4242) on job 17."
}
```

On any PowerFab failure (`XMLError` or `Successful=false`), the tool returns
an MCP error whose text is the underlying PowerFab `ErrorMessage`.

## Adding new tools

1. Drop a new `[McpServerToolType]` class under
   [`src/PowerfabMcp.Server/Tools/`](src/PowerfabMcp.Server/Tools).
2. Inject `IPowerfabClient`. Build the command as an `XElement` in the
   request namespace (`PowerfabClient.RequestNs`). Always include a
   `<CommandGUID>` for idempotency on mutating commands.
3. Mark each tool method with `[McpServerTool(Name = "snake_case")]` and
   describe each parameter with `[Description("…")]` — those descriptions
   become the LLM-visible JSON schema.

`WithToolsFromAssembly()` picks up the new tool with no extra wiring.

## Tests

```powershell
dotnet test
```

Includes:

- Unit tests for `WorkPackageTools` (asserts every input field maps to the
  correct PowerFab XML element, covers the auto-GUID path and validation
  errors).
- Unit tests for `PowerfabClient` against a fake `ITeklaPowerFabAPI` (verifies
  connection caching, single-flight reconnect under concurrent load, error
  propagation, and the auth-expired retry path).
- An integration test that spins up the real ASP.NET Core host with
  `WebApplicationFactory<Program>` and POSTs a real MCP `tools/call` to
  `/mcp` — covers the full Streamable HTTP path, including bearer-token
  enforcement.

## Deployment

A [`Dockerfile`](src/PowerfabMcp.Server/Dockerfile) is included. Build from
the repo root:

```powershell
docker build -f src/PowerfabMcp.Server/Dockerfile -t powerfab-mcp:latest .
docker run --rm -p 3000:3000 `
  -e Powerfab__Username=svc-user `
  -e Powerfab__Password=secret `
  -e Powerfab__RemoteHost=10.0.0.50 `
  -e Hosting__BearerToken=long-random-token `
  -e Hosting__AllowedOrigins="https://cursor.example.com" `
  powerfab-mcp:latest
```

Production guidance:

- Terminate TLS at a fronting reverse proxy (nginx / IIS / Caddy) and forward
  to the container's plain HTTP port.
- Set `Hosting__BearerToken` whenever the server is reachable from anything
  other than `127.0.0.1`.
- Set `Hosting__AllowedOrigins` to the exact origins you want browser-hosted
  clients to use; this prevents DNS-rebinding attacks per the MCP spec.
- The `/healthz` endpoint is suitable for Docker / Kubernetes liveness probes.
