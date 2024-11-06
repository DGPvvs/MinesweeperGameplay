namespace MinesweeperGamePlay.TransferObject.Contracts
{
	using MinesweeperGamePlay.Enums;

	public interface ITransfer
	{
		int XPosition { get; }
		int YPosition { get; }
		FieldSymbol Action { get; }
	}
}
