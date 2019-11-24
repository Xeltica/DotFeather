namespace DotFeather.Demo
{
	static class Entry
	{
		static void Main(string[] args)
		{
			// この行は実際に使うときには無視してください
			// Please ignore this line when you actually use.
			DemoOS.Init();

			// ゲームを初期化して実行します
			// Initialize and run the game
			using (var g = new RoutingGameBase<LauncherScene>(640, 480, followsDpi: true))
			{
				g.WindowMode = WindowMode.Resizable;

				g.Run();
			}
		}
	}
}
