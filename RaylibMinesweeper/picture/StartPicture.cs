namespace RaylibMinesweeper.picture
{
	using Raylib_cs;
	using RaylibMinesweeper.Common;
	using System;
	using static Raylib_cs.Raylib;

	public class StartPicture : BasePicture
	{
		private Color[,] picture_0;
		private Color[,] picture_1;
		private Color[,] picture_2;
		private Color[,] picture_6;
		private Color[,] picture_9;
		private Color[,] picture_x;

		public StartPicture() : base(PublicConstant.START_HEIGHT, PublicConstant.START_WIDTH)
		{
			Color baseColor = new Color(91, 155, 213, 255);

			this.picture_0 = new Color[64, 51];
			this.picture_1 = new Color[62, 36];
			this.picture_6 = new Color[64, 51];
			this.picture_9 = new Color[64, 51];
			this.SetPicture_9();
			this.SetPicture_6();
			this.SetPicture_0();
			this.SetPicture_1();

			this.SetBaseColor(baseColor);
			this.SetButtons();
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

		private void SetPicture_1()
		{
			for (int r = 0; r < this.picture_1.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_1.GetLength(1); c++)
				{
					this.picture_1[r, c] = Color.White;
				}
			}

			for (int c = 21; c <= 35; c++)
			{
				this.picture_1[0, c] = Color.Black;
			}

			for (int c = 20; c <= 35; c++)
			{
				this.picture_1[1, c] = Color.Black;
				this.picture_1[2, c] = Color.Black;
			}

			for (int c = 19; c <= 35; c++)
			{
				this.picture_1[3, c] = Color.Black;
			}

			this.picture_1[6, 17] = Color.Black;
			
			this.picture_1[7, 16] = Color.Black;
			this.picture_1[7, 17] = Color.Black;
			
			this.picture_1[9, 14] = Color.Black;
			
			this.picture_1[11, 11] = Color.Black;
			
			this.picture_1[15, 2] = Color.Black;
			this.picture_1[15, 3] = Color.Black;
			this.picture_1[15, 4] = Color.Black;
			
			this.picture_1[23, 13] = Color.Black;
			this.picture_1[23, 14] = Color.Black;
			this.picture_1[23, 15] = Color.Black;
			
			this.picture_1[24, 13] = Color.Black;
			this.picture_1[24, 14] = Color.Black;
			
			this.picture_1[26, 7] = Color.Black;
			this.picture_1[26, 8] = Color.Black;
			this.picture_1[26, 9] = Color.Black;
			this.picture_1[26, 10] = Color.Black;
			this.picture_1[26, 11] = Color.Black;
			
			this.picture_1[27, 7] = Color.Black;
			this.picture_1[27, 8] = Color.Black;
			this.picture_1[27, 9] = Color.Black;
			
			this.picture_1[29, 0] = Color.Black;
			this.picture_1[29, 1] = Color.Black;
			this.picture_1[29, 2] = Color.Black;
			this.picture_1[29, 3] = Color.Black;
			this.picture_1[29, 4] = Color.Black;
			
			this.picture_1[30, 0] = Color.Black;
			this.picture_1[30, 1] = Color.Black;

			for (int c = 18; c <= 35; c++)
			{
				for(int r = 4; r <= 61; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 0; c <= 12; c++)
			{
				for (int r = 23; r <= 25; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 0; c <= 6; c++)
			{
				for (int r = 26; r <= 28; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 7; c <= 8; c++)
			{
				for (int r = 13; r <= 15; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 5; c <= 6; c++)
			{
				for (int r = 14; r <= 15; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 0; c <= 17; c++)
			{
				for (int r = 16; r <= 22; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 12; c <= 17; c++)
			{
				for (int r = 10; r <= 15; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 9; c <= 11; c++)
			{
				for (int r = 12; r <= 15; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}

			for (int c = 15; c <= 17; c++)
			{
				for (int r = 8; r <= 9; r++)
				{
					this.picture_1[r, c] = Color.Black;
				}
			}
		}

		private void SetPicture_0()
		{
			for (int r = 0; r < this.picture_0.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_0.GetLength(1); c++)
				{
					this.picture_0[r, c] = Color.White;
				}
			}

			for (int c = 18; c <= 33; c++)
			{
				this.picture_0[0, c] = Color.Black;
			}

			for (int c = 14; c <= 36; c++)
			{
				this.picture_0[1, c] = Color.Black;
			}

			for (int c = 12; c <= 38; c++)
			{
				this.picture_0[2, c] = Color.Black;
			}
		}

		private void SetPicture_6()
		{
			for(int r = 0; r < this.picture_9.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_9.GetLength(1); c++)
				{
					this.picture_6[picture_6.GetLength(0) - 1 - r, picture_6.GetLength(1) - 1 - c] = this.picture_9[r, c];
				}
			}
		}

		private void SetPicture_9()
		{
			for (int r = 0; r < this.picture_9.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_9.GetLength(1); c++)
				{
					this.picture_9[r, c] = Color.White;
				}
			}

			for (int c = 16; c <= 31; c++)
			{
				this.picture_9[0, c] = Color.Black;
			}

			for (int c = 13; c <= 34; c++)
			{
				this.picture_9[1, c] = Color.Black;
			}

			for (int c = 11; c <= 37; c++)
			{
				this.picture_9[2, c] = Color.Black;
			}

			for (int c = 9; c <= 39; c++)
			{
				this.picture_9[3, c] = Color.Black;
			}

			for (int c = 8; c <= 40; c++)
			{
				this.picture_9[4, c] = Color.Black;
			}

			for (int c = 7; c <= 41; c++)
			{
				this.picture_9[5, c] = Color.Black;
			}

			for (int c = 6; c <= 42; c++)
			{
				this.picture_9[6, c] = Color.Black;
			}

			for (int c = 5; c <= 43; c++)
			{
				this.picture_9[7, c] = Color.Black;
			}

			for (int c = 4; c <= 44; c++)
			{
				this.picture_9[8, c] = Color.Black;
			}

			for (int c = 3; c <= 45; c++)
			{
				this.picture_9[9, c] = Color.Black;
				this.picture_9[10, c] = Color.Black;
			}

			this.picture_9[10, 46] = Color.Black;

			for (int c = 2; c <= 22; c++)
			{
				this.picture_9[11, c] = Color.Black;				
			}

			for (int r = 14; r <= 28; r++)
			{
				for (int c = 1; c <= 16; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 12; r <= 13; r++)
			{
				for (int c = 2; c <= 18; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[12, 19] = Color.Black;
			this.picture_9[12, 20] = Color.Black;
			
			this.picture_9[14, 17] = Color.Black;
			this.picture_9[14, 18] = Color.Black;
			
			this.picture_9[15, 17] = Color.Black;
			this.picture_9[16, 17] = Color.Black;
			this.picture_9[17, 17] = Color.Black;

			for (int r = 11; r <= 35; r++)
			{
				for (int c = 33; c <= 45; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 11; r <= 14; r++)
			{
				for (int c = 31; c <= 32; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[11, 27] = Color.Black;
			this.picture_9[11, 28] = Color.Black;
			this.picture_9[11, 29] = Color.Black;
			this.picture_9[11, 30] = Color.Black;
			this.picture_9[11, 46] = Color.Black;
			
			this.picture_9[12, 29] = Color.Black;
			this.picture_9[12, 30] = Color.Black;

			for (int r = 17; r <= 45; r++)
			{
				for (int c = 46; c <= 49; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 12; r <= 16; r++)
			{
				for (int c = 46; c <= 47; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[13, 30] = Color.Black;
			
			this.picture_9[15, 31] = Color.Black;
			this.picture_9[15, 32] = Color.Black;
			
			this.picture_9[16, 32] = Color.Black;
			this.picture_9[17, 32] = Color.Black;
			this.picture_9[18, 32] = Color.Black;
			
			this.picture_9[14, 48] = Color.Black;
			this.picture_9[15, 48] = Color.Black;
			this.picture_9[16, 48] = Color.Black;

			for (int r = 21; r <= 41; r++)
			{
				this.picture_9[r, 50] = Color.Black;
			}
		}

		private void SetButtons()
		{
			Color buttonColor = Color.White;

			for (int x = PublicConstant.BUTTON_HEIGHT_START; x <= PublicConstant.BUTTON_HEIGHT_END; x++)
			{
				for (int y = PublicConstant.BUTTON_9X9_WIDTH_START; y <= PublicConstant.BUTTON_9X9_WIDTH_END; y++)
				{
					this[x, y] = buttonColor;
				}

				for (int y = PublicConstant.BUTTON_16X16_WIDTH_START; y <= PublicConstant.BUTTON_16X16_WIDTH_END; y++)
				{
					this[x, y] = buttonColor;
				}

				for (int y = PublicConstant.BUTTON_30X16_WIDTH_START; y <= PublicConstant.BUTTON_30X16_WIDTH_END; y++)
				{
					this[x, y] = buttonColor;
				}
			}

			for (int r = 0; r < this.picture_9.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_9.GetLength(1); c++)
				{
					this[71 + r, 103 + c] = this.picture_9[r, c];
					this[71 + r, 217 + c] = this.picture_9[r, c];
					this[71 + r, 461 + c] = this.picture_6[r, c];
					this[71 + r, 631 + c] = this.picture_6[r, c];
					this[71 + r, 988 + c] = this.picture_6[r, c];
				}
			}

			for (int r = 0; r < this.picture_0.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_0.GetLength(1); c++)
				{
					this[71 + r, 817 + c] = this.picture_0[r, c];
				}
			}

			for (int r = 0; r < this.picture_1.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_1.GetLength(1); c++)
				{
					this[71 + r, 408 + c] = this.picture_1[r, c];
					this[71 + r, 577 + c] = this.picture_1[r, c];
					this[71 + r, 934 + c] = this.picture_1[r, c];
				}
			}
		}		
	}
}
