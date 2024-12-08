namespace RaylibMinesweeper.IO
{
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using Raylib_cs;
	using System.Numerics;

	using static Raylib_cs.Raylib;

	public class RaylibReader : IReader
	{
		public RaylibReader()
		{

		}

		public ITransfer ReadInput() => this.ReadLine();

		public void Free()
		{
			
		}

		private ITransfer ReadLine()
		{
			Vector2 position = GetMousePosition();

			if (IsMouseButtonPressed(MouseButton.Left))
			{
				return new Transfer((int)position.Y, (int)position.X, FieldSymbol.Open);
			}

			if (IsMouseButtonPressed(MouseButton.Right))
			{
				return new Transfer((int)position.Y, (int)position.X, FieldSymbol.Mark);
			}

            if (IsKeyPressed(KeyboardKey.Space))
            {
				return new Transfer(-1, -1, FieldSymbol.Space);
            }

            return new Transfer(-1, -1, FieldSymbol.Noting);
		}
	}
}
