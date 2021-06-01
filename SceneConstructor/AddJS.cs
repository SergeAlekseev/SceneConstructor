using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class AddJS : Form
	{

		public ActionType actionType;
		private Scene scene;
		bool edit;
		string oldName = "";


		public AddJS(Scene scene)
		{
			InitializeComponent();
			this.scene = scene;
			openFileDialog1.Filter = "Script files(*.js)|*.js";
			actionType = new ActionType();
			lbInit();
		}

		public AddJS(Scene scene, ActionType actionType)
		{
			InitializeComponent();
			oldName = actionType.name;
			this.scene = scene;
			edit = true;
			openFileDialog1.Filter = "Script files(*.js)|*.js";
			tb.Text = actionType.name;
			textBox1.Text = actionType.name + ".js";
			this.actionType = actionType;
			lbInit();
		}

		private void lbInit()
		{
			lbEnt.DataSource = actionType.fields;
		}

		private void bSelectModel_Click(object sender, EventArgs e)
		{
			actionType.name = tb.Text;
			if (actionType.name != "")
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
			var str = openFileDialog1.FileName.Split(new[] { '\\' }).Last();
			Directory.CreateDirectory(Environment.CurrentDirectory + "\\resources\\components\\actions");
			File.Copy(openFileDialog1.FileName, Path.Combine(Environment.CurrentDirectory + "\\resources\\components\\actions\\" + actionType.name + ".js"), true);
			textBox1.Text = str;
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			AddEnt newForm = new AddEnt(actionType);
			newForm.Owner = this;
			newForm.FormClosed += NewForm_FormClosed;
			newForm.ShowDialog();
		}

		private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			lbEnt.DataSource = null;
			lbInit();
		}

		private void AddJS_Load(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			AddEnt newForm = new AddEnt(actionType, lbEnt.SelectedItem as Ent);
			newForm.Owner = this;
			newForm.FormClosed += NewForm_FormClosed;
			newForm.ShowDialog();
		}

		private void bDelete_Click(object sender, EventArgs e)
		{
			actionType.fields.Remove(lbEnt.SelectedItem as Ent);
			NewForm_FormClosed(null, null);
		}

		private void bSelectJS_Click(object sender, EventArgs e)
		{
			if (tb.Text != "")
			{
				if (textBox1.Text != "")
				{
					actionType.name = tb.Text;
					if (!edit)
						scene.actionTypes.Add(actionType);
					if (openFileDialog1.FileName != "openFileDialog1")
						saveFile();
					else if (oldName != actionType.name)
					{
						File.Move(Environment.CurrentDirectory + "\\resources\\components\\actions\\" + oldName + ".js",
							Environment.CurrentDirectory + "\\resources\\components\\actions\\" + actionType.name + ".js");
					}
					scene.saveActionTypes();
					this.Close();
				}
				else MessageBox.Show("No script");
			}
			else MessageBox.Show("No name");
		}
	}
}
