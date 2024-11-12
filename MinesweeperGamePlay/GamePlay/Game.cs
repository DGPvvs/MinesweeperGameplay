namespace MinesweeperGamePlay.GamePlay
{
	using MinesweeperGamePlay.GameEngine.Contracts;
	using MinesweeperGamePlay.GamePlay.Contracts;

	public class Game : IGame
	{
		private IEngine engine;

		public Game(IEngine engine)
		{
			this.Init(engine);
		}

		public void Init(IEngine engine)
		{
			this.engine = engine;
		}

		public void Run()
		{
			this.engine.Loop();
		}
	}
}
