namespace MinesweeperGamePlay.GameEngine.Contracts
{
	using MinesweeperGamePlay.IO.Contracts;

	public interface IEngine
	{
		public void Init(IReader read, IWriter write);
		public void Loop(object obj);
	}
}
