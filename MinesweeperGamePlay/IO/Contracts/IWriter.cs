namespace MinesweeperGamePlay.IO.Contracts
{
	using MinesweeperGamePlay.TransferObject.Contracts;

	public interface IWriter : IReader
	{
		public void Clear();
		public void WriteOutput(IWriteTransferObject wTO);
		public void WriteLineOutput(IWriteTransferObject wTO);
	}
}
