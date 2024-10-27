namespace MinesweeperGamePlay.IO.Contracts
{
	public interface IWriter : IReader
	{
		public void Clear();
		public void WriteOutput(object obj);
		public void WriteLineOutput(object obj);
	}
}
