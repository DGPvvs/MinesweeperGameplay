namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class SevenPicture : BasePicture
	{
		public SevenPicture() : base(new Color(0, 255, 0, 255))
		{
			Color sevenColor = new Color(0, 51, 153, 255);

			for (int coll = 9;  coll <= 23; coll++)
			{
				this[2, coll] = sevenColor;
				this[3, coll] = sevenColor;
				this[4, coll] = sevenColor;
			}

			this[5, 20] = sevenColor;
			this[5, 21] = sevenColor;
			this[5, 22] = sevenColor;

			this[6, 19] = sevenColor;
			this[6, 20] = sevenColor;
			this[6, 21] = sevenColor;
			this[6, 22] = sevenColor;

			this[7, 19] = sevenColor;
			this[7, 20] = sevenColor;
			this[7, 21] = sevenColor;
			
			this[8, 18] = sevenColor;
			this[8, 19] = sevenColor;
			this[8, 20] = sevenColor;
			this[8, 21] = sevenColor;
			
			this[9, 18] = sevenColor;
			this[9, 19] = sevenColor;
			this[9, 20] = sevenColor;
			
			this[10, 17] = sevenColor;
			this[10, 18] = sevenColor;
			this[10, 19] = sevenColor;
			this[10, 20] = sevenColor;
			
			this[11, 17] = sevenColor;
			this[11, 18] = sevenColor;
			this[11, 19] = sevenColor;
			
			this[12, 16] = sevenColor;
			this[12, 17] = sevenColor;
			this[12, 18] = sevenColor;
			this[12, 19] = sevenColor;
			
			this[13, 16] = sevenColor;
			this[13, 17] = sevenColor;
			this[13, 18] = sevenColor;
			this[13, 19] = sevenColor;
			
			this[14, 15] = sevenColor;
			this[14, 16] = sevenColor;
			this[14, 17] = sevenColor;
			this[14, 18] = sevenColor;
			
			this[15, 15] = sevenColor;
			this[15, 16] = sevenColor;
			this[15, 17] = sevenColor;
			this[15, 18] = sevenColor;
			
			this[16, 15] = sevenColor;
			this[16, 16] = sevenColor;
			this[16, 17] = sevenColor;
			
			this[17, 14] = sevenColor;
			this[17, 15] = sevenColor;
			this[17, 16] = sevenColor;
			this[17, 17] = sevenColor;
			
			this[18, 14] = sevenColor;
			this[18, 15] = sevenColor;
			this[18, 16] = sevenColor;
			
			this[19, 13] = sevenColor;
			this[19, 14] = sevenColor;
			this[19, 15] = sevenColor;
			this[19, 16] = sevenColor;
			
			this[20, 13] = sevenColor;
			this[20, 14] = sevenColor;
			this[20, 15] = sevenColor;
			
			this[21, 12] = sevenColor;
			this[21, 13] = sevenColor;
			this[21, 14] = sevenColor;
			this[21, 15] = sevenColor;
			
			this[22, 12] = sevenColor;
			this[22, 13] = sevenColor;
			this[22, 14] = sevenColor;
			
			this[23, 11] = sevenColor;
			this[23, 12] = sevenColor;
			this[23, 13] = sevenColor;
			this[23, 14] = sevenColor;
			
			this[24, 11] = sevenColor;
			this[24, 12] = sevenColor;
			this[24, 13] = sevenColor;
			this[24, 14] = sevenColor;
			
			this[25, 10] = sevenColor;
			this[25, 11] = sevenColor;
			this[25, 12] = sevenColor;
			this[25, 13] = sevenColor;
		}
	}
}
