namespace ConsoleMinesweeper.IO
{
	using MinesweeperGamePlay.IO.Contracts;

	public class ConsoleWriter : IWriter
	{
		public void Write(string s)
		{
			Console.Write(s);
		}

		public void WriteLine(string s)
		{
			Console.WriteLine(s);
		}
	}
}
