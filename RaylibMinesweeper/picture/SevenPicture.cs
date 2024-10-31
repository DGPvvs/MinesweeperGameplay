namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class SevenPicture : BasePicture
	{
		public SevenPicture() : base(new Color(0, 255, 0, 255))
		{
			Color sevenColor = new Color(0, 51, 153, 255);

			this[3, 15] = sevenColor;
			this[4, 15] = sevenColor;
			this[5, 15] = sevenColor;
			this[6, 15] = sevenColor;
		}
	}
}
