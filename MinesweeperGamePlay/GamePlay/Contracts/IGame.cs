namespace MinesweeperGamePlay.GamePlay.Contracts
{
	using MinesweeperGamePlay.GameEngine.Contracts;

	public interface IGame
	{
		void Init(IEngine engine);
		void Run();
	}
}
