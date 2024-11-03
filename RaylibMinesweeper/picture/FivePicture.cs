namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class FivePicture : BasePicture
	{
		public FivePicture() : base(new Color(204, 204, 255, 255))
		{
			Color fiveColor = new Color(255, 0, 0, 255);

			for (int coll = 11; coll <= 22; coll++)
			{
				this[2, coll] = fiveColor;
				this[3, coll] = fiveColor;
				this[4, coll] = fiveColor;
			}

			for (int coll = 13; coll <= 18; coll++)
			{
				this[11, coll] = fiveColor;
				this[12, coll] = fiveColor;
				this[13, coll] = fiveColor;
			}

			for (int coll = 9; coll <= 18; coll++)
			{
				this[25, coll] = fiveColor;
			}

			for (int coll = 8; coll <= 19; coll++)
			{
				this[23, coll] = fiveColor;
				this[24, coll] = fiveColor;
			}

			for (int row = 6; row <=13; row++)
			{
				this[row, 10] = fiveColor;
				this[row, 11] = fiveColor;
				this[row, 12] = fiveColor;
			}

			for (int row = 15; row <= 21; row++)
			{
				this[row, 20] = fiveColor;
				this[row, 21] = fiveColor;
				this[row, 22] = fiveColor;
			}

			for (int row = 16; row <= 22; row++)
			{
				this[row, 19] = fiveColor;
			}

			this[5, 10] = fiveColor;
			this[5, 11] = fiveColor;
			this[5, 12] = fiveColor;
			this[5, 13] = fiveColor;

			this[6, 13] = fiveColor;
			this[8, 13] = fiveColor;
			
			this[12, 19] = fiveColor;
			this[12, 20] = fiveColor;
			
			this[13, 19] = fiveColor;
			this[13, 20] = fiveColor;
			this[13, 21] = fiveColor;
			
			this[14, 17] = fiveColor;
			this[14, 18] = fiveColor;
			this[14, 19] = fiveColor;
			this[14, 20] = fiveColor;
			this[14, 21] = fiveColor;
			
			this[15, 18] = fiveColor;
			this[15, 19] = fiveColor;
			
			this[21, 18] = fiveColor;
			
			this[22, 9] = fiveColor;
			this[22, 10] = fiveColor;
			this[22, 17] = fiveColor;
			this[22, 18] = fiveColor;
			this[22, 20] = fiveColor;
			this[22, 21] = fiveColor;
			
			this[23, 20] = fiveColor;
		}
	}
}
