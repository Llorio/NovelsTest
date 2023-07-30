using Naninovel.UI;
using UnityEngine;
using DTT.MinigameMemory;
using Naninovel;

public class MemoryMinigameScreen : CustomUI
{
    [SerializeField] private MemoryGameManager manager;

    private MemoryMinigameServise memoryMinigameServise;

    public override UniTask InitializeAsync()
    {
        memoryMinigameServise = Engine.GetService<MemoryMinigameServise>();
        memoryMinigameServise.onGameStart += OnGameStart;
        return base.InitializeAsync();
    }

    protected void OnGameStart(MemoryGameSettings settings) 
    {
        Show();
        manager.StartGame(settings);
        manager.Finish += OnGameFinish;
    }

    protected void OnGameFinish(MemoryGameResults results)
    {
        Hide();
        memoryMinigameServise.OnGameFinished(results);
    }


    protected override void OnDestroy()
    {
        base.OnDestroy();

        memoryMinigameServise.onGameStart -= OnGameStart;
    }
}
