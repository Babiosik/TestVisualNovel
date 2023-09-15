using Naninovel;

namespace Assets.MyNovel.Scripts.QuestLog
{
    [CommandAlias("quest")]
    public class QuestLogCommand : Command
    {
        [RequiredParameter]
        public StringParameter Summary;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            Engine.GetService<QuestLogService>().UpdateQuestLog(Summary);

            return UniTask.CompletedTask;
        }
    }
}