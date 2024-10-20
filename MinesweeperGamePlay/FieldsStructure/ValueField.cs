namespace MinesweeperGamePlay.FieldsStructure
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	public class ValueField : Field, IValueField
	{
		private FieldSymbol val;

		public ValueField(int x, int y, FieldSymbol val) : base(x, y)
		{
			this.Value = val;
		}

		public FieldSymbol Value
		{
			get => this.val;
			private set => this.val = value;
		}

		public void SetSymbol(FieldSymbol symbol)
		{
			this.Value = symbol;
		}

		public override string ToString() => ((char)this.Value).ToString();
	}
}
