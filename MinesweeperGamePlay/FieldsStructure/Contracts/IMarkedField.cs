namespace MinesweeperGamePlay.FieldsStructure.Contracts
{
	public interface IMarkedField : IField
	{
		public bool IsMarked { get; }
		public void ToggleMark();
	}
}
