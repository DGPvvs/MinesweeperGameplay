namespace MinesweeperGamePlay.IO.Contracts
{
	public interface IWriter
	{
		public void Clear();
		public void WriteOutput(object obj);
		public void WriteLineOutput(object obj);
	}
}
