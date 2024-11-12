namespace MinesweeperGamePlay.GameEngine.Contracts
{
	using MinesweeperGamePlay.IO.Contracts;

	public interface IEngine
	{
		void Init(IReader read, IWriter write);
		void InitArea(int x, int y);
		void Loop();
	}
}
