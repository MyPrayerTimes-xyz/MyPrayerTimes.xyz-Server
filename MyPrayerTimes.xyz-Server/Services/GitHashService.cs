namespace MyPrayerTimes.xyz_Server.Services;
using System.Reflection;

public class GitHashService
{
    private readonly string _gitHash;
    
    public GitHashService()
    {
        var gitHash = Assembly
            .GetEntryAssembly()
            ?.GetCustomAttributes<AssemblyMetadataAttribute>()
            .FirstOrDefault(attr => attr.Key == "GitHash")?.Value;
        _gitHash = gitHash ?? String.Empty;
    }

    public string GetGitHash() => _gitHash;
}