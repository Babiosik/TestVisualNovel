namespace Assets.MyNovel.Scripts.QuestLog
{
    public class QuestLogData
    {
        public string Description { get; private set; }
        public string Location { get; private set; }

        public QuestLogData(string description, string location)
        {
            Description = description;
            Location = location;
        }
    }
}