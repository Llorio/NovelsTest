using Naninovel;
using System.Collections.Generic;

[InitializeAtRuntime]
public class GlobalMapServise : IEngineService
{
    public string MarkedLocation { get; private set; }

    private Dictionary<string, bool> locationsStatus;

    public UniTask InitializeServiceAsync()
    {
        locationsStatus = new Dictionary<string, bool>();

        return UniTask.CompletedTask;
    }

    public bool IsLocationAwaliable(string locationAlias) 
    {
        return locationsStatus.ContainsKey(locationAlias) ? locationsStatus[locationAlias] : true;
    }

    public void SetLocationAwaliable(string locationAlias, bool status)
    {
        locationsStatus[locationAlias] = status;
    }

    public void SetMarkedLocation(string locationAlias)
    {
        MarkedLocation = locationAlias;
    }

    public void DestroyService()
    {
    }

    public void ResetService()
    {
    }
}
