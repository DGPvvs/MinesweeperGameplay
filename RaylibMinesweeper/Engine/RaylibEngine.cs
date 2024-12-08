namespace RaylibMinesweeper.Engine
{
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using RaylibMinesweeper.Common;
	using RaylibMinesweeper.Enums;
	using static Raylib_cs.Raylib;
	using static RaylibMinesweeper.Common.PublicConstant;


	public class RaylibEngine : IEngine
	{
		private IReader reader;
		private IWriter writer;
		private IArea area;
		private GameStatus status;

		public RaylibEngine(IReader read, IWriter write)
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
			InitWindow(PublicConstant.START_WIDTH, PublicConstant.START_HEIGHT, PublicConstant.STARTED_TITLE);
			SetTargetFPS(TARGET_FPS);

			this.GameLoop();

			CloseWindow();
		}

		private void GameLoop()
		{
			GameStatus gameStatus = GameStatus.InProgress;
			IWriteTransferObject wTO = null;

			while (!WindowShouldClose())
			{
				if (this.status == GameStatus.Started)
				{
					wTO = new WriteTransferObject(GameStatus.Started, null, PublicConstant.STARTED_TITLE);
				}

				BeginDrawing();
				this.writer.Clear();
				this.writer.WriteLineOutput(wTO);
				EndDrawing();

				ITransfer answer = this.reader.ReadInput();

				if (answer.Action != FieldSymbol.Noting)
				{
					int x = answer.XPosition;
					int y = answer.YPosition;

					if (x >= 0 && y >= 0)
					{
						if (this.status == GameStatus.InProgress)
						{
							int row = x / (CELL_SIZE);
							int coll = y / (CELL_SIZE);

							this.status = area.StateOfArea(new Transfer(row, coll, answer.Action));
							if (this.status != GameStatus.InProgress)
							{
								area.SetAllVisible();
							}
						}

						if (this.status == GameStatus.Started)
						{
							SetWindowSize(PublicConstant.START_WIDTH, PublicConstant.START_HEIGHT);
							SetWindowTitle(PublicConstant.STARTED_TITLE);

							RangeEnum range = this.IsChoisButton(x, y, RangeEnum.None);

							if (range != RangeEnum.None)
							{
								this.status = GameStatus.InProgress;

								switch (range)
								{
									case RangeEnum.Range9X9:
										this.InitArea(9, 9);
										SetWindowTitle(PublicConstant.TITLE_9X9);
										break;
									case RangeEnum.Range16X16:
										this.InitArea(16, 16);
										SetWindowTitle(PublicConstant.TITLE_16X16);
										break;
									case RangeEnum.Range30X16:
										this.InitArea(16, 30);
										SetWindowTitle(PublicConstant.TITLE_30X16);
										break;
									default:
										break;
								}

								int width = area.MaxY;
								int height = area.MaxX;

								SetWindowSize(width * (CELL_SIZE), height * (CELL_SIZE));
								wTO = new WriteTransferObject(GameStatus.InProgress, this.area, PublicConstant.STARTED_TITLE);
							}							
						}						
					}

					if ((this.status == GameStatus.Win || this.status == GameStatus.Lose) && answer.Action == FieldSymbol.Space)
					{
						this.status = GameStatus.Started;
						SetWindowSize(PublicConstant.START_WIDTH, PublicConstant.START_HEIGHT);
						SetWindowTitle(PublicConstant.STARTED_TITLE);
					}
				}
			}
		}

		private RangeEnum IsChoisButton(int x, int y, RangeEnum range)
		{
			if (!this.IsButtonPush(x, y))
			{
				return range;
			}

			if (y >= PublicConstant.BUTTON_9X9_WIDTH_START && y <= PublicConstant.BUTTON_9X9_WIDTH_END)
			{
				return RangeEnum.Range9X9;
			}
			else if (y >= PublicConstant.BUTTON_16X16_WIDTH_START && y <= PublicConstant.BUTTON_16X16_WIDTH_END)
			{
				return RangeEnum.Range16X16;
			}

			return RangeEnum.Range30X16;
		}

		private bool IsButtonPush(int x, int y)
		{
			bool isButtonHeight = x >= PublicConstant.BUTTON_HEIGHT_START && x <= PublicConstant.BUTTON_HEIGHT_END;

			return isButtonHeight
					&& ((y >= PublicConstant.BUTTON_9X9_WIDTH_START && y <= PublicConstant.BUTTON_9X9_WIDTH_END) 
					|| (y >= PublicConstant.BUTTON_16X16_WIDTH_START && y <= PublicConstant.BUTTON_16X16_WIDTH_END)
					|| (y >= PublicConstant.BUTTON_30X16_WIDTH_START && y <= PublicConstant.BUTTON_30X16_WIDTH_END));
		}
	}
}
