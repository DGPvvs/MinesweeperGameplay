namespace RaylibMinesweeper.Engine
{
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using static Raylib_cs.Raylib;
	using static RaylibMinesweeper.Common.PublicConstant;


	public class RaylibEngine : IEngine
	{
		private IReader reader;
		private IWriter writer;

		public RaylibEngine(IReader read, IWriter write)
		{
			this.Init(read, write);
		}

		public void Init(IReader read, IWriter write)
		{
			this.reader = read;
			this.writer = write;
		}

		public void Loop(object obj)
		{
			IArea area = null;

			if (obj is Area)
			{
				area = obj as Area;
			}

			if (area != null)
			{
				int width = area.MaxY;
				int height = area.MaxX;

				InitWindow(width * (CELL_SIZE), height * (CELL_SIZE), "");
				SetTargetFPS(TARGET_FPS);

				this.GameLoop(area);

				CloseWindow();
			}
		}

		private void GameLoop(IArea area)
		{
			GameStatus gameStatus = GameStatus.InProgress;

			while (!WindowShouldClose())
			{
				ITransfer answer = this.reader.ReadInput();

				if (answer.Action != FieldSymbol.Noting)
				{
					int x = answer.XPosition;
					int y = answer.YPosition;

					if (x >= 0 && y >= 0)
					{
						int row = x / (CELL_SIZE);
						int coll = y / (CELL_SIZE);

						gameStatus = area.StateOfArea(new Transfer(row, coll, answer.Action));
					}

					if (gameStatus != GameStatus.InProgress)
					{
						area.SetAllVisible();
					}
				}				

				BeginDrawing();
				this.writer.Clear();
				this.writer.WriteLineOutput(area);
				EndDrawing();
			}
		}
	}
}
