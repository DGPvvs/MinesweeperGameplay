namespace MinesweeperGamePlay.FieldsStructure
{
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	public class Field : IField
	{
		private int x;
		private int y;

		public Field(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public int X
		{
			get => this.x;
			private set => this.x = value;
		}

		public int Y
		{
			get => this.y;
			private set => this.y = value;
		}

		public override bool Equals(object? obj)
		{
			if (obj == null)
			{
				return false;
			}

			Field f = obj as Field;

			return ((f?.X == this.X) && (f?.Y == this.Y));
		}

		public override int GetHashCode()
		{
			int hash = 17;
			hash = hash * 23 + this.X;
			return hash * 23 + this.Y;
		}
	}
}
