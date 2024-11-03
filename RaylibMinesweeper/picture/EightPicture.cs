namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class EightPicture : BasePicture
	{
		public EightPicture() : base(new Color(255, 255, 0, 255))
		{
			Color eightColor = new Color(0, 0, 0, 255);

			for (int coll = 11; coll <= 17; coll++)
			{
				this[2, coll] = eightColor;
				this[3, coll] = eightColor;
				this[12, coll] = eightColor;
				this[13, coll] = eightColor;
				this[14, coll] = eightColor;
				this[24, coll] = eightColor;
				this[25, coll] = eightColor;
			}

			this[12, 10] = eightColor;
			this[13, 10] = eightColor;
			this[14, 10] = eightColor;
			this[24, 10] = eightColor;
			this[25, 10] = eightColor;

			for (int row = 5; row <= 10; row++)
			{
				this[row, 7] = eightColor;
				this[row, 8] = eightColor;
				this[row, 9] = eightColor;
				this[row, 18] = eightColor;
				this[row, 19] = eightColor;
				this[row, 20] = eightColor;
			}

			for (int row = 16; row <= 23; row++)
			{
				this[row, 7] = eightColor;
				this[row, 8] = eightColor;
				this[row, 9] = eightColor;
				this[row, 19] = eightColor;				
				this[row, 20] = eightColor;
			}

			this[3, 9] = eightColor;
			this[3, 10] = eightColor;
			this[3, 18] = eightColor;

			this[4, 8] = eightColor;
			this[4, 9] = eightColor;
			this[4, 10] = eightColor;
			this[4, 11] = eightColor;
			this[4, 12] = eightColor;
			this[4, 16] = eightColor;
			this[4, 17] = eightColor;
			this[4, 18] = eightColor;
			this[4, 19] = eightColor;

			this[5, 10] = eightColor;
			this[5, 17] = eightColor;

			this[6, 10] = eightColor;
			this[6, 17] = eightColor;

			this[10, 10] = eightColor;
			this[10, 17] = eightColor;
			
			this[11, 8] = eightColor;
			this[11, 9] = eightColor;
			this[11, 10] = eightColor;
			this[11, 11] = eightColor;
			this[11, 16] = eightColor;
			this[11, 17] = eightColor;
			this[11, 18] = eightColor;
			this[11, 19] = eightColor;
			
			this[12, 9] = eightColor;
			this[12, 18] = eightColor;
			
			this[14, 9] = eightColor;
			this[14, 18] = eightColor;
			this[14, 19] = eightColor;
			
			this[15, 8] = eightColor;
			this[15, 9] = eightColor;
			this[15, 10] = eightColor;
			this[15, 11] = eightColor;
			this[15, 16] = eightColor;
			this[15, 17] = eightColor;
			this[15, 18] = eightColor;
			this[15, 19] = eightColor;
			this[15, 20] = eightColor;
			
			this[16, 18] = eightColor;
			
			this[17, 6] = eightColor;
			this[17, 18] = eightColor;
			this[17, 21] = eightColor;
			
			this[18, 6] = eightColor;
			this[18, 21] = eightColor;
			
			this[19, 6] = eightColor;
			this[19, 21] = eightColor;
			
			this[20, 6] = eightColor;
			this[20, 21] = eightColor;
			
			this[21, 6] = eightColor;
			this[21, 18] = eightColor;
			this[21, 21] = eightColor;
			
			this[22, 6] = eightColor;
			this[22, 10] = eightColor;
			this[22, 17] = eightColor;
			this[22, 18] = eightColor;
			
			this[23, 10] = eightColor;
			this[23, 11] = eightColor;
			this[23, 12] = eightColor;
			this[23, 15] = eightColor;
			this[23, 16] = eightColor;
			this[23, 17] = eightColor;
			this[23, 18] = eightColor;
			
			this[24, 8] = eightColor;
			this[24, 9] = eightColor;
			this[24, 18] = eightColor;
			this[24, 19] = eightColor;
		}
	}
}
