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
		WEB web;
		string tbx2Text;
		string tby2Text;
		string tbz2Text;
		string tbx1Text;
		string tby1Text; 
		string tbz1Text; 
		string tbSizeText;


		public AddModel(Marker marker)
		{
			InitializeComponent();
			this.marker = marker;
			modelScene = new ModelScene();
			openFileDialog1.Filter = "Model file(*.glb)|*.glb";
		}

		public AddModel(ModelScene modelScene, WEB web)
		{
			InitializeComponent();
			this.modelScene = modelScene;
			edit = true;
			oldName = modelScene.id;
			tbTitle.Text = modelScene.id;
			tbDesc.Text = modelScene.model.desc;
			tbSubtitle.Text = modelScene.model.subtitle;
			tbx2.Text = "" + modelScene.markerOffset.x;
			tby2.Text = "" + modelScene.markerOffset.y;
			tbz2.Text = "" + modelScene.markerOffset.z;
			tbx1.Text = "" + modelScene.position.x;
			tby1.Text = "" + modelScene.position.y;
			tbz1.Text = "" + modelScene.position.z;
			tbSize.Text = "" + modelScene.size.x;
			tbx2Text = "" + modelScene.markerOffset.x;
			tby2Text= "" + modelScene.markerOffset.y;
			tbz2Text= "" + modelScene.markerOffset.z;
			tbx1Text= "" + modelScene.position.x;
			tby1Text= "" + modelScene.position.y;
			tbz1Text = "" + modelScene.position.z;
			tbSizeText = "" + modelScene.size.x;
			textBox2.Text = modelScene.id + ".glb";
			openFileDialog1.Filter = "Model file(*.glb)|*.glb";

			this.web = web;
			if (web != null) 
			{
				if (modelScene.GUID == "")
					modelScene.GUID = Guid.NewGuid().ToString();
				tbx1.TextChanged += Position_TextChanged;
				tby1.TextChanged += Position_TextChanged;
				tbz1.TextChanged += Position_TextChanged;
				tbSize.TextChanged += Size_TextChanged;
			}
		}

		private void Size_TextChanged(object sender, EventArgs e)
		{
			double size;
			Double.TryParse(tbSize.Text, out size);
			modelScene.size.x = size;
			modelScene.size.y = size;
			modelScene.size.z = size;
			string number = modelScene.size.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			web.executeScriptParam(modelScene.GUID, "scale", "" + modelScene.size.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + modelScene.size.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + modelScene.size.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")));
		}

		private void Position_TextChanged(object sender, EventArgs e)
		{
			Double.TryParse(tbx1.Text, out modelScene.position.x);
			Double.TryParse(tby1.Text, out modelScene.position.y);
			Double.TryParse(tbz1.Text, out modelScene.position.z);
			web.executeScriptParam(modelScene.GUID, "position", "" + modelScene.position.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " "+ modelScene.position.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + modelScene.position.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")));
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
					Double.TryParse(tbz1.Text, out modelScene.position.z);
					double size;
					Double.TryParse(tbSize.Text, out size);
					modelScene.size.x = size;
					modelScene.size.y = size;
					modelScene.size.z = size;
					modelScene.model.subtitle = tbSubtitle.Text;
					modelScene.model.desc = tbDesc.Text;
					if (!edit)
						marker.models.Add(modelScene);
					if (openFileDialog1.FileName != "openFileDialog1")
						saveFile();
					else if (oldName != modelScene.id)
					{
						File.Move(Environment.CurrentDirectory + "\\resources\\models\\" + oldName + ".glb",
							Environment.CurrentDirectory + "\\resources\\models\\" + modelScene.id + ".glb");
						try
						{
							File.Move(Environment.CurrentDirectory + "\\resources\\models\\" + oldName + ".json",
								Environment.CurrentDirectory + "\\resources\\models\\" + modelScene.id + ".json");
						}
						catch { }
					}
					this.Close();
				}
				else MessageBox.Show("No model file");
			}
			else MessageBox.Show("No name");
		}

		private void tbx1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (((TextBox)sender).Text.Contains('-'))
			{
				if (!((Char.IsDigit(e.KeyChar) && ((TextBox)sender).SelectionStart > 0) || e.KeyChar == (char)Keys.Back || (!(sender as TextBox).Text.Contains(",") && e.KeyChar == ',')))
					e.Handled = true;
			}
			else if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0) || (!(sender as TextBox).Text.Contains(",") && e.KeyChar == ','))  )
				e.Handled = true;
		}

		private void AddModel_TextChanged(object sender, EventArgs e)
		{
			if ((sender as TextBox).Text == "")
				(sender as TextBox).Text = "0";
		}

		private void tbp1_ValueChanged(object sender, EventArgs e)
		{
			tbx1Text = (Double.Parse(tbx1.Text) + tbp1.Value * 0.05).ToString();
		}

		private void tbp2_ValueChanged(object sender, EventArgs e)
		{
			tby1Text = (Double.Parse(tby1.Text) + tbp2.Value * 0.05).ToString();
		}

		private void tbp3_ValueChanged(object sender, EventArgs e)
		{
			tbz1Text = (Double.Parse(tbz1.Text) + tbp3.Value * 0.05).ToString();
		}

		private void tbpm1_ValueChanged(object sender, EventArgs e)
		{
			tbx2Text = (Double.Parse(tbx2.Text) + tbpm1.Value * 0.05).ToString();
		}

		private void tbpm2_ValueChanged(object sender, EventArgs e)
		{
			tby2Text = (Double.Parse(tby2.Text) + tbpm2.Value * 0.05).ToString();
		}

		private void tbpm3_ValueChanged(object sender, EventArgs e)
		{
			tbz2Text = (Double.Parse(tbz2.Text) + tbpm3.Value * 0.05).ToString();
		}
		private void tbs_ValueChanged(object sender, EventArgs e)
		{
			tbSizeText = (Double.Parse(tbSize.Text) + tbs.Value * 0.05).ToString();
		}

		private void tbp1_MouseUp(object sender, MouseEventArgs e)
		{
			tbx1.Text = tbx1Text;
			tbp1.Value = 0;
		}

		private void tbp2_MouseUp(object sender, MouseEventArgs e)
		{
			tby1.Text = tby1Text;
			tbp2.Value = 0;
		}

		private void tbp3_MouseUp(object sender, MouseEventArgs e)
		{
			tbz1.Text = tbz1Text;
			tbp3.Value = 0;
		}

		private void tbpm1_MouseUp(object sender, MouseEventArgs e)
		{
			tbx2.Text = tbx2Text;
			tbpm1.Value = 0;
		}

		private void tbpm2_MouseUp(object sender, MouseEventArgs e)
		{
			tby2.Text = tby2Text;
			tbpm2.Value = 0;
		}

		private void tbpm3_MouseUp(object sender, MouseEventArgs e)
		{
			tbz2.Text = tbz2Text;
			tbpm3.Value = 0;
		}

		private void tbs_MouseUp(object sender, MouseEventArgs e)
		{
			tbSize.Text = tbSizeText;
			tbs.Value = 0;
		}

	}
}
