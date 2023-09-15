using Naninovel;

namespace Assets.MyNovel.Scripts.QuestLog
{
    [CommandAlias("quest")]
    public class QuestLogCommand : Command
    {
        [RequiredParameter]
        public StringParameter Summary;
        public StringParameter Location;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            Engine.GetService<QuestLogService>().UpdateQuestLog(new QuestLogData(Summary, Location));

            return UniTask.CompletedTask;
        }
    }
}