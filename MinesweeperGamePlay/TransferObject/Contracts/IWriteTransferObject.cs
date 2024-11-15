namespace MinesweeperGamePlay.TransferObject.Contracts
{
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Enums;

	public interface IWriteTransferObject
	{
		public GameStatus Status { get; }
		public IArea Area { get; }
		public string Text { get; }
	}
}
