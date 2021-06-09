using CefSharp.WinForms;
using CefSharp;
using System.Windows.Forms;
using System;

namespace SceneConstructor
{
	public partial class WEB : Form
	{
		ChromiumWebBrowser chromiumWebBrowser1;
		string v;
		public WEB(string v)
		{
			InitializeComponent();
			this.v = v;
			chromiumWebBrowser1 = new ChromiumWebBrowser(v)
			{
				Dock = DockStyle.Fill
			};
			Controls.Add(chromiumWebBrowser1);

		}

		internal void refreshPage()
		{
			chromiumWebBrowser1.Reload();
		}

		private void WEB_Load(object sender, EventArgs e)
		{

		}
	}
}
