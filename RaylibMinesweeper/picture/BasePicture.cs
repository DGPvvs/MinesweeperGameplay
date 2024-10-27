namespace RaylibMinesweeper.picture
{
	using Raylib_cs;
	using RaylibMinesweeper.Common;
	using static Raylib_cs.Raylib;

	public abstract class BasePicture
	{
		protected Color[,] picture;

        public BasePicture(Color baseColor)
        {
            this.picture = new Color[PublicConstant.CELL_SIZE - 1, PublicConstant.CELL_SIZE - 1];

            for (int row = 0; row < this.picture.GetLength(0); row++)
            {
                for (int col = 0; col < this.picture.GetLength(1); col++)
                {
                    this.picture[row, col] = baseColor;
                }
            }
        }

        public Color[,] Picture
        {
            get => this.picture;
        }

        protected Color this[int row, int col]
        {
            set
            {
                this.picture[row, col] = value;
            }
        }

        public void Draw(int x, int y)
        {
            for(int row = 0;row < this.picture.GetLength(0);row++)
            {
                for (int col = 0; col < this.picture.GetLength(1); col++)
                {
					DrawRectangle((y * PublicConstant.CELL_SIZE) + col, (x * PublicConstant.CELL_SIZE) + row, 1, 1, this.picture[row, col]);
				}
            }
        }
    }
}
