using Naninovel;
using System.Collections.Generic;

[InitializeAtRuntime]
public class QuestLogServise : IEngineService
{
    public List<string> logNotes;

    public UniTask InitializeServiceAsync()
    {
        logNotes = new List<string>();

        return UniTask.CompletedTask;
    }

    public void AddNote(string note) 
    {
        logNotes.Add(note);
    }

    public void Clear()
    {
        logNotes.Clear();
    }

    public void DestroyService()
    {
    }

    public void ResetService()
    {
    }
}
