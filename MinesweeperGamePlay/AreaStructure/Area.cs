namespace MinesweeperGamePlay.AreaStructure
{
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Common;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure;
	using MinesweeperGamePlay.FieldsStructure.Contracts;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using System.Text;

	public class Area : IArea
	{
		private IField[,] fields;
		private int maxX;
		private int maxY;
		private int minesCount;
		private int tottalAreaCount;
		private int currentVisibleFieldsCount;
		private bool isFirst;

		public Area(IField[,] fields)
		{
			this.fields = fields;
			this.SetDimensions();
		}

		public Area(int x, int y)
		{
			this.fields = new IField[x, y];
			this.SetDimensions();
			this.minesCount = this.SetMineNum();
			this.isFirst = true;
			this.SetAreaWithNoting();
		}

		public int MaxX => this.maxX;

		public int MaxY => this.maxY;

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

		public GameStatus StateOfArea(ITransfer transfer)
		{
			GameStatus result = GameStatus.InProgress;

			int x = transfer.XPosition;
			int y = transfer.YPosition;
			FieldSymbol action = transfer.Action;

			if (action == FieldSymbol.Mark)
			{
				(this[x, y] as MarkedField)!.ToggleMark();
			}
			else
			{
				if (this.isFirst)
				{
					//this.InitArea(new VisibleField(x, y, FieldSymbol.Empty), this.minesCount);
					this.InitArea(this[x, y], this.minesCount);
					this.isFirst = false;
				}

				//IField field = this[x, y];

				switch ((this[x, y] as VisibleField)!.Value)
				{
					case FieldSymbol.Mine:
						result = GameStatus.Lose;
						this.SetAllVisible();
						break;
					case FieldSymbol.Empty:
						result = this.RevelationArea(x, y);
						break;
					default:
						(this[x, y] as VisibleField)!.SetVisible(PublicConstants.Visible);
						result = this.IsWin();
						break;
				}
			}

			return result;
		}

		public void SetAllVisible()
		{
			for (int i = 0; i < this.maxX; i++)
			{
				for (int j = 0; j < this.maxY; j++)
				{
					(this[i, j] as VisibleField)!.SetVisible(PublicConstants.Visible);
				}
			}
		}

		public void InitArea(IField field, int mineNum = 30)
		{
			Random rnd = new Random();

			HashSet<IField> set = new HashSet<IField>();

			do
			{
				int x = rnd.Next(0, this.maxX);
				int y = rnd.Next(0, this.maxY);

				IField newField = new VisibleField(x, y, FieldSymbol.Mine);

				if (!newField.Equals(field))
				{
					set.Add(newField);
				}
			} while (mineNum != set.Count);

			foreach (var item in set)
			{
				this[item.X, item.Y] = item;
			}

			this.SetNumbers();
		}

		private void SetAreaWithNoting()
		{
			for (int i = 0; i < this.maxX; i++)
			{
				for (int j = 0; j < this.maxY; j++)
				{
					IField field = new VisibleField(i, j, FieldSymbol.Empty);
					this[i, j] = field;
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
					sbRow.Append($"{(this[i, j] as VisibleField)?.ToString()}|");
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
					int neighborMineCount = 0;

					if ((this[x, y] as ValueField)!.Value == FieldSymbol.Empty)
					{
						for (int xx = Math.Max(x - 1, 0); xx <= Math.Min(x + 1, this.maxX - 1); xx++)
						{
							for (int yy = Math.Max(y - 1, 0); yy <= Math.Min(y + 1, this.maxY - 1); yy++)
							{
								neighborMineCount += ((this[xx, yy] as ValueField)?.Value == FieldSymbol.Mine)
									? 1
									: 0;
							}
						}

						if (neighborMineCount > 0)
						{
							(this[x, y] as VisibleField)!.SetSymbol((FieldSymbol)(neighborMineCount + FieldSymbol.Zero));
						}
					}
				}
			}
		}

		private void SetDimensions()
		{
			this.maxX = this.fields.GetLength(0);
			this.maxY = this.fields.GetLength(1);
			this.tottalAreaCount = this.maxX * this.maxY;
			this.currentVisibleFieldsCount = 0;
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
			else if (range <= 16 * 30)
			{
				return 99;
			}

			return 130;
		}

		private GameStatus RevelationArea(int x, int y)
		{
			GameStatus result = GameStatus.InProgress;

			Queue<IField> fieldsQueue = new Queue<IField>();

			(this[x, y] as VisibleField)?.SetVisible(PublicConstants.Visible);

			fieldsQueue.Enqueue(this[x, y]);

			while (fieldsQueue.Count > 0)
			{
				IField field = fieldsQueue.Dequeue();
				x = field.X;
				y = field.Y;

				for (int xx = Math.Max(x - 1, 0); xx <= Math.Min(x + 1, this.maxX - 1); xx++)
				{
					for (int yy = Math.Max(y - 1, 0); yy <= Math.Min(y + 1, this.maxY - 1); yy++)
					{
						if (!(this[xx, yy] as VisibleField)!.IsVisible)
						{
							(this[xx, yy] as VisibleField)!.SetVisible(PublicConstants.Visible);

							if ((this[xx, yy] as ValueField)!.Value == FieldSymbol.Empty)
							{
								fieldsQueue.Enqueue(this[xx, yy]);
							}
						}
					}
				}
			}

			result = this.IsWin();

			return result;
		}

		private GameStatus IsWin()
		{
			GameStatus result = GameStatus.InProgress;

			this.currentVisibleFieldsCount = this.VisibledCount();
			bool isWin = this.currentVisibleFieldsCount + this.minesCount == this.tottalAreaCount;

			if (isWin)
			{
				result = GameStatus.Win;
			}

			return result;
		}

		private int VisibledCount()
		{
			int count = 0;

			for (int i = 0; i < this.maxX; i++)
			{
				for (int j = 0; j < this.maxY; j++)
				{
					if ((this[i, j] as VisibleField)!.IsVisible)
					{
						count++;
					}
				}
			}

			return count;
		}
	}
}
