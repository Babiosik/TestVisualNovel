using Naninovel;

namespace Assets.MyNovel.Scripts.Minigame
{
    [CommandAlias("minigame")]
    public class StartGameCommand : Command
    {
        public IntegerParameter Level;

        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            MemoryMinigameService minigame = Engine.GetService<MemoryMinigameService>();
            return minigame.PlayGame(Level?.Value ?? 0);
        }
    }
}