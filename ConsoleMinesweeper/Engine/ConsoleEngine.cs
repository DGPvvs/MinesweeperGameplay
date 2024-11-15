namespace ConsoleMinesweeper.Engine
{
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using MinesweeperGamePlay.TransferObject;

	public class ConsoleEngine : IEngine
	{
		private IReader reader;
		private IWriter writer;
		private IArea area;
		private GameStatus status;

		public ConsoleEngine(IReader read, IWriter write)
		{
			this.Init(read, write);
			this.area = null;
			this.status = GameStatus.Started;
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

		public void Loop()
		{
			do
			{
				if (this.status == GameStatus.Started)
				{
					ITransfer answer = null;

					do
					{
						this.writer.Clear();
						this.writer.WriteLineOutput(new WriteTransferObject(GameStatus.Started, null, "Изберете игра:"));
						this.writer.WriteLineOutput(new WriteTransferObject(GameStatus.Started, null, "1: 9 х 9"));
						this.writer.WriteLineOutput(new WriteTransferObject(GameStatus.Started, null, "2: 16 х 16"));
						this.writer.WriteLineOutput(new WriteTransferObject(GameStatus.Started, null, "3: 30 х 16"));
						this.writer.WriteLineOutput(new WriteTransferObject(GameStatus.Started, null, "4: Край"));
						answer = this.reader.ReadInput();

						int chois = answer.XPosition;

						switch (chois)
						{
							case 1:
								this.InitArea(9, 9);
								this.status = GameStatus.InProgress;
								break;
							case 2:
								this.InitArea(16, 16);
								this.status = GameStatus.InProgress;
								break;
							case 3:
								this.InitArea(16, 30);
								this.status = GameStatus.InProgress;
								break;
							default:
								this.status = GameStatus.Exit;
								break;
						}
					} while (this.status == GameStatus.Started);
				}

				if (this.status != GameStatus.Exit)
				{
					this.status = this.GameLoop();
					this.area.SetAllVisible();
					this.writer.WriteLineOutput(new WriteTransferObject(this.status, this.area, string.Empty));

					if (this.status == GameStatus.Win)
					{
						this.writer.WriteLineOutput(new WriteTransferObject(GameStatus.Started, null, "WIN"));
					}
					else
					{
						this.writer.WriteLineOutput(new WriteTransferObject(GameStatus.Started, null, "LOSE"));
					}

					this.status = GameStatus.Started;
					this.reader.ReadInput();
				}

			} while (this.status != GameStatus.Exit);
		}

		private GameStatus GameLoop()
		{
			GameStatus result = GameStatus.InProgress;

			this.writer.WriteLineOutput(new WriteTransferObject(result, this.area, string.Empty));

			do
			{
				ITransfer answer = null;

				do
				{
					this.writer.WriteOutput(new WriteTransferObject(GameStatus.Started, null, "Въведете позиция във формат X,Y,O_pen/M_ark: "));
					answer = this.reader.ReadInput();
				} while (answer.Action == FieldSymbol.Noting);

				result = area.StateOfArea(answer);

				if (result == GameStatus.InProgress)
				{
					this.writer.Clear();
					this.writer.WriteLineOutput(new WriteTransferObject(result, this.area, string.Empty));
				}

			} while (result == GameStatus.InProgress);

			return result;
		}
	}
}
