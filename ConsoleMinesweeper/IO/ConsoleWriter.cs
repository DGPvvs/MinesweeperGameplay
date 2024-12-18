﻿namespace ConsoleMinesweeper.IO
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using System.Text;

	public class ConsoleWriter : ConsoleReader, IWriter
	{
		public ConsoleWriter() : base()
		{

		}

		public void WriteOutput(IWriteTransferObject obj)
		{
			if (obj.Status == GameStatus.Started)
			{
				this.Write(obj.Text);
			}
		}

		public void WriteLineOutput(IWriteTransferObject obj)
		{
			if (obj.Status == GameStatus.Started)
			{
				this.WriteLine(obj.Text);
			}
			else
			{
				this.WriteLine(obj.Area.ToString());
			}
		}

		public void Clear()
		{
			Console.Clear();
		}

		private void Write(string s)
		{
			this.Sb.Clear().Append(s);
			Console.Write(this.Sb.ToString());
		}

		private void WriteLine(string s)
		{
			string[] temp = s.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

			if (temp[0][0] != '|')
			{
				this.Sb.Clear().Append(s);
				Console.WriteLine(this.Sb.ToString());
				return;
			}

			int rows = temp.Length;
			int colls = temp[0].Split('|').Length - 1;

			int rulerRows = rows.ToString().Length;
			int rulerColls = colls.ToString().Length;

			string indent = new String(' ', rulerColls);

			this.Sb.Clear();
			StringBuilder sbRow = new StringBuilder().Append(indent).Append('|');
			for (int row = 1; row <= rulerRows; row++)
			{
				for (int coll = 1; coll < colls; coll++)
				{
					int n = coll / (int)Math.Pow(10, row - 1);
					sbRow.Append((n % Math.Pow(10, row)).ToString()).Append('|');
				}

				this.Sb.Insert(0, sbRow.AppendLine().ToString());
				sbRow.Clear().Append(indent).Append('|');
			}

			this.Sb.Append(indent).AppendLine(new String('_', 2 * colls - 1));

			for (int row = 0; row < temp.Length; row++)
			{
				this.Sb
					.Append(new String('0', rulerColls - (row + 1).ToString().Length))
					.Append((row + 1).ToString())
					.AppendLine(temp[row]);
			}
			Console.WriteLine(this.Sb.ToString());
		}
	}
}
