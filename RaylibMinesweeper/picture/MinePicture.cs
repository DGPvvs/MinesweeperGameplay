namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class MinePicture : BasePicture
	{
		public MinePicture() : base(Color.White)
		{
			Color oneColor = new Color(255, 255, 51, 255);

			this[1, 13] = new Color(175, 175, 175, 255);
			this[1, 14] = new Color(152, 152, 152, 255);
			this[1, 15] = new Color(170, 170, 170, 255);

			this[2, 12] = new Color(105, 105, 105, 255);
			this[2, 13] = new Color(0, 0, 0, 255);
			this[2, 14] = new Color(24, 24, 24, 255);
			this[2, 15] = new Color(0, 0, 0, 255);
			this[2, 16] = new Color(86, 86, 86, 255);
		}
	}
}
