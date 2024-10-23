namespace ConsoleMinesweeper.IO
{
	using MinesweeperGamePlay.IO.Contracts;
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

		public void Free()
		{

		}
	}
}
