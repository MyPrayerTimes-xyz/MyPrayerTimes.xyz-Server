using myprayertimes.esolat.Models;

namespace MyPrayerTimes.xyz_Server.Services;

public class ServerStorageService
{
    readonly IDictionary<string, EsolatResponse> _cache;

    public ServerStorageService()
    {
        _cache = new Dictionary<string, EsolatResponse>();
    }

    public IDictionary<string, EsolatResponse> Cache() => _cache;
}