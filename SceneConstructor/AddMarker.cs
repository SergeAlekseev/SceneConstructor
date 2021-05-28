﻿using System;
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
	public partial class AddMarker : Form
	{
		Scene scene;
		Marker marker;
		bool edit;

		public AddMarker(Scene scene)
		{
			InitializeComponent();
			marker = new Marker();
			init(scene, marker);
		}

		public AddMarker(Scene scene, Marker marker)
		{
			InitializeComponent();
			this.marker = marker;
			tb.Text = marker.Name;
			edit = true;
			init(scene, marker);
		}

		private void init(Scene scene, Marker marker)
		{
			this.scene = scene;

			if (scene.TypeMarkers == "IMAGE")
			{
				groupBox1.Enabled = false;
				radioButton1.Checked = true;
			}
			else
			{
				button3.Enabled = false;
				button2.Enabled = false;
				button1.Enabled = false;
				textBox1.Text = marker.GUID;
				textBox2.Text = marker.GUID;
				textBox3.Text = marker.GUID;
			};
			if (marker.MarkerType == "PATTERN")
			{
				radioButton2.Checked = true;
				button1.Enabled = false;
				textBox1.Text = marker.GUID;
			}
		}

		private void bSelectJS_Click(object sender, EventArgs e)
		{
			if (tb.Text != "")
			{
				if (scene.TypeMarkers == "IMAGE" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""
					|| scene.TypeMarkers == "PATTERN" && textBox1.Text != ""
					|| scene.TypeMarkers == "PATTERN" && marker.MarkerType == "HIRO")
				{
					marker.Name = tb.Text;
					if (!edit)
						scene.Markers.Add(marker);
					this.Close();
				}
				else MessageBox.Show("No marker files");
			}
			else MessageBox.Show("No name");
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				button1.Enabled = true;
				label1.Text = ".patt";
				openFileDialog1.Filter = "(*.patt)|*.patt";
				marker.MarkerType = "PATTERN";


			}
			else if (radioButton1.Checked)
			{
				marker.MarkerType = "IMAGE";

				button3.Enabled = true;
				label3.Text = ".iset";
				openFileDialog3.Filter = "(*.iset)|*.iset";


				button2.Enabled = true;
				label2.Text = ".fset3";
				openFileDialog2.Filter = "(*.fset3)|*.fset3";


				button1.Enabled = true;
				label1.Text = ".fset";
				openFileDialog1.Filter = "(*.fset)|*.fset";

			}
			else if (radioButton3.Checked)
			{
				marker.MarkerType = "HIRO";

				button3.Enabled = false;
				button2.Enabled = false;
				button1.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			saveFileMetk(openFileDialog1, textBox1);
		}

		

		private void button2_Click(object sender, EventArgs e)
		{
			saveFileMetk(openFileDialog2, textBox2);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			saveFileMetk(openFileDialog3, textBox3);
		}

		private void saveFileMetk(OpenFileDialog openFileDialog, TextBox textBox)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				var format = openFileDialog.FileName.Split(new[] { '.' }).Last();
				if (marker.GUID == "")
					marker.GUID = Guid.NewGuid().ToString();
				Directory.CreateDirectory(Environment.CurrentDirectory + "\\" + scene.Name + "\\Markers\\" + marker.GUID);
				File.Copy(openFileDialog.FileName, Path.Combine(Environment.CurrentDirectory + "\\" + scene.Name + "\\Markers\\" + marker.GUID + "\\" + marker.GUID + "." + format), true);
				textBox.Text = openFileDialog.FileName.Split(new[] { '\\' }).Last();
			}
			else
				return;
		}
	}
}
