using Microsoft.Extensions.Caching.Memory;
using myprayertimes.esolat.Models;

namespace MyPrayerTimes.xyz_Server.Services;

public class ServerStorageService
{
    private readonly MemoryCache _cache;

    public ServerStorageService()
    {
        _cache = new MemoryCache(new MemoryCacheOptions());
    }
    
    public EsolatResponse Get(string key)
    {
        return _cache.Get<EsolatResponse>(key);
    }

    public void Set(string key, EsolatResponse val)
    {
        var cacheExp = DateTime.Today.AddDays(1);
        _cache.Set(key, val, cacheExp);
    }

    public bool ContainsKey(string key)
    {
        return _cache.TryGetValue(key, out _);
    }
}