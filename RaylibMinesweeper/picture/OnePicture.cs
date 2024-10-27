namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class OnePicture : BasePicture
	{		
		public OnePicture() : base(new Color(0, 156, 164, 255))
		{
			Color oneColor = new Color(255, 255, 51, 255);

			for (int row = 2; row < 25; row++)
			{
				this[row, 15] = oneColor;
				this[row, 16] = oneColor;
				this[row, 17] = oneColor;
			}

			this[2, 13] = oneColor;
			this[2, 14] = oneColor;

			this[3, 12] = oneColor;
			this[3, 13] = oneColor;
			this[3, 14] = oneColor;

			this[4, 10] = oneColor;
			this[4, 11] = oneColor;
			this[4, 12] = oneColor;
			this[4, 13] = oneColor;
			this[4, 14] = oneColor;

			this[5, 10] = oneColor;
			this[5, 11] = oneColor;
			this[5, 12] = oneColor;
			this[5, 13] = oneColor;
			this[5, 14] = oneColor;

			this[6, 10] = oneColor;
			this[6, 11] = oneColor;
			this[6, 12] = oneColor;

			this[7, 10] = oneColor;
		}
	}
}
