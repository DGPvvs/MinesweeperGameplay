namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class MarkPicture : BasePicture
	{
		public MarkPicture() : base(Color.DarkBlue)
		{
			Color flafBaseColor = new Color(0, 0, 0, 255);
			Color flafColor = new Color(255, 0, 0, 255);

			for (int row = 2; row <= 12; row++)
			{
				this[row, 14] = flafColor;
				this[row, 15] = flafColor;
				this[row, 16] = flafColor;
			}

			for (int row = 3; row <= 12; row++)
			{
				this[row, 12] = flafColor;
				this[row, 13] = flafColor;
			}

			for (int row = 13; row <= 17; row++)
			{
				this[row, 14] = flafBaseColor;
				this[row, 15] = flafBaseColor;
				this[row, 16] = flafBaseColor;
			}

			for (int coll = 4; coll <= 11; coll++)
			{
				this[5, coll] = flafColor;
				this[6, coll] = flafColor;
			}

			for (int coll = 5; coll <= 11; coll++)
			{
				this[7, coll] = flafColor;
				this[8, coll] = flafColor;
			}

			for (int coll = 8; coll <= 11; coll++)
			{
				this[9, coll] = flafColor;
				this[10, coll] = flafColor;
			}

			for (int coll = 7; coll <= 21; coll++)
			{
				this[20, coll] = flafBaseColor;
				this[21, coll] = flafBaseColor;
				this[22, coll] = flafBaseColor;
				this[23, coll] = flafBaseColor;
			}

			for (int coll = 10; coll <= 17; coll++)
			{
				this[18, coll] = flafBaseColor;
				this[19, coll] = flafBaseColor;
			}

			this[3, 11] = flafColor;

			this[4, 10] = flafColor;
			this[4, 11] = flafColor;

			this[10, 6] = flafColor;

			this[11, 9] = flafColor;
			this[11, 10] = flafColor;
			this[11, 11] = flafColor;

			this[12, 11] = flafColor;

			this[21, 6] = flafBaseColor;
			this[22, 6] = flafBaseColor;
			this[23, 6] = flafBaseColor;
			this[24, 6] = flafBaseColor;
			this[21, 22] = flafBaseColor;
			this[22, 22] = flafBaseColor;
			this[23, 22] = flafBaseColor;
			this[24, 22] = flafBaseColor;
			this[19, 9] = flafBaseColor;
			this[19, 18] = flafBaseColor;
		}
	}
}
