namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class EightPicture : BasePicture
	{
		public EightPicture() : base(new Color(255, 255, 0, 255))
		{
			Color eightColor = new Color(0, 0, 0, 255);

			this[3, 15] = eightColor;
			this[4, 15] = eightColor;
			this[5, 15] = eightColor;
			this[6, 15] = eightColor;
		}


	}
}
