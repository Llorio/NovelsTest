using Naninovel;

[CommandAlias("clearQuestLog")]
public class ClearQuestLogCommand : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var logServise = Engine.GetService<QuestLogServise>();
        logServise.Clear();

        return UniTask.CompletedTask;
    }
}
