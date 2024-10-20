namespace MinesweeperGamePlay.AreaStructure.Contracts
{
	using MinesweeperGamePlay.FieldsStructure.Contracts;

	interface IArea
	{
		IField this[int x, int y] { get; }
		void InitArea(int mineNum);
	}
}
