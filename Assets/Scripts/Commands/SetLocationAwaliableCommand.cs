using Naninovel;

[CommandAlias("setLocationAwaliable")]
public class SetLocationAwaliableCommand : Command
{
    public StringParameter location;
    public BooleanParameter awaliable;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var mapServise = Engine.GetService<GlobalMapServise>();

        mapServise.SetLocationAwaliable(location.Value, awaliable.Value);

        return UniTask.CompletedTask;
    }
}


