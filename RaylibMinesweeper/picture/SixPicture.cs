namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class SixPicture : BasePicture
	{
		public SixPicture() : base(new Color(102, 51, 51, 255))
		{
			Color sixColor = new Color(0, 255, 0, 255);

			for (int coll = 14; coll <= 18; coll++)
			{
				this[3, coll] = sixColor;
				this[4, coll] = sixColor;
				this[5, coll] = sixColor;
			}

			for (int coll = 10; coll <= 17; coll++)
			{
				this[12, coll] = sixColor;
				this[13, coll] = sixColor;
			}

			for (int coll = 8; coll <= 11; coll++)
			{
				this[7, coll] = sixColor;
				this[8, coll] = sixColor;
			}

			for (int coll = 7; coll <= 9; coll++)
			{
				this[22, coll] = sixColor;
				this[23, coll] = sixColor;
			}

			for (int coll = 17; coll <= 19; coll++)
			{
				this[22, coll] = sixColor;
				this[23, coll] = sixColor;
			}

			for (int coll = 10; coll <= 13; coll++)
			{
				this[5, coll] = sixColor;
				this[6, coll] = sixColor;
			}

			for (int coll = 9; coll <= 17; coll++)
			{
				this[24, coll] = sixColor;
				this[25, coll] = sixColor;
			}

			for (int row = 13;  row <= 21; row++)
			{
				this[row, 5] = sixColor;
				this[row, 6] = sixColor;
				this[row, 7] = sixColor;
			}

			for (int row = 15; row <= 21; row++)
			{
				this[row, 18] = sixColor;
				this[row, 19] = sixColor;
				this[row, 20] = sixColor;
			}

			for (int row = 9; row <= 12; row++)
			{
				this[row, 7] = sixColor;
				this[row, 8] = sixColor;
			}

			this[4, 12] = sixColor;
			this[4, 13] = sixColor;
			
			this[6, 9] = sixColor;
			
			this[8, 7] = sixColor;
			
			this[9, 9] = sixColor;
			
			this[10, 6] = sixColor;
			this[10, 9] = sixColor;
			
			this[11, 6] = sixColor;
			this[11, 13] = sixColor;
			this[11, 14] = sixColor;
			
			this[12, 5] = sixColor;
			this[12, 6] = sixColor;
			
			this[13, 8] = sixColor;
			this[13, 9] = sixColor;
			this[13, 18] = sixColor;
			
			this[14, 8] = sixColor;
			this[14, 9] = sixColor;
			this[14, 10] = sixColor;
			this[14, 11] = sixColor;
			this[14, 15] = sixColor;
			this[14, 16] = sixColor;
			this[14, 17] = sixColor;
			this[14, 18] = sixColor;
			this[14, 19] = sixColor;
			
			this[15, 8] = sixColor;
			this[15, 9] = sixColor;
			this[15, 17] = sixColor;
			
			this[16, 8] = sixColor;
			this[16, 17] = sixColor;
			
			this[17, 8] = sixColor;
			this[17, 17] = sixColor;
			
			this[18, 8] = sixColor;
			this[18, 21] = sixColor;
			
			this[19, 8] = sixColor;
			this[19, 21] = sixColor;
			
			this[20, 8] = sixColor;
			
			this[21, 8] = sixColor;
			this[21, 17] = sixColor;
			
			this[22, 6] = sixColor;
			this[22, 20] = sixColor;
			
			this[23, 10] = sixColor;
			this[23, 16] = sixColor;
			
			this[24, 7] = sixColor;
			this[24, 8] = sixColor;
			this[24, 18] = sixColor;
			
			this[26, 10] = sixColor;
			this[26, 11] = sixColor;
			this[26, 12] = sixColor;
			this[26, 13] = sixColor;
			this[26, 14] = sixColor;
			this[26, 15] = sixColor;
			this[26, 16] = sixColor;
		}
	}
}
