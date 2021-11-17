namespace BlazorApp.Data;

public class SoftwareService
{
    public Task<Software[]> GetSoftwareByVersion(Version? version)
    {
        if(version != null)
        {
            return Task.FromResult(SoftwareManager.GetAllSoftware().Where(x => new Version(x.Version) > version).ToArray());
        }
        else
            return Task.FromResult(SoftwareManager.GetAllSoftware().ToArray());
    }
}
