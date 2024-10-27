namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class TwoPicture : BasePicture
	{
		public TwoPicture() : base(new Color(156, 156, 0, 255))
		{
			Color twoColor = new Color(144, 0, 129, 255);

			for (int col = 9; col < 23; col++)
			{
				this[23, col] = twoColor;
				this[24, col] = twoColor;
				this[25, col] = twoColor;
			}

			this[24, 8] = twoColor;
			this[25, 8] = twoColor;

			this[22, 10] = twoColor;
			this[22, 11] = twoColor;
			this[22, 12] = twoColor;
			this[22, 13] = twoColor;

			this[21, 11] = twoColor;
			this[21, 12] = twoColor;
			this[21, 13] = twoColor;
			this[21, 14] = twoColor;

			this[20, 12] = twoColor;
			this[20, 13] = twoColor;
			this[20, 14] = twoColor;
			this[20, 15] = twoColor;

			this[19, 13] = twoColor;
			this[19, 14] = twoColor;
			this[19, 15] = twoColor;
			this[19, 16] = twoColor;

			this[18, 14] = twoColor;
			this[18, 15] = twoColor;
			this[18, 16] = twoColor;
			this[18, 17] = twoColor;

			this[17, 15] = twoColor;
			this[17, 16] = twoColor;
			this[17, 17] = twoColor;
			this[17, 18] = twoColor;

			this[16, 16] = twoColor;
			this[16, 17] = twoColor;
			this[16, 18] = twoColor;
			this[16, 19] = twoColor;

			this[15, 17] = twoColor;
			this[15, 18] = twoColor;
			this[15, 19] = twoColor;
			this[15, 20] = twoColor;

			this[14, 17] = twoColor;
			this[14, 18] = twoColor;
			this[14, 19] = twoColor;
			this[14, 20] = twoColor;

			this[13, 18] = twoColor;
			this[13, 19] = twoColor;
			this[13, 20] = twoColor;
			this[13, 21] = twoColor;

			this[12, 19] = twoColor;
			this[12, 20] = twoColor;
			this[12, 21] = twoColor;

			this[11, 19] = twoColor;
			this[11, 20] = twoColor;
			this[11, 21] = twoColor;
			this[11, 22] = twoColor;

			this[10, 20] = twoColor;
			this[10, 21] = twoColor;
			this[10, 22] = twoColor;

			this[9, 20] = twoColor;
			this[9, 21] = twoColor;
			this[9, 22] = twoColor;

			this[8, 20] = twoColor;
			this[8, 21] = twoColor;
			this[8, 22] = twoColor;

			this[7, 20] = twoColor;
			this[7, 21] = twoColor;
			this[7, 22] = twoColor;

			this[6, 10] = twoColor;
			this[6, 19] = twoColor;
			this[6, 20] = twoColor;
			this[6, 21] = twoColor;
			this[6, 22] = twoColor;

			this[5, 9] = twoColor;
			this[5, 10] = twoColor;
			this[5, 11] = twoColor;
			this[5, 18] = twoColor;
			this[5, 19] = twoColor;
			this[5, 20] = twoColor;
			this[5, 21] = twoColor;

			this[4, 9] = twoColor;
			this[4, 10] = twoColor;
			this[4, 11] = twoColor;
			this[4, 12] = twoColor;
			this[4, 13] = twoColor;
			this[4, 14] = twoColor;
			this[4, 15] = twoColor;
			this[4, 16] = twoColor;
			this[4, 17] = twoColor;
			this[4, 18] = twoColor;
			this[4, 19] = twoColor;
			this[4, 20] = twoColor;

			this[3, 10] = twoColor;
			this[3, 11] = twoColor;
			this[3, 12] = twoColor;
			this[3, 13] = twoColor;
			this[3, 14] = twoColor;
			this[3, 15] = twoColor;
			this[3, 16] = twoColor;
			this[3, 17] = twoColor;
			this[3, 18] = twoColor;
			this[3, 19] = twoColor;

			this[2, 12] = twoColor;
			this[2, 13] = twoColor;
			this[2, 14] = twoColor;
			this[2, 15] = twoColor;
			this[2, 16] = twoColor;
			this[2, 17] = twoColor;
			this[2, 18] = twoColor;
		}
	}
}
