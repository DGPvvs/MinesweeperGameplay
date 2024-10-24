namespace MinesweeperGamePlay.IO.Contracts
{
	public interface IReader
	{
		public object ReadInput();
		public void Free();
	}
}
