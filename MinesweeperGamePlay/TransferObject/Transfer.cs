namespace MinesweeperGamePlay.TransferObject
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.TransferObject.Contracts;

	public class Transfer : ITransfer
	{
		private readonly int xPosition;
		private readonly int yPosition;
		private readonly FieldSymbol action;

		public Transfer(int x, int y, FieldSymbol action)
		{
			this.xPosition = x;
			this.yPosition = y;
			this.action = action;
		}

		public int XPosition => this.xPosition;

		public int YPosition => this.yPosition;

		public FieldSymbol Action => this.action;
	}
}
