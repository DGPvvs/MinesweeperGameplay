namespace ConsoleMinesweeper.IO
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using System.Text;

	public class ConsoleReader : IReader
	{
		private StringBuilder _sb;

		public ConsoleReader()
		{
			this.Sb = new StringBuilder();
		}

		public StringBuilder Sb
		{
			get => this._sb;
			set => this._sb = value;
		}

		public string ReadLine()
		{
			this.Sb.Clear().Append(Console.ReadLine());
			return this.Sb.ToString();
		}

		public ITransfer ReadInput()
		{
			bool isCorrect = false;
			int x = -1;
			int y = -1;
			char ch = (char)FieldSymbol.Noting;

			ITransfer transfer = new Transfer(x, y, FieldSymbol.Noting);

			string[] coordinates = this.ReadLine().Split(',');
			if (coordinates.Length == 3)
			{
				isCorrect = true;
			}

			isCorrect = isCorrect && int.TryParse(coordinates[0], out x) && int.TryParse(coordinates[1], out y);
			isCorrect = isCorrect && (char.TryParse(coordinates[2], out ch));

			if (isCorrect)
			{
				ch = char.Parse(ch.ToString().ToUpper());
				isCorrect = isCorrect && (ch == (char)FieldSymbol.Mark || ch == (char)FieldSymbol.Open);
			}

			if (isCorrect)
			{
				x--;
				y--;
				transfer = new Transfer(x, y, (ch == (char)FieldSymbol.Mark) ? FieldSymbol.Mark : FieldSymbol.Open);
			}

			return transfer;
		}

		public void Free()
		{

		}
	}
}
