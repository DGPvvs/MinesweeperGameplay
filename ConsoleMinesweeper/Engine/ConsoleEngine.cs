namespace ConsoleMinesweeper.Engine
{
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject.Contracts;

	public class ConsoleEngine : IEngine
	{
		private IReader reader;
		private IWriter writer;

		public ConsoleEngine(IReader read, IWriter write)
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
				GameStatus status = this.GameLoop(area);
				area.SetAllVisible();
				this.writer.WriteLineOutput(area);

				if (status == GameStatus.Win)
				{
					this.writer.WriteLineOutput("WIN");
				}
				else
				{
					this.writer.WriteLineOutput("LOSE");
				}
			}
		}

		private GameStatus GameLoop(IArea area)
		{
			GameStatus result = GameStatus.InProgress;

			this.writer.WriteLineOutput(area);

			do
			{
				ITransfer? answer = null;

				do
				{
					this.writer.WriteOutput("Въведете позиция във формат X,Y,O_pen/M_ark: ");
					answer = this.reader.ReadInput();
				} while (answer.Action == FieldSymbol.Noting);

				result = area.StateOfArea(answer);

				if (result == GameStatus.InProgress)
				{
					this.writer.Clear();
					this.writer.WriteLineOutput(area);
				}

			} while (result == GameStatus.InProgress);

			return result;
		}
	}
}
