namespace MinesweeperGamePlay.GamePlay.Contracts
{
	using MinesweeperGamePlay.IO.Contracts;

	public interface IGame
	{
		void Init(IReader read, IWriter write);
		void InitArea(int x, int y);
		void Run();
	}
}
