namespace MinesweeperGamePlay.FieldsStructure
{
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	public class MarkedField : Field, IMarkedField
	{
		private bool isMarked;

		public MarkedField(int x, int y) : base(x, y)
		{
			this.IsMarked = false;
		}

		public bool IsMarked
		{
			get => this.isMarked;
			private set => this.isMarked = value;
		}

		public void ToggleMark()
		{
			this.IsMarked = !this.IsMarked;
		}
	}
}
