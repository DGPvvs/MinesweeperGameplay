namespace RaylibMinesweeper.picture
{
	using Raylib_cs;
	using RaylibMinesweeper.Common;

	using static Raylib_cs.Raylib;

	public class StartPicture : BasePicture
	{
		public StartPicture() : base(PublicConstant.START_HEIGHT, PublicConstant.START_WIDTH)
		{
			Color baseColor = new Color(91, 155, 213, 255);
			this.SetBaseColor(baseColor);
			this.SetButtons();
		}

		private void SetButtons()
		{
			for (int x = PublicConstant.BUTTON_HEIGHT_START; x <= PublicConstant.BUTTON_HEIGHT_END; x++)
			{
				for (int y = PublicConstant.BUTTON_9X9_WIDTH_START; y <= PublicConstant.BUTTON_9X9_WIDTH_END; y++)
				{
					this[x, y] = new Color(255, 255, 255, 255);
				}

				for (int y = PublicConstant.BUTTON_16X16_WIDTH_START; y <= PublicConstant.BUTTON_16X16_WIDTH_END; y++)
				{
					this[x, y] = new Color(255, 255, 255, 255);
				}

				for (int y = PublicConstant.BUTTON_30X16_WIDTH_START; y <= PublicConstant.BUTTON_30X16_WIDTH_END; y++)
				{
					this[x, y] = new Color(255, 255, 255, 255);
				}
			}
		}

		public override void Draw(int x, int y)
		{
			for (int row = 0; row < this.picture.GetLength(0); row++)
			{
				for (int col = 0; col < this.picture.GetLength(1); col++)
				{
					DrawRectangle(col, row, 1, 1, this.picture[row, col]);
				}
			}
		}
	}
}
