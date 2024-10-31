namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class FourPicture : BasePicture
	{
		public FourPicture() : base(new Color(165, 255, 22, 255))
		{
			Color fourColor = new Color(47, 0, 1, 255);

			for (int row = 2; row < 25; row++)
			{
				this[row, 16] = fourColor;
				this[row, 17] = fourColor;
				this[row, 18] = fourColor;
			}

			for (int coll = 6; coll < 21; coll++)
			{
				this[17, coll] = fourColor;
				this[18, coll] = fourColor;
			}

			this[3, 15] = fourColor;
			this[4, 15] = fourColor;
			this[5, 15] = fourColor;
			this[6, 15] = fourColor;

			this[3, 14] = fourColor;
			this[4, 14] = fourColor;
			this[5, 14] = fourColor;
			this[6, 14] = fourColor;
			this[7, 14] = fourColor;
			
			this[5, 13] = fourColor;
			this[6, 13] = fourColor;
			this[7, 13] = fourColor;
			this[8, 13] = fourColor;
			this[9, 13] = fourColor;

			this[7, 12] = fourColor;
			this[8, 12] = fourColor;
			this[9, 12] = fourColor;
			this[10, 12] = fourColor;
			this[11, 12] = fourColor;

			this[8, 11] = fourColor;
			this[9, 11] = fourColor;
			this[10, 11] = fourColor;
			this[11, 11] = fourColor;
			this[12, 11] = fourColor;

			this[10, 10] = fourColor;
			this[11, 10] = fourColor;
			this[12, 10] = fourColor;
			this[13, 10] = fourColor;
			this[14, 10] = fourColor;
			
			this[11, 9] = fourColor;
			this[12, 9] = fourColor;
			this[13, 9] = fourColor;
			this[14, 9] = fourColor;
			this[15, 9] = fourColor;
			
			this[13, 8] = fourColor;
			this[14, 8] = fourColor;
			this[15, 8] = fourColor;
			this[16, 8] = fourColor;
			
			this[14, 7] = fourColor;
			this[15, 7] = fourColor;
			this[16, 7] = fourColor;

			this[16, 6] = fourColor;
		}
	}
}
