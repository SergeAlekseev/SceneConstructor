using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class CreateScene : Form
	{
		public Scene scene = new Scene();

		public CreateScene()
		{
			InitializeComponent();
			lbActions.DataSource = scene.actionTypes;
			lbActions.DisplayMember = "name";
		}

		private void bSelectJS_Click(object sender, EventArgs e)
		{
			AddJS newForm = new AddJS(scene);
			newForm.FormClosed += NewForm_FormClosed;
			newForm.Owner = this;
			newForm.ShowDialog();
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			if (lbActions.SelectedItem != null)
			{
				AddJS newForm = new AddJS(scene, lbActions.SelectedItem as ActionType);
				newForm.FormClosed += NewForm_FormClosed;
				newForm.Owner = this;
				newForm.ShowDialog();
			}
		}

		private void bDelete_Click(object sender, EventArgs e)
		{
			(lbActions.DataSource as List<ActionType>).Remove(lbActions.SelectedItem as ActionType);
			scene.saveActionTypes();
			NewForm_FormClosed(null, null);
		}

		private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			lbActions.DataSource = null;
			lbActions.DataSource = scene.actionTypes;
			lbActions.DisplayMember = "name";
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			if (tb.Text != "")
			{
				scene.title = textBox2.Text;
				scene.subtitle = textBox1.Text;
				scene.name = tb.Text;
				string output = JsonConvert.SerializeObject(scene);
				Directory.CreateDirectory(Environment.CurrentDirectory + "\\scenes");
				StreamWriter file = File.CreateText(Environment.CurrentDirectory + "\\scenes" + "\\" + scene.name + ".json");
				file.Write(output);
				file.Close();

				EditorScene newForm = new EditorScene(scene);
				newForm.Owner = Owner;
				Close();
				newForm.Show();
			}
			else MessageBox.Show("No name");
		}





		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
				scene.typeMarkers = "PATTERN";
			else if (radioButton2.Checked)
				scene.typeMarkers = "IMAGE";
			else
				scene.typeMarkers = "NOTMARKER";
		}

		private void CreateScene_FormClosing(object sender, FormClosingEventArgs e)
		{
			Owner.Show();
		}

		private void CreateScene_Load(object sender, EventArgs e)
		{

		}
	}
}
