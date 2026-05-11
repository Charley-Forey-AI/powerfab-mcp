FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY src/PowerfabMcp.Server/PowerfabMcp.Server.csproj src/PowerfabMcp.Server/
RUN dotnet restore src/PowerfabMcp.Server/PowerfabMcp.Server.csproj
COPY . .
RUN dotnet publish src/PowerfabMcp.Server/PowerfabMcp.Server.csproj \
    -c Release \
    -o /app/publish \
    --no-restore \
    /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Bind to all interfaces inside the container; expose with a reverse proxy.
ENV Hosting__BindUrl=http://0.0.0.0:3000
EXPOSE 3000

HEALTHCHECK --interval=30s --timeout=5s --start-period=10s --retries=3 \
    CMD wget --quiet --tries=1 --spider http://127.0.0.1:3000/healthz || exit 1

ENTRYPOINT ["dotnet", "PowerfabMcp.Server.dll"]
