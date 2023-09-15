using Naninovel;
using UnityEngine.Events;

namespace Assets.MyNovel.Scripts.QuestLog
{
    [InitializeAtRuntime]
    public class QuestLogService : IEngineService
    {
        public event UnityAction<string> QuestLogUpdated;
        public string LastQuestLog { get; private set; } = "";

        public UniTask InitializeServiceAsync() =>
            UniTask.CompletedTask;
        public void ResetService() { }
        public void DestroyService() { }

        public void UpdateQuestLog(string description)
        {
            LastQuestLog = description;

            QuestLogUpdated?.Invoke(LastQuestLog);
        }
    }
}