namespace MinesweeperGamePlay.IO.Contracts
{
	using MinesweeperGamePlay.TransferObject.Contracts;

	public interface IReader
	{
		public ITransfer ReadInput();
		public void Free();
	}
}
