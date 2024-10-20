namespace MinesweeperGamePlay.FieldsStructure.Contracts
{
	interface IVisibleField : IValueField
	{
		public bool IsVisible { get; }
	}
}
