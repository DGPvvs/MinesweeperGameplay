namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class ThreePicture : BasePicture
	{
		public ThreePicture() : base(new Color(255, 190, 195, 255))
		{
			for (int coll = 11; coll <= 18; coll++)
			{
				this[2, coll] = new Color(3, 0, 117, 255);
				this[3, coll] = new Color(3, 0, 117, 255);
				this[4, coll] = new Color(3, 0, 117, 255);
			}

			for (int row = 4; row <= 10; row++)
			{
				this[row, 19] = new Color(3, 0, 117, 255);
				this[row, 20] = new Color(3, 0, 117, 255);
				this[row, 21] = new Color(3, 0, 117, 255);
			}

			for (int row = 16; row <= 21; row++)
			{
				this[row, 20] = new Color(3, 0, 117, 255);
				this[row, 21] = new Color(3, 0, 117, 255);
				this[row, 22] = new Color(3, 0, 117, 255);
			}

			for (int coll = 12; coll <= 19; coll++)
			{
				this[12, coll] = new Color(3, 0, 117, 255);
				this[13, coll] = new Color(3, 0, 117, 255);
				this[14, coll] = new Color(3, 0, 117, 255);
			}

			for (int coll = 10; coll <= 18; coll++)
			{
				this[23, coll] = new Color(3, 0, 117, 255);
				this[24, coll] = new Color(3, 0, 117, 255);
				this[25, coll] = new Color(3, 0, 117, 255);
			}

			this[3, 9] = new Color(3, 0, 117, 255);
			this[3, 10] = new Color(3, 0, 117, 255);
			this[4, 9] = new Color(3, 0, 117, 255);
			this[4, 10] = new Color(3, 0, 117, 255);
			this[5, 10] = new Color(3, 0, 117, 255);
			this[4, 10] = new Color(3, 0, 117, 255);
			this[3, 19] = new Color(3, 0, 117, 255);
			this[3, 20] = new Color(3, 0, 117, 255);
			this[6, 18] = new Color(3, 0, 117, 255);
			this[7, 18] = new Color(3, 0, 117, 255);
			this[9, 18] = new Color(3, 0, 117, 255);
			this[10, 18] = new Color(3, 0, 117, 255);
			this[11, 16] = new Color(3, 0, 117, 255);
			this[11, 17] = new Color(3, 0, 117, 255);
			this[11, 18] = new Color(3, 0, 117, 255);
			this[11, 19] = new Color(3, 0, 117, 255);
			this[11, 20] = new Color(3, 0, 117, 255);
			this[14, 20] = new Color(3, 0, 117, 255);
			this[15, 17] = new Color(3, 0, 117, 255);
			this[15, 18] = new Color(3, 0, 117, 255);
			this[15, 19] = new Color(3, 0, 117, 255);
			this[15, 20] = new Color(3, 0, 117, 255);
			this[15, 21] = new Color(3, 0, 117, 255);
			this[16, 18] = new Color(3, 0, 117, 255);
			this[16, 19] = new Color(3, 0, 117, 255);
			this[17, 19] = new Color(3, 0, 117, 255);
			this[20, 19] = new Color(3, 0, 117, 255);
			this[21, 19] = new Color(3, 0, 117, 255);
			this[22, 9] = new Color(3, 0, 117, 255);
			this[22, 10] = new Color(3, 0, 117, 255);
			this[23, 9] = new Color(3, 0, 117, 255);
			this[24, 9] = new Color(3, 0, 117, 255);
			this[22, 18] = new Color(3, 0, 117, 255);
			this[22, 19] = new Color(3, 0, 117, 255);
			this[22, 20] = new Color(3, 0, 117, 255);
			this[22, 21] = new Color(3, 0, 117, 255);
			this[23, 19] = new Color(3, 0, 117, 255);
			this[24, 19] = new Color(3, 0, 117, 255);
		}
	}
}
