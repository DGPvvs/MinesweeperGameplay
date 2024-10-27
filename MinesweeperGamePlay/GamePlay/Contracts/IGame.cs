namespace MinesweeperGamePlay.GamePlay.Contracts
{
	using MinesweeperGamePlay.GameEngine.Contracts;

	public interface IGame
	{
		public void Init(IEngine engine);
		public void InitArea(int x, int y);
		public void Run();
	}
}
