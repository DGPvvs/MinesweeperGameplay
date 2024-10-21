namespace ConsoleMinesweeper.IO
{
	using MinesweeperGamePlay.IO.Contracts;

	public class ConsoleReader : IReader
	{
		public string ReadLine() => Console.ReadLine();
	}
}
