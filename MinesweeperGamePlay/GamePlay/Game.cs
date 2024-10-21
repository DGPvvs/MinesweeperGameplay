namespace MinesweeperGamePlay.GamePlay
{
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.GamePlay.Contracts;
	using MinesweeperGamePlay.IO.Contracts;
	using System;
	using MinesweeperGamePlay.Enums;

	public class Game : IGame
	{
		private IReader reader;
		private IWriter writer;
		private IArea area;

		public Game(IReader read, IWriter write, int x, int y)
		{
			this.Init(read, write);
			this.InitArea(x, y);
		}

		public void Init(IReader read, IWriter write)
		{
			this.reader = read;
			this.writer = write;
		}

		public void InitArea(int x, int y)
		{
			this.area = new Area(x, y);
		}

		public void Run()
		{
			GameStatus status = this.GameLoop();
			this.area.SetAllVisible();
			this.writer.WriteLine(this.area.ToString());
		}

		private GameStatus GameLoop()
		{
			GameStatus result = GameStatus.InProgress;

			do
			{
				this.writer.Write("Въведете позиция във формат X,Y: ");
				string answer = this.reader.ReadLine();


			} while (result == GameStatus.InProgress);



			throw new NotImplementedException();
		}
	}
}
