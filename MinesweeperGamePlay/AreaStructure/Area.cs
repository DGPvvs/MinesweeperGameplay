namespace MinesweeperGamePlay.AreaStructure
{
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure;
	using MinesweeperGamePlay.FieldsStructure.Contracts;
	using System.Text;

	public class Area : IArea
	{
		private IField[,] fields;
		private int maxX;
		private int maxY;

		public Area(IField[,] fields)
		{
			this.fields = fields;
			this.SetDimensions();
		}

		public Area(int x, int y)
		{
			this.fields = new IField[x, y];
			this.SetDimensions();
			this.InitArea(this.SetMineNum());
		}

		public IField this[int x, int y]
		{
			get
			{
				if (this.IsInvalidIndexes(x, y))
				{
					throw new IndexOutOfRangeException("Индексите са извън границите на областа");
				}

				return this.fields[x, y];

			}

			private set
			{
				if (this.IsInvalidIndexes(x, y))
				{
					throw new IndexOutOfRangeException("Индексите са извън границите на областа");
				}

				this.fields[x, y] = value;
			}
		}

		public void SetAllVisible()
		{
			for (int i = 0; i < this.maxX; i++)
			{
				for (int j = 0; j < this.maxY; j++)
				{
					//IField field = new VisibleField(i, j, FieldSymbol.Empty);
					//(field as VisibleField).SetVisible(true);
					(this.fields[i, j] as VisibleField).SetVisible(true);
				}
			}
		}

		public void InitArea(int mineNum = 30)
		{
			Random rnd = new Random();

			this.SetAreaWithNoting();

			HashSet<IField> set = new HashSet<IField>();

			do
			{
				int x = rnd.Next(0, this.maxX);
				int y = rnd.Next(0, this.maxY);

				IField field = new VisibleField(x, y, FieldSymbol.Mine);
				//(field as VisibleField).SetVisible(true);

				if (!set.Contains(field))
				{
					set.Add(field);
					this.fields[x, y] = field;
					mineNum--;
				}
			} while (mineNum > 0);

			//Console.WriteLine(this.ToString());

			this.SetNumbers();
		}

		private void SetAreaWithNoting()
		{
			for (int i = 0; i < this.maxX; i++)
			{
				for (int j = 0; j < this.maxY; j++)
				{
					IField field = new VisibleField(i, j, FieldSymbol.Empty);
					//(field as VisibleField).SetVisible(true);
					this.fields[i, j] = field;
				}
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			StringBuilder sbRow = new StringBuilder();
			for (int i = 0; i < this.maxX; i++)
			{
				sbRow.Clear().Append($"|");
				for (int j = 0; j < this.maxY; j++)
				{
					sbRow.Append($"{(this.fields[i, j] as VisibleField)?.ToString()}|");
				}

				sb.AppendLine(sbRow.ToString());
			}

			return sb.ToString();
		}

		private void SetNumbers()
		{
			for (int x = 0; x < this.maxX; x++)
			{
				for (int y = 0; y < this.maxY; y++)
				{
					VisibleField field = this.fields[x, y] as VisibleField;

					int neighborMineCount = 0;

					if (field?.Value == FieldSymbol.Empty)
					{
						for (int xx = x - 1; xx <= x + 1; xx++)
						{
							for (int yy = y - 1; yy <= y + 1; yy++)
							{
								neighborMineCount += ((!this.IsInvalidIndexes(xx, yy)) && ((this.fields[xx, yy] as ValueField)?.Value == FieldSymbol.Mine))
									? 1
									: 0;
							}
						}

						if (neighborMineCount > 0)
						{
							//(this.fields[x, y] as ValueField).SetSymbol((FieldSymbol)neighborMineCount);
							//(this.fields[x, y] as ValueField).SetSymbol((FieldSymbol)neighborMineCount);
							//field.SetSymbol((FieldSymbol)(neighborMineCount + (char)FieldSymbol.Zero));
							field.SetSymbol((FieldSymbol)(neighborMineCount + 48));
							//Console.WriteLine(neighborMineCount + 48);
						}
					}
				}
			}
		}

		private void SetDimensions()
		{
			this.maxX = this.fields.GetLength(0);
			this.maxY = this.fields.GetLength(1);
		}

		private bool IsInvalidIndexes(int x, int y) => x < 0
													   || x >= this.maxX
													   || y < 0
													   || y >= this.maxY;

		private int SetMineNum()
		{
			int range = this.maxY * this.maxX;

			if (range <= 9 * 9)
			{
				return 10;
			}
			else if (range <= 16 * 16)
			{
				return 40;
			}
			else if (range <= 30 * 16)
			{
				return 99;
			}

			return 130;
		}
	}
}
