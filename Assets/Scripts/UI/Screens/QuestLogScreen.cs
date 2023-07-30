using Naninovel;
using Naninovel.UI;
using TMPro;
using UnityEngine;

public class QuestLogScreen : CustomUI
{
    [SerializeField] protected TMP_Text logText;
    private QuestLogServise logServise;

    public override UniTask InitializeAsync()
    {
        logServise = Engine.GetService<QuestLogServise>();

        return base.InitializeAsync();
    }
    protected override void HandleVisibilityChanged(bool visible)
    {
        base.HandleVisibilityChanged(visible);

        if (visible)
        {
            UpdateLog();
        }
    }

    public void UpdateLog() 
    {
        logText.text = "";
        foreach (var note in logServise.logNotes) 
        {
            logText.text += note + "\n";
        }
    }
}
