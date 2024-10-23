namespace ConsoleMinesweeper
{
	using ConsoleMinesweeper.IO;
	using MinesweeperGamePlay.GamePlay;
	using MinesweeperGamePlay.GamePlay.Contracts;
	using MinesweeperGamePlay.IO.Contracts;

	public class ConsoleStartUp
	{
		static void Main(string[] args)
		{
			//IReader reader = new ConsoleReader();
			IWriter writer = new ConsoleWriter();

			IGame game = new Game((writer as ConsoleReader)!, writer, 17, 26);
			game.Run();
			//Area area = new Area(16, 50);

			//(area[0, 0] as ValueField)?.SetSymbol(FieldSymbol.One);
			//(area[0, 0] as VisibleField)?.SetVisible(true);
			//Console.WriteLine(area[0, 0] as VisibleField);
			//area.SetAllVisible();
			//Console.WriteLine(area.ToString());
			//Console.WriteLine(((char)(FieldSymbol.Mine)).ToString());
		}	
	}
}
