using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.MyNovel.Scripts.Minigame
{
    [InitializeAtRuntime]
    public class MemoryMinigameService : IEngineService
    {
        private const string MINIGAME_SCENE_NAME = "MemoryMinigame";

        public UniTask InitializeServiceAsync() =>
            UniTask.CompletedTask;
        public void ResetService() { }
        public void DestroyService() { }

        public async UniTask PlayGame(int level)
        {
            await SceneManager.LoadSceneAsync(MINIGAME_SCENE_NAME, LoadSceneMode.Additive);
            var gameAwaiter = GameObject.FindObjectOfType<MemoryGameAwaiter>();
            await gameAwaiter.PlayLevel(level);
            await SceneManager.UnloadSceneAsync(MINIGAME_SCENE_NAME);
        }
    }
}