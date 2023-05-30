using FluentFTP;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
			openFileDialog1.Filter = "JSON files(*.json)|*.json";

			FtpClient client = new FtpClient("45.93.200.175");

			client.Credentials = new NetworkCredential("web3159", "4M6q5H5d2O");

			client.Connect();

			client.DownloadFile(Environment.CurrentDirectory + "\\resources\\vr.html", @"/www/web3159.craft-host.ru/resources/vr.html", FtpLocalExists.Overwrite);
			client.DownloadFile(Environment.CurrentDirectory + "\\resources\\ar.html", @"/www/web3159.craft-host.ru/resources/ar.html", FtpLocalExists.Overwrite);
		}

		private void bCreate_Click(object sender, EventArgs e)
		{
			Hide();
			CreateScene newForm = new CreateScene();
			newForm.Owner = this;
			newForm.ShowDialog();
		}

		private void bOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filename = openFileDialog1.FileName;
				try
				{
					Scene scene = Scene.openScene(filename);

					EditorScene newForm = new EditorScene(scene);
					newForm.Owner = this;
					Hide();
					newForm.Show();
				}
				catch
				{
					MessageBox.Show("Not scene in file");
				}
			}
			else
				return;
		}

		private void Start_Load(object sender, EventArgs e)
		{

		}
	}
}
