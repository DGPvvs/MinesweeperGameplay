namespace MinesweeperGamePlay.FieldsStructure
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	public class VisibleField : ValueField, IVisibleField
	{
		bool isVisible;

		public VisibleField(int x, int y, FieldSymbol val) : base(x, y, val)
		{
			this.IsVisible = false;
		}

		public bool IsVisible
		{
			get => this.isVisible;
			private set => this.isVisible = value;
		}

		public void SetVisible(bool visible)
		{
			this.IsVisible = visible;
		}

		public override string ToString() => this.IsVisible ? base.ToString() : ((char)FieldSymbol.Noting).ToString();
	}
}
