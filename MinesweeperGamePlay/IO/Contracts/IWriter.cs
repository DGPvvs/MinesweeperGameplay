namespace MinesweeperGamePlay.IO.Contracts
{
	public interface IWriter
	{
		void Clear();
		void Write(string s);
		void WriteLine(string s);
	}
}
