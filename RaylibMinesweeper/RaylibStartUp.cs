namespace RaylibMinesweeper
{
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.GamePlay;
	using MinesweeperGamePlay.GamePlay.Contracts;
	using MinesweeperGamePlay.IO.Contracts;
	using RaylibMinesweeper.Engine;
	using RaylibMinesweeper.IO;

	public class RaylibStartUp
	{
		static void Main(string[] args)
		{

			IWriter writer = new RaylibWriter();
			IEngine engine = new RaylibEngine(writer as RaylibReader, writer);

			IGame game = new Game(engine, 32, 35);
			game.Run();
		}
	}
}
