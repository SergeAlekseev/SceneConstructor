using CefSharp.WinForms;
using CefSharp;
using System.Windows.Forms;
using System;

namespace SceneConstructor
{
	public partial class WEB : Form
	{
		public ChromiumWebBrowser chromiumWebBrowser1;
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

		public void executeScriptParam(string GUID, string param, string value)
		{
			chromiumWebBrowser1.ExecuteScriptAsync("(function () {document.getElementById('"+GUID+"').setAttribute('" + param + "', '" + value + "')})();");
		}

		public void executeScript(string script)
		{
			chromiumWebBrowser1.ExecuteScriptAsync("(function () { " + script + "})();");
		}

		private void WEB_Load(object sender, EventArgs e)
		{
		}
	}
}
