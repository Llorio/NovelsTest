using Naninovel;

[CommandAlias("setMapMarker")]
public class SetMapMarkerCommand : Command
{
    public StringParameter location;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var mapServise = Engine.GetService<GlobalMapServise>();
        mapServise.SetMarkedLocation(location.Value);

        return UniTask.CompletedTask;
    }
}
