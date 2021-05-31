using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class AddModel : Form
	{
		ModelScene modelScene;
		Marker marker;
		bool edit;
		string oldName;


		public AddModel(Marker marker)
		{
			InitializeComponent();
			this.marker = marker;
			modelScene = new ModelScene();
			openFileDialog1.Filter = "Model file(*.glb)|*.glb";
		}

		public AddModel(ModelScene modelScene)
		{
			InitializeComponent();
			this.modelScene = modelScene;
			edit = true;
			oldName = modelScene.id;
			tbTitle.Text = modelScene.id;
			tbx2.Text = "" + modelScene.markerOffset.x;
			tby2.Text = "" + modelScene.markerOffset.y;
			tbz2.Text = "" + modelScene.markerOffset.z;
			tbx1.Text = "" + modelScene.position.x;
			tby1.Text = "" + modelScene.position.y;
			tbz2.Text = "" + modelScene.position.z;
			tbSize.Text = "" + modelScene.size.x;
			tbSubtitle.Text = modelScene.model.subtitle;
			tbSubtitle.Text = modelScene.model.desc;
			textBox2.Text = modelScene.id + ".glb";
			openFileDialog1.Filter = "Model file(*.glb)|*.glb";
		}

		private void bSelectModel_Click(object sender, EventArgs e)
		{

			if (tbTitle.Text != "")
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					saveFile();
				}
				else
					return;
			else MessageBox.Show("Write name please");
		}

		private void saveFile()
		{
			modelScene.id = tbTitle.Text;
			var str = openFileDialog1.FileName.Split(new[] { '\\' }).Last();
			Directory.CreateDirectory(Environment.CurrentDirectory + "\\resources\\models");
			File.Copy(openFileDialog1.FileName, Path.Combine(Environment.CurrentDirectory + "\\resources\\models\\" + modelScene.id + ".glb"), true);
			string filename = str;
			textBox2.Text = filename;
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			if (tbTitle.Text != "")
			{
				if (textBox2.Text != "")
				{
					modelScene.id = tbTitle.Text;
					modelScene.model.title = tbTitle.Text;
					Double.TryParse(tbx2.Text, out modelScene.markerOffset.x);
					Double.TryParse(tby2.Text, out modelScene.markerOffset.y);
					Double.TryParse(tbz2.Text, out modelScene.markerOffset.z);
					Double.TryParse(tbx1.Text, out modelScene.position.x);
					Double.TryParse(tby1.Text, out modelScene.position.y);
					Double.TryParse(tbz2.Text, out modelScene.position.z);
					double size;
					Double.TryParse(tbSize.Text, out size);
					modelScene.size.x = size;
					modelScene.size.y = size;
					modelScene.size.z = size;
					modelScene.model.subtitle = tbSubtitle.Text;
					modelScene.model.desc = tbSubtitle.Text;
					if (!edit)
						marker.models.Add(modelScene);
					if (openFileDialog1.FileName != "")
						saveFile();
					else if (oldName != modelScene.id)
					{
						File.Move(Environment.CurrentDirectory + "\\resources\\models\\" + oldName + ".glb",
							Environment.CurrentDirectory + "\\resources\\models\\" + modelScene.id + ".glb");
						File.Move(Environment.CurrentDirectory + "\\resources\\models\\" + oldName + ".json",
							Environment.CurrentDirectory + "\\resources\\models\\" + modelScene.id + ".json");
					}
					this.Close();
				}
				else MessageBox.Show("No model file");
			}
			else MessageBox.Show("No name");
		}

		private void tbx1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((!Char.IsDigit(number) && number != 8 && number != 44) || ((sender as TextBox).Text.Contains(",") && number == 44))
			{
				e.Handled = true;
			}
		}

		private void AddModel_TextChanged(object sender, EventArgs e)
		{
			if ((sender as TextBox).Text == "")
				(sender as TextBox).Text = "0";
		}
	}
}
