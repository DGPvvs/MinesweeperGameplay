namespace MinesweeperGamePlay.AreaStructure.Contracts
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure.Contracts;
	using MinesweeperGamePlay.TransferObject.Contracts;

	public interface IArea
	{
		public int MaxX { get; }
		public int MaxY { get; }
		public IField this[int x, int y] { get; }
		void InitArea(IField field, int percent);
		public void SetAllVisible();
		GameStatus StateOfArea(ITransfer transfer);
	}
}
