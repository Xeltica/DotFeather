using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DotFeather.Demo
{
	[DemoScene("/sample4")]
	[Description("en", @"Simple Text Editor")]
	[Description("ja", @"簡易テキストエディタ")]
	public class TextEditorScene : Scene
	{
		public override void OnStart(Dictionary<string, object> args)
		{
			Print("DotFeather Text Editor");
			Print("Press [ESC] to exit");

			editorView = new TextElement("", DFFont.GetDefault(16), Color.White) { Location = (8, 64) };
			Root.Add(editorView);

			// flush text buffer
			DFKeyboard.GetString();
		}

		public override void OnUpdate()
		{
			editorView!.Text = buf.ToString() + '_';
			if ((DFKeyboard.BackSpace.ElapsedFrameCount == 1 || DFKeyboard.BackSpace.ElapsedTime > 0.5f && DFKeyboard.BackSpace.ElapsedFrameCount % 3 == 0) && buf.Length > 0) buf.Length--;
			if (DFKeyboard.Enter.ElapsedFrameCount == 1 || DFKeyboard.Enter.ElapsedTime > 0.5f && DFKeyboard.Enter.ElapsedFrameCount % 3 == 0) buf.Append('\n');

			if (DFKeyboard.HasChar()) buf.Append(DFKeyboard.GetString());

			if (DFKeyboard.Escape.IsKeyUp)
				Router.ChangeScene<LauncherScene>();
		}

		private readonly StringBuilder buf = new();
		private TextElement? editorView;
	}
}
