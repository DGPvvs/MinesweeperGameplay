namespace ConsoleMinesweeper
{
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure;

	public class ConsoleStartUp
	{
		static void Main(string[] args)
		{
			Area area = new Area(10, 10);

			(area[0, 0] as ValueField)?.SetSymbol(FieldSymbol.One);
			(area[0, 0] as VisibleField)?.SetVisible(true);
			Console.WriteLine(area[0, 0] as VisibleField);
			Console.WriteLine(area.ToString());
		}
	}
}
