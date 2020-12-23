using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DotFeather
{
	public static class DF
	{
		public static ITextureDrawer TextureDrawer { get; }
		public static IPrimitiveDrawer PrimitiveDrawer { get; }
		public static IWindow Window { get; }
		public static IConsole Console { get; }
		public static Container Root { get; private set; } = new Container();
		public static Router Router { get; }

		public static int Run()
		{
			Window.Run();
			return statusCode;
		}

		public static void Exit(int status = 0)
		{
			statusCode = status;
			Window.Exit();
		}

		public static int RunAsCaptureMode()
		{
			// todo
			return Run();
		}

		public static void NextFrame(Action task)
		{
			nextFrameQueue.Add(task);
		}

		static DF()
		{
			ctx = new DFSynchronizationContext();
			SynchronizationContext.SetSynchronizationContext(ctx);


			// Add Plugins
			TextureDrawer = new Internal.DesktopTextureDrawer();
			PrimitiveDrawer = new Internal.DesktopPrimitiveDrawer();

			Window = new Internal.DesktopWindow();

			Console = new Internal.DFConsole();
			Router = new Router();

			Window.Update += () =>
			{
				ctx.Update();

				if (nextFrameQueue.Count == 0) return;
				nextFrameQueue.ToList().ForEach(task =>
				{
					task();
					nextFrameQueue.Remove(task);
				});
			};
		}

		private static readonly List<Action> nextFrameQueue = new();
		private static readonly DFSynchronizationContext ctx;
		private static int statusCode;
	}
}