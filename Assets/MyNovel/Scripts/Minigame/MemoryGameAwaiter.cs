using DTT.MinigameMemory;
using Naninovel;
using UnityEngine;

namespace Assets.MyNovel.Scripts.Minigame
{
    public class MemoryGameAwaiter : MonoBehaviour
    {
        [SerializeField] private MemoryGameManager _gameManager;
        [SerializeField] private MemoryGameSettings[] _levels;

        private bool _isGamePlaying;

        private void OnEnable() =>
            _gameManager.Finish += OnGameFinish;

        private void OnDisable() =>
            _gameManager.Finish -= OnGameFinish;

        public UniTask PlayLevel(int level)
        {
            _isGamePlaying = true;
            _gameManager.StartGame(_levels[level]);
            return UniTask.WaitUntil(() => !_isGamePlaying);
        }

        private void OnGameFinish(MemoryGameResults obj) =>
            _isGamePlaying = false;
    }
}