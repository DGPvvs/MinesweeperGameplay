namespace MinesweeperGamePlay.TransferObject
{
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.TransferObject.Contracts;

	public class WriteTransferObject : IWriteTransferObject
	{
		private readonly GameStatus status;
		private readonly IArea area;
		private readonly string text;

		public WriteTransferObject(GameStatus status, IArea area, string text)
		{
			this.status = status;
			this.area = area;
			this.text = text;
		}

		public GameStatus Status => this.status;

		public IArea Area => this.area;

		public string Text => this.text;
	}
}
