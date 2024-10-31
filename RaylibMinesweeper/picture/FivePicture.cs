namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class FivePicture : BasePicture
	{
		public FivePicture() : base(new Color(204, 204, 255, 255))
		{
			Color fiveColor = new Color(255, 0, 0, 255);

			this[3, 15] = fiveColor;
			this[4, 15] = fiveColor;
			this[5, 15] = fiveColor;
			this[6, 15] = fiveColor;
		}
	}
}
