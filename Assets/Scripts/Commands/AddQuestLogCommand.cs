using Naninovel;

[CommandAlias("addQuestLog")]
public class AddQuestLogCommand : Command, Command.ILocalizable
{
    public StringParameter note;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var logServise = Engine.GetService<QuestLogServise>();
        logServise.AddNote(note.Value);

        return UniTask.CompletedTask;
    }
}
