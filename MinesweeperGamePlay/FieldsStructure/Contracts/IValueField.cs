namespace MinesweeperGamePlay.FieldsStructure.Contracts
{
	using MinesweeperGamePlay.Enums;

	interface IValueField : IField
	{
		public FieldSymbol Value { get; }
		public void SetSymbol(FieldSymbol symbol);
	}
}
