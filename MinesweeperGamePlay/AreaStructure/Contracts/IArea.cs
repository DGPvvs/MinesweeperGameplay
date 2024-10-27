namespace MinesweeperGamePlay.AreaStructure.Contracts
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	public interface IArea
	{
		public int MaxX { get; }
		public int MaxY { get; }
		public IField this[int x, int y] { get; }
		public void InitArea(int percent);
		public void SetAllVisible();
		public GameStatus StateOfArea(int x, int y);
	}
}
