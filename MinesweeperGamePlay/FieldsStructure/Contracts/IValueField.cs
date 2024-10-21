namespace MinesweeperGamePlay.FieldsStructure.Contracts
{
	using MinesweeperGamePlay.Enums;

	public interface IValueField : IField
	{
		public FieldSymbol Value { get; }
		public void SetSymbol(FieldSymbol symbol);
	}
}
