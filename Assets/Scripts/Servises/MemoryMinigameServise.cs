using DTT.MinigameMemory;
using Naninovel;
using System;
using UnityEngine;

[InitializeAtRuntime]
public class MemoryMinigameServise : IEngineService
{
    public event Action<MemoryGameSettings> onGameStart;
    public bool isGameRunning { get; private set; }

    private MemoryGameSettings gameSettings;

    public UniTask InitializeServiceAsync()
    {
        return UniTask.CompletedTask;
    }

    public async UniTask RunGame(AsyncToken asyncToken = default) 
    {
        isGameRunning = true;
        await LoadResourses();
        onGameStart?.Invoke(gameSettings);
        while (isGameRunning) 
        {
            await AsyncUtils.WaitEndOfFrameAsync(asyncToken);
        }
        Unload();
    }

    public void OnGameFinished(MemoryGameResults results) 
    {
        isGameRunning = false;

    }

    public UniTask LoadResourses() 
    {
        var req = Resources.LoadAsync<MemoryGameSettings>("Minigames/Memory");

        req.completed += (_) => gameSettings = req.asset as MemoryGameSettings;

        return req.ToUniTask();
    }

    public void Unload() 
    {
        Resources.UnloadAsset(gameSettings);
        gameSettings = null;
    }

    public void ResetService()
    {
    }

    public void DestroyService()
    {
    }
}
