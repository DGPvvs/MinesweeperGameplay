﻿namespace MinesweeperGamePlay.GamePlay
{
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.GamePlay.Contracts;
	using MinesweeperGamePlay.IO.Contracts;

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

			if (status == GameStatus.Win)
			{
				this.writer.WriteLine("WIN");
			}
			else
			{
				this.writer.WriteLine("LOSE");
			}
		}

		private GameStatus GameLoop()
		{
			GameStatus result = GameStatus.InProgress;

			do
			{
				this.writer.Write("Въведете позиция във формат X,Y: ");
				string answer = this.reader.ReadLine();

				string[] coordinates = answer.Split(',');
				int x = 0;
				int y = 0;
				bool isCorrect = (int.TryParse(coordinates[0], out x) && int.TryParse(coordinates[1], out y));				

				if (isCorrect)
				{
					x--;
					y--;
					result = this.area.StateOfArea(x, y);

					if (result == GameStatus.InProgress)
					{
						this.writer.Clear();
						this.writer.WriteLine(this.area.ToString());
					}
				}

			} while (result == GameStatus.InProgress);

			return result;
		}
	}
}
