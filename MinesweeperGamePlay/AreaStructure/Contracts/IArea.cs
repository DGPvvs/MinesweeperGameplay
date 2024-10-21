namespace MinesweeperGamePlay.AreaStructure.Contracts
{
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	public interface IArea
	{
		public IField this[int x, int y] { get; }
		public void InitArea(int mineNum);
		public void SetAllVisible();
	}
}
