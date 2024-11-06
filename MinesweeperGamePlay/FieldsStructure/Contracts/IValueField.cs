namespace MinesweeperGamePlay.FieldsStructure.Contracts
{
	using MinesweeperGamePlay.Enums;

	public interface IValueField : IMarkedField
	{
		public FieldSymbol Value { get; }
		public void SetSymbol(FieldSymbol symbol);
	}
}
