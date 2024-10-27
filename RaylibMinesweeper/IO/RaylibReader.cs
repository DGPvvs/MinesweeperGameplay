namespace RaylibMinesweeper.IO
{
	using MinesweeperGamePlay.IO.Contracts;
	using Raylib_cs;
	using RaylibMinesweeper.Common;
	using System.Numerics;

	using static Raylib_cs.Raylib;

	public class RaylibReader : IReader
	{
		public RaylibReader()
		{

		}

		public object ReadInput() => this.ReadLine() as object;

		public void Free()
		{
			
		}

		private string ReadLine()
		{
			Vector2 position = GetMousePosition();

			if (IsMouseButtonPressed(MouseButton.Left))
			{
				return $"{position.Y},{position.X}";
			}

			return PublicConstant.NOT_PRESS;
		}
	}
}
