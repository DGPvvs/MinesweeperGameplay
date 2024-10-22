namespace MinesweeperGamePlay.AreaStructure.Contracts
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	public interface IArea
	{
		IField this[int x, int y] { get; }
		void InitArea(int percent);
		void SetAllVisible();
		GameStatus StateOfArea(int x, int y);
	}
}
