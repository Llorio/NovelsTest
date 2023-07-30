using Naninovel;

[CommandAlias("runMemoryMinigame")]
public class RunMemoryMinigameCommand : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        Wait.Value = true;
        var servise = Engine.GetService<MemoryMinigameServise>();
        return servise.RunGame(asyncToken);
    }

    
}
