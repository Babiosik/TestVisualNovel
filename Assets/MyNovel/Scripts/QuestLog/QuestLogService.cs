using Naninovel;
using UnityEngine.Events;

namespace Assets.MyNovel.Scripts.QuestLog
{
    [InitializeAtRuntime]
    public class QuestLogService : IEngineService
    {
        public event UnityAction<QuestLogData> QuestLogUpdated;
        public QuestLogData LastQuestLog { get; private set; }

        public UniTask InitializeServiceAsync() =>
            UniTask.CompletedTask;
        public void ResetService() { }
        public void DestroyService() { }

        public void UpdateQuestLog(QuestLogData data)
        {
            LastQuestLog = data;

            QuestLogUpdated?.Invoke(LastQuestLog);
        }
    }
}