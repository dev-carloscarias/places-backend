using Places.Application.Interfaces;
using Places.Domain.Resources;

namespace Places.Infrastructure.Services;

public class ResourceService : IResourceService
{
    public string GetValueFromKey(string key)
    {
        return Resource.ResourceManager.GetString(key)!;
    }
}