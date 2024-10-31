namespace RaylibMinesweeper.picture
{
	using Raylib_cs;

	public class MinePicture : BasePicture
	{
		public MinePicture() : base(Color.White)
		{
			this[1, 13] = new Color(175, 175, 175, 255);
			this[1, 14] = new Color(152, 152, 152, 255);
			this[1, 15] = new Color(170, 170, 170, 255);

			this[2, 12] = new Color(105, 105, 105, 255);
			this[2, 13] = new Color(0, 0, 0, 255);
			this[2, 14] = new Color(24, 24, 24, 255);
			this[2, 15] = new Color(0, 0, 0, 255);
			this[2, 16] = new Color(86, 86, 86, 255);

			this[3, 12] = new Color(109, 109, 109, 255);
			this[3, 13] = new Color(0, 0, 0, 255);
			this[3, 14] = new Color(31, 31, 31, 255);
			this[3, 15] = new Color(1, 1, 1, 255);
			this[3, 16] = new Color(86, 86, 86, 255);

			this[4, 6] = new Color(99, 99, 99, 255);
			this[4, 7] = new Color(108, 108, 108, 255);
			this[4, 10] = new Color(156, 156, 156, 255);
			this[4, 11] = new Color(91, 91, 91, 255);
			this[4, 12] = new Color(22, 22, 22, 255);
			this[4, 13] = new Color(0, 0, 0, 255);
			this[4, 14] = new Color(0, 0, 0, 255);
			this[4, 15] = new Color(0, 0, 0, 255);
			this[4, 16] = new Color(16, 16, 16, 255);
			this[4, 17] = new Color(81, 81, 81, 255);
			this[4, 18] = new Color(18, 18, 18, 255);
			this[4, 21] = new Color(21, 21, 21, 255);
			this[4, 22] = new Color(22, 22, 22, 255);

			this[5, 5] = new Color(94, 94, 94, 255);
			this[5, 6] = new Color(0, 0, 0, 255);
			this[5, 7] = new Color(0, 0, 0, 255);
			this[5, 8] = new Color(110, 110, 110, 255);
			this[5, 9] = new Color(65, 65, 65, 255);
			this[5, 9] = new Color(65, 65, 65, 255);
			this[5, 10] = new Color(0, 0, 0, 255);
			this[5, 11] = new Color(0, 0, 0, 255);
			this[5, 12] = new Color(0, 0, 0, 255);
			this[5, 13] = new Color(0, 0, 0, 255);
			this[5, 14] = new Color(0, 0, 0, 255);
			this[5, 15] = new Color(0, 0, 0, 255);
			this[5, 16] = new Color(0, 0, 0, 255);
			this[5, 17] = new Color(0, 0, 0, 255);
			this[5, 18] = new Color(0, 0, 0, 255);
			this[5, 19] = new Color(42, 42, 42, 255);
			this[5, 20] = new Color(103, 103, 103, 255);
			this[5, 21] = new Color(0, 0, 0, 255);
			this[5, 22] = new Color(0, 0, 0, 255);
			this[5, 23] = new Color(64, 64, 64, 255);
			
			this[6, 4] = new Color(97, 97, 97, 255);
			this[6, 5] = new Color(0, 0, 0, 255);
			this[6, 6] = new Color(48, 48, 48, 255);
			this[6, 7] = new Color(7, 7, 7, 255);
			this[6, 8] = new Color(0, 0, 0, 255);
			this[6, 9] = new Color(0, 0, 0, 255);
			this[6, 10] = new Color(0, 0, 0, 255);
			this[6, 11] = new Color(0, 0, 0, 255);
			this[6, 12] = new Color(0, 0, 0, 255);
			this[6, 13] = new Color(0, 0, 0, 255);
			this[6, 14] = new Color(0, 0, 0, 255);
			this[6, 15] = new Color(0, 0, 0, 255);
			this[6, 16] = new Color(0, 0, 0, 255);
			this[6, 17] = new Color(0, 0, 0, 255);
			this[6, 18] = new Color(0, 0, 0, 255);
			this[6, 19] = new Color(0, 0, 0, 255);
			this[6, 20] = new Color(0, 0, 0, 255);
			this[6, 21] = new Color(0, 0, 0, 255);
			this[6, 22] = new Color(44, 44, 44, 255);
			this[6, 23] = new Color(0, 0, 0, 255);
			this[6, 24] = new Color(95, 95, 95, 255);
			
			this[7, 4] = new Color(108, 108, 108, 255);
			this[7, 5] = new Color(0, 0, 0, 255);
			this[7, 6] = new Color(0, 0, 0, 255);
			this[7, 7] = new Color(0, 0, 0, 255);
			this[7, 8] = new Color(0, 0, 0, 255);
			this[7, 9] = new Color(0, 0, 0, 255);
			this[7, 10] = new Color(0, 0, 0, 255);
			this[7, 11] = new Color(0, 0, 0, 255);
			this[7, 12] = new Color(0, 0, 0, 255);
			this[7, 13] = new Color(0, 0, 0, 255);
			this[7, 14] = new Color(0, 0, 0, 255);
			this[7, 15] = new Color(0, 0, 0, 255);
			this[7, 16] = new Color(0, 0, 0, 255);
			this[7, 17] = new Color(0, 0, 0, 255);
			this[7, 18] = new Color(0, 0, 0, 255);
			this[7, 19] = new Color(0, 0, 0, 255);
			this[7, 20] = new Color(0, 0, 0, 255);
			this[7, 21] = new Color(0, 0, 0, 255);
			this[7, 22] = new Color(0, 0, 0, 255);
			this[7, 23] = new Color(30, 30, 30, 255);
			this[7, 24] = new Color(115, 115, 115, 255);
			
			this[8, 5] = new Color(101, 101, 101, 255);
			this[8, 6] = new Color(0, 0, 0, 255);
			this[8, 7] = new Color(0, 0, 0, 255);
			this[8, 8] = new Color(0, 0, 0, 255);
			this[8, 9] = new Color(0, 0, 0, 255);
			this[8, 10] = new Color(0, 0, 0, 255);
			this[8, 11] = new Color(0, 0, 0, 255);
			this[8, 12] = new Color(0, 0, 0, 255);
			this[8, 13] = new Color(0, 0, 0, 255);
			this[8, 14] = new Color(0, 0, 0, 255);
			this[8, 15] = new Color(0, 0, 0, 255);
			this[8, 16] = new Color(0, 0, 0, 255);
			this[8, 17] = new Color(0, 0, 0, 255);
			this[8, 18] = new Color(0, 0, 0, 255);
			this[8, 19] = new Color(0, 0, 0, 255);
			this[8, 20] = new Color(0, 0, 0, 255);
			this[8, 21] = new Color(0, 0, 0, 255);
			this[8, 22] = new Color(0, 0, 0, 255);
			this[8, 23] = new Color(91, 91, 91, 255);

			this[9, 5] = new Color(63, 63, 63, 255);
			this[9, 6] = new Color(0, 0, 0, 255);
			this[9, 7] = new Color(0, 0, 0, 255);
			this[9, 8] = new Color(0, 0, 0, 255);
			this[9, 9] = new Color(0, 0, 0, 255);
			this[9, 10] = new Color(0, 0, 0, 255);
			this[9, 11] = new Color(0, 0, 0, 255);
			this[9, 12] = new Color(0, 0, 0, 255);
			this[9, 13] = new Color(0, 0, 0, 255);
			this[9, 14] = new Color(0, 0, 0, 255);
			this[9, 15] = new Color(0, 0, 0, 255);
			this[9, 16] = new Color(0, 0, 0, 255);
			this[9, 17] = new Color(0, 0, 0, 255);
			this[9, 18] = new Color(0, 0, 0, 255);
			this[9, 19] = new Color(0, 0, 0, 255);
			this[9, 20] = new Color(0, 0, 0, 255);
			this[9, 21] = new Color(0, 0, 0, 255);
			this[9, 22] = new Color(0, 0, 0, 255);
			this[9, 23] = new Color(25, 25, 25, 255);

			this[10, 4] = new Color(151, 151, 151, 255);
			this[10, 5] = new Color(0, 0, 0, 255);
			this[10, 6] = new Color(0, 0, 0, 255);
			this[10, 7] = new Color(0, 0, 0, 255);
			this[10, 8] = new Color(0, 0, 0, 255);
			this[10, 9] = new Color(1, 1, 1, 255);
			this[10, 10] = new Color(5, 5, 5, 255);
			this[10, 11] = new Color(12, 12, 12, 255);
			this[10, 12] = new Color(26, 26, 26, 255);
			this[10, 13] = new Color(34, 34, 34, 255);
			this[10, 14] = new Color(34, 34, 34, 255);
			this[10, 15] = new Color(34, 34, 34, 255);
			this[10, 16] = new Color(28, 28, 28, 255);
			this[10, 17] = new Color(13, 13, 13, 255);
			this[10, 18] = new Color(5, 5, 5, 255);
			this[10, 19] = new Color(3, 3, 3, 255);
			this[10, 20] = new Color(10, 10, 10, 255);
			this[10, 21] = new Color(53, 53, 53, 255);
			this[10, 22] = new Color(61, 61, 61, 255);
			this[10, 23] = new Color(0, 0, 0, 255);
			this[10, 24] = new Color(114, 114, 114, 255);

			this[11, 4] = new Color(83, 83, 83, 255);
			this[11, 5] = new Color(0, 0, 0, 255);
			this[11, 6] = new Color(0, 0, 0, 255);
			this[11, 8] = new Color(0, 0, 0, 255);
			this[11, 7] = new Color(0, 0, 0, 255);
			this[11, 9] = new Color(4, 4, 4, 255);
			this[11, 10] = new Color(12, 12, 12, 255);
			this[11, 11] = new Color(32, 32, 32, 255);
			this[11, 12] = new Color(32, 32, 32, 255);
			this[11, 13] = new Color(11, 11, 11, 255);
			this[11, 14] = new Color(0, 0, 0, 255);
			this[11, 15] = new Color(9, 9, 9, 255);
			this[11, 16] = new Color(27, 27, 27, 255);
			this[11, 17] = new Color(30, 30, 30, 255);
			this[11, 18] = new Color(13, 13, 13, 255);
			this[11, 19] = new Color(10, 10, 10, 255);
			this[11, 20] = new Color(36, 36, 36, 255);
			this[11, 21] = new Color(83, 83, 83, 255);
			this[11, 22] = new Color(118, 118, 118, 255);
			this[11, 23] = new Color(38, 38, 38, 255);
			this[11, 24] = new Color(54, 54, 54, 255);

			this[12, 2] = new Color(111, 111, 111, 255);
			this[12, 3] = new Color(111, 111, 111, 255);
			this[12, 4] = new Color(0, 0, 0, 255);
			this[12, 5] = new Color(0, 0, 0, 255);
			this[12, 6] = new Color(0, 0, 0, 255);
			this[12, 7] = new Color(0, 0, 0, 255);
			this[12, 8] = new Color(0, 0, 0, 255);
			this[12, 9] = new Color(0, 0, 0, 255);
			this[12, 10] = new Color(26, 26, 26, 255);
			this[12, 11] = new Color(33, 33, 33, 255);
			this[12, 12] = new Color(0, 0, 0, 255);
			this[12, 13] = new Color(0, 0, 0, 255);
			this[12, 14] = new Color(16, 16, 16, 255);
			this[12, 15] = new Color(0, 0, 0, 255);
			this[12, 16] = new Color(0, 0, 0, 255);
			this[12, 17] = new Color(29, 29, 29, 255);
			this[12, 18] = new Color(29, 29, 29, 255);
			this[12, 19] = new Color(14, 14, 14, 255);
			this[12, 20] = new Color(39, 39, 39, 255);
			this[12, 21] = new Color(92, 92, 92, 255);
			this[12, 22] = new Color(136, 136, 136, 255);
			this[12, 23] = new Color(105, 105, 105, 255);
			this[12, 24] = new Color(30, 30, 30, 255);
			this[12, 25] = new Color(100, 100, 100, 255);
			this[12, 26] = new Color(114, 114, 114, 255);
		}
	}
}
