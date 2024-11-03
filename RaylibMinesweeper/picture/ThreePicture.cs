namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class ThreePicture : BasePicture
	{
		public ThreePicture() : base(new Color(255, 190, 195, 255))
		{
			Color threeColor = new Color(3, 0, 117, 255);
			for (int coll = 11; coll <= 18; coll++)
			{
				this[2, coll] = threeColor;
				this[3, coll] = threeColor;
				this[4, coll] = threeColor;
			}

			for (int row = 4; row <= 10; row++)
			{
				this[row, 19] = threeColor;
				this[row, 20] = threeColor;
				this[row, 21] = threeColor;
			}	

			for (int row = 16; row <= 21; row++)
			{
				this[row, 20] = threeColor;
				this[row, 21] = threeColor;
				this[row, 22] = threeColor;
			}

			for (int coll = 12; coll <= 19; coll++)
			{
				this[12, coll] = threeColor;
				this[13, coll] = threeColor;
				this[14, coll] = threeColor;
			}

			for (int coll = 10; coll <= 18; coll++)
			{
				this[23, coll] = threeColor;
				this[24, coll] = threeColor;
				this[25, coll] = threeColor;
			}

			this[3, 9] = threeColor;
			this[3, 10] = threeColor;
			this[4, 9] = threeColor;
			this[4, 10] = threeColor;
			this[5, 10] = threeColor;
			this[4, 10] = threeColor;
			this[3, 19] = threeColor;
			this[3, 20] = threeColor;
			this[6, 18] = threeColor;
			this[7, 18] = threeColor;
			this[9, 18] = threeColor;
			this[10, 18] = threeColor;
			this[11, 16] = threeColor;
			this[11, 17] = threeColor;
			this[11, 18] = threeColor;
			this[11, 19] = threeColor;
			this[11, 20] = threeColor;
			this[14, 20] = threeColor;
			this[15, 17] = threeColor;
			this[15, 18] = threeColor;
			this[15, 19] = threeColor;
			this[15, 20] = threeColor;
			this[15, 21] = threeColor;
			this[16, 18] = threeColor;
			this[16, 19] = threeColor;
			this[17, 19] = threeColor;
			this[20, 19] = threeColor;
			this[21, 19] = threeColor;
			this[22, 9] = threeColor;
			this[22, 10] = threeColor;
			this[23, 9] = threeColor;
			this[24, 9] = threeColor;
			this[22, 18] = threeColor;
			this[22, 19] = threeColor;
			this[22, 20] = threeColor;
			this[22, 21] = threeColor;
			this[23, 19] = threeColor;
			this[24, 19] = threeColor;
		}
	}
}