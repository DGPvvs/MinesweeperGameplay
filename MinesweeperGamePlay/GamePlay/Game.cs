namespace MinesweeperGamePlay.GamePlay
{
	using MinesweeperGamePlay.AreaStructure;
	using MinesweeperGamePlay.AreaStructure.Contracts;
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.GamePlay.Contracts;

	public class Game : IGame
	{
		private IEngine engine;
		private IArea area;

		public Game(IEngine engine, int x, int y)
		{
			this.Init(engine);
			this.InitArea(x, y);
		}

		public void Init(IEngine engine)
		{
			this.engine = engine;
		}

		public void InitArea(int x, int y)
		{
			this.area = new Area(x, y);
		}

		public void Run()
		{
			this.engine.Loop(this.area);
		}
	}
}
