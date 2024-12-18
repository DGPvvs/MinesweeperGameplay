﻿namespace RaylibMinesweeper.picture
{
	using Raylib_cs;
	using RaylibMinesweeper.Common;

	public class StartPicture : BasePicture
	{
		private Color[,] picture_0;
		private Color[,] picture_1;
		private Color[,] picture_3;
		private Color[,] picture_6;
		private Color[,] picture_9;
		private Color[,] picture_x;

		public StartPicture() : base(PublicConstant.START_HEIGHT, PublicConstant.START_WIDTH)
		{
			Color baseColor = new Color(91, 155, 213, 255);

			this.picture_0 = new Color[64, 51];
			this.picture_1 = new Color[62, 36];
			this.picture_3 = new Color[64, 50];
			this.picture_6 = new Color[64, 51];
			this.picture_9 = new Color[64, 51];
			this.picture_x = new Color[44, 56];

			this.SetPicture_9();
			this.SetPicture_6();
			this.SetPicture_0();
			this.SetPicture_1();
			this.SetPicture_3();
			this.SetPicture_X();

			this.SetBaseColor(baseColor);
			this.SetButtons();
		}

		private void SetPicture_3()
		{
			for (int r = 0; r < this.picture_3.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_3.GetLength(1); c++)
				{
					this.picture_3[r, c] = Color.White;
				}				
			}

			for (int r = 0; r <= 10; r++)
			{
				for (int c = 15; c <= 32; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 13; r <= 16; r++)
			{
				for (int c = 0; c <= 16; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 17; r <= 18; r++)
			{
				for (int c = 11; c <= 16; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[17, 6] = Color.Black;
			this.picture_3[17, 7] = Color.Black;
			this.picture_3[17, 8] = Color.Black;
			this.picture_3[17, 9] = Color.Black;
			this.picture_3[17, 10] = Color.Black;

			for (int r = 8; r <= 12; r++)
			{
				for (int c = 3; c <= 14; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[11, 1] = Color.Black;
			this.picture_3[12, 1] = Color.Black;
			
			this.picture_3[9, 2] = Color.Black;
			this.picture_3[10, 2] = Color.Black;
			this.picture_3[11, 2] = Color.Black;
			this.picture_3[12, 2] = Color.Black;

			for (int r = 11; r <= 12; r++)
			{
				for (int c = 15; c <= 19; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[13, 17] = Color.Black;
			this.picture_3[14, 17] = Color.Black;
			this.picture_3[15, 17] = Color.Black;
			
			this.picture_3[13, 18] = Color.Black;
			
			this.picture_3[11, 20] = Color.Black;
			this.picture_3[11, 21] = Color.Black;

			for (int r = 3; r <= 7; r++)
			{
				for (int c = 8; c <= 14; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 5; r <= 7; r++)
			{
				for (int c = 6; c <= 7; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[1, 12] = Color.Black;
			this.picture_3[1, 13] = Color.Black;
			this.picture_3[1, 14] = Color.Black;
			
			this.picture_3[2, 10] = Color.Black;
			this.picture_3[2, 11] = Color.Black;
			this.picture_3[2, 12] = Color.Black;
			this.picture_3[2, 13] = Color.Black;
			this.picture_3[2, 14] = Color.Black;
			
			this.picture_3[7, 4] = Color.Black;
			
			this.picture_3[6, 5] = Color.Black;
			this.picture_3[7, 5] = Color.Black;
			
			this.picture_3[4, 7] = Color.Black;

			for (int r = 12; r <= 18; r++)
			{
				for (int c = 29; c <= 46; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 9; r <= 11; r++)
			{
				for (int c = 25; c <= 45; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[12, 27] = Color.Black;
			this.picture_3[12, 28] = Color.Black;
			
			this.picture_3[13, 28] = Color.Black;

			for (int r = 3; r <= 8; r++)
			{
				for (int c = 33; c <= 39; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 1; r <= 2; r++)
			{
				for (int c = 33; c <= 36; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[2, 37] = Color.Black;
			this.picture_3[2, 38] = Color.Black;

			for (int r = 5; r <= 8; r++)
			{
				for (int c = 40; c <= 42; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[4, 40] = Color.Black;
			this.picture_3[4, 41] = Color.Black;
			
			this.picture_3[6, 43] = Color.Black;
			this.picture_3[7, 43] = Color.Black;
			this.picture_3[8, 43] = Color.Black;

			this.picture_3[8, 44] = Color.Black;

			for (int r = 23; r <= 35; r++)
			{
				for (int c = 19; c <= 38; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[33, 18] = Color.Black;
			this.picture_3[34, 18] = Color.Black;
			this.picture_3[35, 18] = Color.Black;

			for (int r = 19; r <= 22; r++)
			{
				for (int c = 29; c <= 44; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[22, 26] = Color.Black;
			this.picture_3[22, 27] = Color.Black;
			this.picture_3[22, 28] = Color.Black;
			
			this.picture_3[21, 27] = Color.Black;
			this.picture_3[21, 28] = Color.Black;
			
			this.picture_3[20, 28] = Color.Black;
			
			this.picture_3[19, 45] = Color.Black;
			this.picture_3[20, 45] = Color.Black;
			this.picture_3[21, 45] = Color.Black;

			for (int r = 23; r <= 26; r++)
			{
				for (int c = 39; c <= 41; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[27, 39] = Color.Black;
			
			this.picture_3[23, 42] = Color.Black;
			this.picture_3[24, 42] = Color.Black;
			this.picture_3[25, 42] = Color.Black;
			
			this.picture_3[23, 43] = Color.Black;
			this.picture_3[24, 43] = Color.Black;
			
			this.picture_3[23, 44] = Color.Black;

			for (int r = 38; r <= 47; r++)
			{
				for (int c = 32; c <= 49; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 36; r <= 37; r++)
			{
				for (int c = 30; c <= 48; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[36, 29] = Color.Black;
			
			this.picture_3[38, 31] = Color.Black;
			this.picture_3[39, 31] = Color.Black;

			for (int r = 31; r <= 35; r++)
			{
				for (int c = 39; c <= 44; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 29; r <= 30; r++)
			{
				for (int c = 39; c <= 41; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[30, 42] = Color.Black;
			this.picture_3[30, 43] = Color.Black;

			for (int r = 33; r <= 35; r++)
			{
				for (int c = 45; c <= 46; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[32, 45] = Color.Black;
			
			this.picture_3[34, 47] = Color.Black;
			this.picture_3[35, 47] = Color.Black;

			for (int r = 52; r <= 62; r++)
			{
				for (int c = 14; c <= 34; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 44; r <= 51; r++)
			{
				for (int c = 7; c <= 16; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[43, 15] = Color.Black;

			for (int r = 45; r <= 50; r++)
			{
				for (int c = 0; c <= 6; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 49; r <= 51; r++)
			{
				for (int c = 17; c <= 18; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[47, 17] = Color.Black;
			this.picture_3[48, 17] = Color.Black;
			
			this.picture_3[50, 19] = Color.Black;
			this.picture_3[51, 19] = Color.Black;
			
			this.picture_3[51, 20] = Color.Black;

			for (int r = 52; r <= 58; r++)
			{
				for (int c = 7; c <= 13; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 51; r <= 55; r++)
			{
				for (int c = 3; c <= 6; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[51, 1] = Color.Black;
			this.picture_3[52, 1] = Color.Black;
			
			this.picture_3[51, 2] = Color.Black;
			this.picture_3[52, 2] = Color.Black;
			this.picture_3[53, 2] = Color.Black;
			
			this.picture_3[56, 4] = Color.Black;
			this.picture_3[56, 5] = Color.Black;
			this.picture_3[56, 6] = Color.Black;
			
			this.picture_3[57, 5] = Color.Black;
			this.picture_3[57, 6] = Color.Black;
			
			this.picture_3[58, 6] = Color.Black;

			for (int r = 59; r <= 61; r++)
			{
				for (int c = 11; c <= 13; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[59, 8] = Color.Black;
			this.picture_3[59, 9] = Color.Black;
			this.picture_3[59, 10] = Color.Black;
			
			this.picture_3[60, 9] = Color.Black;
			this.picture_3[60, 10] = Color.Black;

			for (int r = 48; r <= 51; r++)
			{
				for (int c = 31; c <= 47; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[51, 20] = Color.Black;
			
			this.picture_3[47, 31] = Color.Black;
			
			this.picture_3[51, 28] = Color.Black;
			this.picture_3[51, 29] = Color.Black;
			this.picture_3[51, 30] = Color.Black;
			
			this.picture_3[50, 29] = Color.Black;
			this.picture_3[50, 30] = Color.Black;
			
			this.picture_3[49, 30] = Color.Black;
			
			this.picture_3[48, 48] = Color.Black;
			this.picture_3[49, 48] = Color.Black;
			this.picture_3[50, 48] = Color.Black;

			for (int r = 52; r <= 58; r++)
			{
				for (int c = 35; c <= 42; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			for (int r = 59; r <= 61; r++)
			{
				for (int c = 35; c <= 37; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[60, 38] = Color.Black;
			this.picture_3[60, 39] = Color.Black;
			
			this.picture_3[59, 38] = Color.Black;
			this.picture_3[59, 39] = Color.Black;
			this.picture_3[59, 40] = Color.Black;
			this.picture_3[59, 41] = Color.Black;
			
			this.picture_3[63, 19] = Color.Black;
			this.picture_3[63, 20] = Color.Black;
			this.picture_3[63, 21] = Color.Black;
			this.picture_3[63, 22] = Color.Black;
			this.picture_3[63, 23] = Color.Black;
			this.picture_3[63, 24] = Color.Black;
			this.picture_3[63, 25] = Color.Black;
			this.picture_3[63, 26] = Color.Black;
			this.picture_3[63, 27] = Color.Black;
			this.picture_3[63, 28] = Color.Black;
			this.picture_3[63, 29] = Color.Black;

			for (int r = 52; r <= 55; r++)
			{
				for (int c = 43; c <= 45; c++)
				{
					this.picture_3[r, c] = Color.Black;
				}
			}

			this.picture_3[56, 43] = Color.Black;
			this.picture_3[56, 44] = Color.Black;
			
			this.picture_3[57, 43] = Color.Black;
			
			this.picture_3[52, 46] = Color.Black;
			this.picture_3[52, 47] = Color.Black;
			
			this.picture_3[53, 46] = Color.Black;
		}

		private void SetPicture_X()
		{
			for (int r = 0; r < this.picture_x.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_x.GetLength(1); c++)
				{
					this.picture_x[r, c] = Color.White;
				}
			}

			for (int r = 0; r <= 11; r++)
			{
				for (int c = 8; c <= 21; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 0; r <= 3; r++)
			{
				for (int c = 2; c <= 7; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[0, 0] = Color.Black;
			this.picture_x[0, 1] = Color.Black;
			
			this.picture_x[1, 1] = Color.Black;

			for (int c = 3; c <= 7; c++)
			{
				this.picture_x[3, c] = Color.Black;
				this.picture_x[4, c] = Color.Black;
			}

			for (int c = 6; c <= 7; c++)
			{
				this.picture_x[7, c] = Color.Black;
				this.picture_x[8, c] = Color.Black;
			}

			this.picture_x[5, 4] = Color.Black;
			
			this.picture_x[9, 7] = Color.Black;

			for (int r = 5; r <= 10; r++)
			{
				for (int c = 22; c <= 24; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[2, 22] = Color.Black;
			this.picture_x[3, 22] = Color.Black;
			this.picture_x[4, 22] = Color.Black;
			
			this.picture_x[4, 23] = Color.Black;
			
			this.picture_x[7, 25] = Color.Black;
			this.picture_x[8, 25] = Color.Black;
			this.picture_x[9, 25] = Color.Black;
			this.picture_x[10, 25] = Color.Black;
			
			this.picture_x[9, 26] = Color.Black;
			this.picture_x[10, 26] = Color.Black;

			for (int r = 11; r <= 30; r++)
			{
				for (int c = 22; c <= 39; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 12; r <= 39; r++)
			{
				for (int c = 15; c <= 21; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 7; r <= 8; r++)
			{
				for (int c = 6; c <= 13; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 12; r <= 16; r++)
			{
				for (int c = 12; c <= 14; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[12, 9] = Color.Black;
			
			this.picture_x[12, 10] = Color.Black;
			this.picture_x[13, 10] = Color.Black;
			
			this.picture_x[12, 11] = Color.Black;
			this.picture_x[13, 11] = Color.Black;
			this.picture_x[14, 11] = Color.Black;
			this.picture_x[15, 11] = Color.Black;
			
			this.picture_x[17, 13] = Color.Black;
			this.picture_x[18, 13] = Color.Black;
			
			this.picture_x[17, 14] = Color.Black;
			this.picture_x[18, 14] = Color.Black;
			this.picture_x[19, 14] = Color.Black;

			for (int r = 9; r <= 11; r++)
			{
				for (int c = 8; c <= 16; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 2; r <= 4; r++)
			{
				for (int c = 3; c <= 13; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 0; r <= 10; r++)
			{
				for (int c = 35; c <= 47; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 8; r <= 10; r++)
			{
				for (int c = 30; c <= 34; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[9, 29] = Color.Black;
			this.picture_x[8, 29] = Color.Black;

			for (int r = 4; r <= 7; r++)
			{
				for (int c = 32; c <= 34; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[7, 30] = Color.Black;
			
			this.picture_x[6, 31] = Color.Black;
			this.picture_x[7, 31] = Color.Black;
			
			this.picture_x[3, 33] = Color.Black;
			
			this.picture_x[1, 34] = Color.Black;
			this.picture_x[2, 34] = Color.Black;
			this.picture_x[3, 34] = Color.Black;

			for (int r = 0; r <= 4; r++)
			{
				for (int c = 48; c <= 51; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 5; r <= 6; r++)
			{
				for (int c = 48; c <= 50; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 0; r <= 2; r++)
			{
				for (int c = 52; c <= 53; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[0, 54] = Color.Black;
			
			this.picture_x[3, 52] = Color.Black;
			
			this.picture_x[7, 48] = Color.Black;
			this.picture_x[7, 49] = Color.Black;
			
			this.picture_x[8, 48] = Color.Black;
			this.picture_x[9, 48] = Color.Black;

			for (int r = 11; r <= 15; r++)
			{
				for (int c = 40; c <= 43; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 11; r <= 13; r++)
			{
				this.picture_x[r, 44] = Color.Black;
				this.picture_x[r, 45] = Color.Black;
			}

			for (int r = 16; r <= 18; r++)
			{
				this.picture_x[r, 40] = Color.Black;
				this.picture_x[r, 41] = Color.Black;
			}

			this.picture_x[11, 46] = Color.Black;
			
			this.picture_x[14, 44] = Color.Black;
			
			this.picture_x[16, 42] = Color.Black;
			this.picture_x[16, 43] = Color.Black;
			
			this.picture_x[17, 42] = Color.Black;
			
			this.picture_x[19, 40] = Color.Black;
			this.picture_x[20, 40] = Color.Black;

			for (int r = 40; r <= 43; r++)
			{
				for (int c = 2; c <= 18; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[43, 0] = Color.Black;
			this.picture_x[43, 1] = Color.Black;
			
			this.picture_x[41, 1] = Color.Black;
			this.picture_x[42, 1] = Color.Black;
			
			this.picture_x[40, 19] = Color.Black;
			this.picture_x[41, 19] = Color.Black;
			this.picture_x[42, 19] = Color.Black;
			
			this.picture_x[40, 20] = Color.Black;
			this.picture_x[41, 20] = Color.Black;

			for (int r = 31; r <= 35; r++)
			{
				for (int c = 22; c <= 24; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[31, 25] = Color.Black;
			this.picture_x[32, 25] = Color.Black;
			this.picture_x[33, 25] = Color.Black;
			
			this.picture_x[31, 26] = Color.Black;
			this.picture_x[32, 26] = Color.Black;
			
			this.picture_x[36, 22] = Color.Black;
			this.picture_x[37, 22] = Color.Black;
			this.picture_x[38, 22] = Color.Black;
			
			this.picture_x[36, 23] = Color.Black;

			for (int r = 32; r <= 39; r++)
			{
				for (int c = 7; c <= 14; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 28; r <= 31; r++)
			{
				for (int c = 10; c <= 14; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 25; r <= 27; r++)
			{
				for (int c = 12; c <= 14; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 37; r <= 39; r++)
			{
				for (int c = 4; c <= 6; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[22, 14] = Color.Black;
			this.picture_x[23, 14] = Color.Black;
			this.picture_x[24, 14] = Color.Black;
			
			this.picture_x[24, 13] = Color.Black;
			
			this.picture_x[27, 11] = Color.Black;
			
			this.picture_x[29, 9] = Color.Black;
			this.picture_x[30, 9] = Color.Black;
			this.picture_x[31, 9] = Color.Black;
			
			this.picture_x[31, 8] = Color.Black;
			
			this.picture_x[34, 6] = Color.Black;
			this.picture_x[35, 6] = Color.Black;
			this.picture_x[36, 6] = Color.Black;
			
			this.picture_x[35, 5] = Color.Black;
			this.picture_x[36, 5] = Color.Black;
			
			this.picture_x[38, 3] = Color.Black;
			this.picture_x[39, 3] = Color.Black;

			for (int r = 31; r <= 43; r++)
			{
				for (int c = 35; c <= 47; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 27; r <= 30; r++)
			{
				for (int c = 40; c <= 44; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 24; r <= 26; r++)
			{
				for (int c = 40; c <= 42; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[22, 40] = Color.Black;
			this.picture_x[23, 40] = Color.Black;
			
			this.picture_x[23, 41] = Color.Black;
			
			this.picture_x[26, 43] = Color.Black;
			
			this.picture_x[29, 45] = Color.Black;
			this.picture_x[30, 45] = Color.Black;
			
			this.picture_x[30, 46] = Color.Black;

			for (int r = 31; r <= 36; r++)
			{
				for (int c = 31; c <= 34; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 31; r <= 33; r++)
			{
				for (int c = 29; c <= 30; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 37; r <= 40; r++)
			{
				for (int c = 33; c <= 34; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[41, 34] = Color.Black;
			this.picture_x[42, 34] = Color.Black;
			
			this.picture_x[37, 32] = Color.Black;
			this.picture_x[38, 32] = Color.Black;
			
			this.picture_x[34, 30] = Color.Black;
			this.picture_x[35, 30] = Color.Black;
			
			this.picture_x[31, 28] = Color.Black;

			for (int r = 36; r <= 43; r++)
			{
				for (int c = 48; c <= 50; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			for (int r = 40; r <= 43; r++)
			{
				for (int c = 51; c <= 53; c++)
				{
					this.picture_x[r, c] = Color.Black;
				}
			}

			this.picture_x[33, 48] = Color.Black;
			this.picture_x[34, 48] = Color.Black;
			this.picture_x[35, 48] = Color.Black;
			
			this.picture_x[34, 49] = Color.Black;
			this.picture_x[35, 49] = Color.Black;
			
			this.picture_x[37, 51] = Color.Black;
			this.picture_x[38, 51] = Color.Black;
			this.picture_x[39, 51] = Color.Black;
			
			this.picture_x[39, 52] = Color.Black;
			
			this.picture_x[41, 54] = Color.Black;
			this.picture_x[42, 54] = Color.Black;
			this.picture_x[43, 54] = Color.Black;
			
			this.picture_x[43, 55] = Color.Black;
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

			for (int r = 3; r <= 11; r++)
			{
				for (int c = 10; c <= 40; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 12; r <= 50; r++)
			{
				for (int c = 3; c <= 17; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 7; r <= 11; r++)
			{
				for (int c = 6; c <= 9; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 9; r <= 11; r++)
			{
				for (int c = 4; c <= 5; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[11, 3] = Color.Black;
			
			this.picture_0[8, 5] = Color.Black;
			
			this.picture_0[6, 7] = Color.Black;
			this.picture_0[6, 8] = Color.Black;
			this.picture_0[6, 9] = Color.Black;
			
			this.picture_0[5, 8] = Color.Black;
			this.picture_0[5, 9] = Color.Black;
			
			this.picture_0[4, 9] = Color.Black;

			for (int r = 12; r <= 16; r++)
			{
				for (int c = 18; c <= 19; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[17, 18] = Color.Black;
			this.picture_0[18, 18] = Color.Black;
			this.picture_0[19, 18] = Color.Black;
			this.picture_0[20, 18] = Color.Black;
			
			this.picture_0[12, 20] = Color.Black;
			this.picture_0[13, 20] = Color.Black;
			this.picture_0[14, 20] = Color.Black;
			
			this.picture_0[12, 21] = Color.Black;
			this.picture_0[12, 22] = Color.Black;

			this.picture_0[14, 2] = Color.Black;
			this.picture_0[15, 2] = Color.Black;
			this.picture_0[16, 2] = Color.Black;
			
			this.picture_0[45, 2] = Color.Black;
			this.picture_0[46, 2] = Color.Black;
			this.picture_0[47, 2] = Color.Black;
			this.picture_0[48, 2] = Color.Black;

			for (int r = 22; r <= 39; r++)
			{
				for (int c = 0; c <= 2; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 17; r <= 31; r++)
			{
				for (int c = 1; c <= 2; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 40; r <= 44; r++)
			{
				for (int c = 1; c <= 2; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 12; r <= 51; r++)
			{
				for (int c = 33; c <= 47; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 12; r <= 14; r++)
			{
				for (int c = 30; c <= 32; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[12, 28] = Color.Black;
			this.picture_0[12, 29] = Color.Black;
			
			this.picture_0[13, 29] = Color.Black;
			
			this.picture_0[15, 31] = Color.Black;
			this.picture_0[16, 31] = Color.Black;
			
			this.picture_0[15, 32] = Color.Black;
			this.picture_0[16, 32] = Color.Black;
			this.picture_0[17, 32] = Color.Black;
			this.picture_0[18, 32] = Color.Black;
			this.picture_0[19, 32] = Color.Black;
			this.picture_0[20, 32] = Color.Black;
			this.picture_0[21, 32] = Color.Black;
			
			this.picture_0[4, 41] = Color.Black;
			this.picture_0[5, 41] = Color.Black;
			
			this.picture_0[5, 42] = Color.Black;
			
			this.picture_0[7, 44] = Color.Black;
			this.picture_0[8, 44] = Color.Black;
			
			this.picture_0[8, 45] = Color.Black;
			
			this.picture_0[10, 46] = Color.Black;
			this.picture_0[11, 46] = Color.Black;
			
			this.picture_0[23, 50] = Color.Black;
			
			this.picture_0[14, 48] = Color.Black;
			this.picture_0[15, 48] = Color.Black;
			this.picture_0[16, 48] = Color.Black;
			this.picture_0[17, 48] = Color.Black;
			
			this.picture_0[46, 48] = Color.Black;
			this.picture_0[47, 48] = Color.Black;
			this.picture_0[48, 48] = Color.Black;

			for (int r = 10; r <= 23; r++)
			{
				for (int c = 48; c <= 49; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 6; r <= 11; r++)
			{
				for (int c = 41; c <= 43; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 9; r <= 11; r++)
			{
				for (int c = 44; c <= 45; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 24; r <= 39; r++)
			{
				for (int c = 48; c <= 50; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 40; r <= 45; r++)
			{
				for (int c = 48; c <= 49; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 51; r <= 59; r++)
			{
				for (int c = 10; c <= 32; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 52; r <= 57; r++)
			{
				for (int c = 33; c <= 43; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 46; r <= 50; r++)
			{
				for (int c = 18; c <= 19; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[41, 18] = Color.Black;
			this.picture_0[42, 18] = Color.Black;
			this.picture_0[43, 18] = Color.Black;
			this.picture_0[44, 18] = Color.Black;
			this.picture_0[45, 18] = Color.Black;
			
			this.picture_0[48, 20] = Color.Black;
			this.picture_0[49, 20] = Color.Black;
			this.picture_0[50, 20] = Color.Black;
			
			this.picture_0[49, 21] = Color.Black;
			this.picture_0[50, 21] = Color.Black;
			
			this.picture_0[50, 22] = Color.Black;

			for (int r = 48; r <= 50; r++)
			{
				for (int c = 30; c <= 32; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[50, 28] = Color.Black;
			this.picture_0[50, 29] = Color.Black;
			
			this.picture_0[46, 31] = Color.Black;
			this.picture_0[47, 31] = Color.Black;
			
			this.picture_0[42, 32] = Color.Black;
			this.picture_0[43, 32] = Color.Black;
			this.picture_0[44, 32] = Color.Black;
			this.picture_0[45, 32] = Color.Black;
			this.picture_0[46, 32] = Color.Black;
			this.picture_0[47, 32] = Color.Black;

			for (int r = 52; r <= 53; r++)
			{
				for (int c = 44; c <= 46; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[54, 44] = Color.Black;
			this.picture_0[55, 44] = Color.Black;
			this.picture_0[56, 44] = Color.Black;

			this.picture_0[54, 45] = Color.Black;

			for (int r = 51; r <= 55; r++)
			{
				for (int c = 6; c <= 9; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[51, 4] = Color.Black;
			this.picture_0[52, 4] = Color.Black;
			
			this.picture_0[51, 5] = Color.Black;
			this.picture_0[52, 5] = Color.Black;
			this.picture_0[53, 5] = Color.Black;
			this.picture_0[54, 5] = Color.Black;
			
			this.picture_0[56, 7] = Color.Black;
			this.picture_0[56, 8] = Color.Black;
			this.picture_0[56, 9] = Color.Black;
			
			this.picture_0[57, 8] = Color.Black;
			this.picture_0[57, 9] = Color.Black;
			
			this.picture_0[58, 9] = Color.Black;

			for (int r = 58; r <= 60; r++)
			{
				for (int c = 33; c <= 39; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[58, 40] = Color.Black;
			this.picture_0[58, 41] = Color.Black;
			this.picture_0[58, 42] = Color.Black;
			
			this.picture_0[59, 40] = Color.Black;

			for (int r = 60; r <= 63; r++)
			{
				for (int c = 21; c <= 29; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 60; r <= 62; r++)
			{
				for (int c = 30; c <= 32; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			for (int r = 60; r <= 62; r++)
			{
				for (int c = 16; c <= 20; c++)
				{
					this.picture_0[r, c] = Color.Black;
				}
			}

			this.picture_0[60, 12] = Color.Black;
			this.picture_0[60, 13] = Color.Black;
			this.picture_0[60, 14] = Color.Black;
			this.picture_0[60, 15] = Color.Black;
			
			this.picture_0[61, 13] = Color.Black;
			this.picture_0[61, 14] = Color.Black;
			this.picture_0[61, 15] = Color.Black;
			
			this.picture_0[61, 33] = Color.Black;
			this.picture_0[61, 34] = Color.Black;
			this.picture_0[61, 35] = Color.Black;
			this.picture_0[61, 36] = Color.Black;
			this.picture_0[61, 37] = Color.Black;
			
			this.picture_0[62, 33] = Color.Black;
			this.picture_0[62, 34] = Color.Black;
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

			for (int r = 29; r <= 32; r++)
			{
				for (int c = 3; c <= 19; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 17; r <= 25; r++)
			{
				this.picture_9[r, 0] = Color.Black;
			}

			for (int r = 23; r <= 28; r++)
			{
				this.picture_9[r, 17] = Color.Black;
			}

			this.picture_9[27, 18] = Color.Black;
			this.picture_9[28, 18] = Color.Black;
			
			this.picture_9[28, 19] = Color.Black;
			
			this.picture_9[29, 2] = Color.Black;
			this.picture_9[30, 2] = Color.Black;
			this.picture_9[31, 2] = Color.Black;

			for (int r = 33; r <= 41; r++)
			{
				for (int c = 14; c <= 25; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int c = 20; c <= 32; c++)
			{
				this.picture_9[31, c] = Color.Black;
				this.picture_9[32, c] = Color.Black;
			}

			this.picture_9[29, 20] = Color.Black;
			this.picture_9[30, 20] = Color.Black;
			
			this.picture_9[30, 21] = Color.Black;
			this.picture_9[30, 22] = Color.Black;

			for (int r = 33; r <= 35; r++)
			{
				for (int c = 5; c <= 13; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 36; r <= 38; r++)
			{
				for (int c = 8; c <= 13; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[33, 4] = Color.Black;
			this.picture_9[34, 4] = Color.Black;
			
			this.picture_9[36, 6] = Color.Black;
			this.picture_9[36, 7] = Color.Black;
			
			this.picture_9[37, 7] = Color.Black;
			
			this.picture_9[39, 10] = Color.Black;
			this.picture_9[39, 11] = Color.Black;
			this.picture_9[39, 12] = Color.Black;
			this.picture_9[39, 13] = Color.Black;
			
			this.picture_9[40, 11] = Color.Black;
			this.picture_9[40, 12] = Color.Black;
			this.picture_9[40, 13] = Color.Black;

			for (int r = 28; r <= 30; r++)
			{
				for (int c = 30; c <= 32; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[24, 32] = Color.Black;
			this.picture_9[25, 32] = Color.Black;
			this.picture_9[26, 32] = Color.Black;
			this.picture_9[27, 32] = Color.Black;
			
			this.picture_9[27, 31] = Color.Black;
			
			this.picture_9[29, 29] = Color.Black;
			this.picture_9[29, 30] = Color.Black;
			
			this.picture_9[30, 27] = Color.Black;
			this.picture_9[30, 28] = Color.Black;

			for (int r = 33; r <= 36; r++)
			{
				for (int c = 26; c <= 32; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 37; r <= 39; r++)
			{
				for (int c = 26; c <= 29; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[40, 26] = Color.Black;
			this.picture_9[40, 27] = Color.Black;
			this.picture_9[40, 28] = Color.Black;
			
			this.picture_9[38, 30] = Color.Black;
			this.picture_9[38, 31] = Color.Black;
			
			this.picture_9[37, 30] = Color.Black;
			this.picture_9[37, 31] = Color.Black;
			this.picture_9[37, 32] = Color.Black;

			for (int r = 36; r <= 53; r++)
			{
				for (int c = 33; c <= 45; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 52; r <= 58; r++)
			{
				for (int c = 7; c <= 32; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 46; r <= 48; r++)
			{
				for (int c = 46; c <= 48; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 47; r <= 51; r++)
			{
				for (int c = 31; c <= 32; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[42, 32] = Color.Black;
			this.picture_9[43, 32] = Color.Black;
			this.picture_9[44, 32] = Color.Black;
			this.picture_9[45, 32] = Color.Black;
			this.picture_9[46, 32] = Color.Black;
			
			this.picture_9[49, 47] = Color.Black;
			this.picture_9[50, 47] = Color.Black;
			
			this.picture_9[49, 46] = Color.Black;
			this.picture_9[50, 46] = Color.Black;
			this.picture_9[51, 46] = Color.Black;
			this.picture_9[52, 46] = Color.Black;
			
			this.picture_9[49, 30] = Color.Black;
			this.picture_9[50, 30] = Color.Black;
			this.picture_9[51, 30] = Color.Black;
			
			this.picture_9[50, 29] = Color.Black;
			this.picture_9[51, 29] = Color.Black;
			
			this.picture_9[51, 28] = Color.Black;

			for (int r = 54; r <= 58; r++)
			{
				for (int c = 33; c <= 40; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 54; r <= 56; r++)
			{
				for (int c = 41; c <= 43; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[54, 44] = Color.Black;
			this.picture_9[55, 44] = Color.Black;
			
			this.picture_9[57, 41] = Color.Black;
			this.picture_9[57, 42] = Color.Black;

			for (int r = 59; r <= 63; r++)
			{
				for (int c = 19; c <= 28; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 59; r <= 62; r++)
			{
				for (int c = 29; c <= 33; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 59; r <= 60; r++)
			{
				for (int c = 34; c <= 38; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[59, 39] = Color.Black;
			
			this.picture_9[61, 34] = Color.Black;
			this.picture_9[61, 35] = Color.Black;

			for (int r = 59; r <= 62; r++)
			{
				for (int c = 14; c <= 18; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 59; r <= 60; r++)
			{
				for (int c = 10; c <= 13; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[59, 9] = Color.Black;
			
			this.picture_9[61, 12] = Color.Black;
			this.picture_9[61, 13] = Color.Black;

			for (int r = 48; r <= 54; r++)
			{
				for (int c = 4; c <= 6; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[55, 6] = Color.Black;
			this.picture_9[56, 6] = Color.Black;
			this.picture_9[57, 6] = Color.Black;
			
			this.picture_9[55, 5] = Color.Black;
			this.picture_9[56, 5] = Color.Black;

			for (int r = 48; r <= 51; r++)
			{
				for (int c = 2; c <= 3; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[52, 3] = Color.Black;
			this.picture_9[53, 3] = Color.Black;

			for (int r = 47; r <= 51; r++)
			{
				for (int c = 7; c <= 12; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			for (int r = 46; r <= 51; r++)
			{
				for (int c = 13; c <= 18; c++)
				{
					this.picture_9[r, c] = Color.Black;
				}
			}

			this.picture_9[48, 1] = Color.Black;
			
			this.picture_9[47, 5] = Color.Black;
			this.picture_9[47, 6] = Color.Black;
			
			this.picture_9[47, 19] = Color.Black;
			this.picture_9[48, 19] = Color.Black;
			this.picture_9[49, 19] = Color.Black;
			this.picture_9[50, 19] = Color.Black;
			this.picture_9[51, 19] = Color.Black;
			
			this.picture_9[50, 20] = Color.Black;
			this.picture_9[51, 20] = Color.Black;
			
			this.picture_9[51, 21] = Color.Black;
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

			for (int r = 0; r < this.picture_3.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_3.GetLength(1); c++)
				{
					this[71 + r, 761 + c] = this.picture_3[r, c];
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

			for (int r = 0; r < this.picture_x.GetLength(0); r++)
			{
				for (int c = 0; c < this.picture_x.GetLength(1); c++)
				{
					this[88 + r, 158 + c] = this.picture_x[r, c];
					this[88 + r, 517 + c] = this.picture_x[r, c];
					this[88 + r, 872 + c] = this.picture_x[r, c];
				}
			}
		}		
	}
}
