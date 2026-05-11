using TeklaPowerFab.TeklaPowerFabAPI;

namespace PowerfabMcp.Server.Tests.Fakes;

/// <summary>
/// In-process fake of <see cref="ITeklaPowerFabAPI"/>. Captures every request
/// and returns a queue of canned responses.
/// </summary>
public sealed class FakeTeklaPowerFabAPI : ITeklaPowerFabAPI
{
    private readonly object _gate = new();
    public List<string> Requests { get; } = new();
    public Queue<Func<string, string>> Responses { get; } = new();

    public string ExecuteRemote(string ipAddress, long port, string request)
    {
        Func<string, string> next;
        lock (_gate)
        {
            Requests.Add(request);
            if (Responses.Count == 0)
            {
                throw new InvalidOperationException("No canned response queued for ExecuteRemote.");
            }

            next = Responses.Dequeue();
        }

        return next(request);
    }

    public string ExecuteDirect(string request) => throw new NotSupportedException();

    public void SetPrgmFilesDirectory(string prgmFilesDirectory) { }
}
