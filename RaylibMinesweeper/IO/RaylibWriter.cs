namespace RaylibMinesweeper.IO
{
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.Enums;
	using MinesweeperGamePlay.FieldsStructure;
	using MinesweeperGamePlay.FieldsStructure.Contracts;
	using MinesweeperGamePlay.IO.Contracts;
	using MinesweeperGamePlay.TransferObject.Contracts;
	using Raylib_cs;
	using RaylibMinesweeper.Common;
	using RaylibMinesweeper.picture;
	using System.Text;
	using static Raylib_cs.Raylib;

	public class RaylibWriter : RaylibReader, IWriter
	{
		private readonly Dictionary<FieldSymbol, BasePicture> pictureImages;
		private readonly BasePicture mark;
		private readonly BasePicture start;

		public RaylibWriter() : base()
		{
			this.pictureImages = new Dictionary<FieldSymbol, BasePicture>();
			StringBuilder projectDirectory = new StringBuilder();

			this.pictureImages.Add(FieldSymbol.One, new OnePicture());
			this.pictureImages.Add(FieldSymbol.Two, new TwoPicture());
			this.pictureImages.Add(FieldSymbol.Three, new ThreePicture());
			this.pictureImages.Add(FieldSymbol.Four, new FourPicture());
			this.pictureImages.Add(FieldSymbol.Five, new FivePicture());
			this.pictureImages.Add(FieldSymbol.Six, new SixPicture());
			this.pictureImages.Add(FieldSymbol.Seven, new SevenPicture());
			this.pictureImages.Add(FieldSymbol.Eight, new EightPicture());
			this.pictureImages.Add(FieldSymbol.Mine, new MinePicture());
			this.mark = new MarkPicture();
			this.start = new StartPicture();
		}

		public void WriteOutput(IWriteTransferObject wTO)
		{
			return;
		}

		public void WriteLineOutput(IWriteTransferObject wTO)
		{
			if (wTO.Status == GameStatus.Started)
			{
				this.start.Draw(0, 0);
			}
			else if (wTO.Status == GameStatus.InProgress)
			{
				this.WriteLine(wTO.Area);
			}
		}

		public void Clear()
		{
			ClearBackground(Color.Gray);
		}

		private void WriteLine(string s)
		{
			return;
		}


		private void WriteLine(IArea area)
		{
			for (int row = 0; row < area.MaxX; row++)
			{
				for (int coll = 0; coll < area.MaxY; coll++)
				{
					if (!(area[row, coll] as VisibleField).IsVisible)
					{
						if ((area[row, coll] as MarkedField)!.IsMarked)
						{
							this.mark.Draw(row, coll);
						}
						else
						{
							DrawRectangle(coll * PublicConstant.CELL_SIZE,
								  row * PublicConstant.CELL_SIZE,
								  PublicConstant.CELL_SIZE - 1,
								  PublicConstant.CELL_SIZE - 1,
								  Color.DarkBlue);
						}
					}
					else
					{
						this.DrawElement(area[row, coll]);
					}
				}
			}
		}

		private void DrawElement(IField field)
		{
			FieldSymbol key = (field as ValueField).Value;
			if (this.pictureImages.ContainsKey(key))
			{
				this.pictureImages[key].Draw(field.X, field.Y);
			}
		}
	}
}
