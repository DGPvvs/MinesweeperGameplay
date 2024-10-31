namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class SixPicture : BasePicture
	{
		public SixPicture() : base(new Color(102, 51, 51, 255))
		{
			Color sixColor = new Color(0, 255, 0, 255);

			this[3, 15] = sixColor;
			this[4, 15] = sixColor;
			this[5, 15] = sixColor;
			this[6, 15] = sixColor;
		}
	}
}
