using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
			openFileDialog1.Filter = "JSON files(*.json)|*.json";
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


	}
}
