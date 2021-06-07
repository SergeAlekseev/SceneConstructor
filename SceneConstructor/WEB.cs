using CefSharp.WinForms;
using CefSharp;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class WEB : Form
	{

		public WEB(string v)
		{
			InitializeComponent();
			ChromiumWebBrowser chromiumWebBrowser1 = new ChromiumWebBrowser(v)
			{
				Dock = DockStyle.Fill
			};
			Controls.Add(chromiumWebBrowser1);

		}
	}
}
