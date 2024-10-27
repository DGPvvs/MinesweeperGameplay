namespace ConsoleMinesweeper
{
	using ConsoleMinesweeper.Engine;
	using ConsoleMinesweeper.IO;
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.GamePlay;
	using MinesweeperGamePlay.GamePlay.Contracts;
	using MinesweeperGamePlay.IO.Contracts;

	public class ConsoleStartUp
	{
		static void Main(string[] args)
		{
			IWriter writer = new ConsoleWriter();
			IEngine engine = new ConsoleEngine(writer as ConsoleReader, writer);

			IGame game = new Game(engine, 17, 26);

			game.Run();
		}	
	}
}
