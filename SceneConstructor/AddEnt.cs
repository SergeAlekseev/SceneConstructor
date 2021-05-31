using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class AddEnt : Form
	{

		public Ent ent;
		public ActionType actionType;
		public Ent parentEnt;
		public bool edit = false;

		public AddEnt(ActionType actionType)
		{
			InitializeComponent();
			this.actionType = actionType;
			this.ent = new Ent();
			initLB();
		}

		public AddEnt(Ent parentEnt)
		{
			InitializeComponent();
			this.parentEnt = parentEnt;
			this.ent = new Ent();
			initLB();
		}

		public AddEnt(ActionType actionType, Ent ent)
		{
			InitializeComponent();
			this.actionType = actionType;
			initEdit(ent);
		}

		public AddEnt(Ent parentEnt, Ent ent)
		{
			InitializeComponent();
			this.parentEnt = parentEnt;
			initEdit(ent);
		}

		private void initEdit(Ent ent)
		{
			this.ent = ent;
			tb.Text = ent.Name;
			gbTypeScene.Enabled = false;
			if (ent.Type == "Text")
				radioButton2.Checked = true;
			else if (ent.Type == "ListObject")
				radioButton3.Checked = true;
			edit = true;
			initLB();
		}

		private void initLB()
		{
			lbEnt.DataSource = ent.ents;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				lbEnt.Enabled = true;
				bAdd.Enabled = true;
				bEdit.Enabled = true;
				bDelete.Enabled = true;
			}
			else
			{
				lbEnt.Enabled = false;
				bAdd.Enabled = false;
				bEdit.Enabled = false;
				bDelete.Enabled = false;
			}
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			AddEnt newForm = new AddEnt(ent);
			initNewEnt(newForm);
		}

		private void bEdit_Click(object sender, EventArgs e)
		{
			if (lbEnt.SelectedItem != null)
			{
				AddEnt newForm = new AddEnt(ent, lbEnt.SelectedItem as Ent);
				initNewEnt(newForm);
			}
		}

		private void initNewEnt(AddEnt newForm)
		{
			ent.Name = tb.Text;
			newForm.FormClosed += NewForm_FormClosed;
			newForm.Text = "AddEnt to " + ent.Name;
			newForm.Owner = this;
			newForm.ShowDialog();
		}

		private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			lbEnt.DataSource = null;
			initLB();
		}



		private void bDelete_Click(object sender, EventArgs e)
		{
			if (parentEnt != null)
				parentEnt.ents.Remove(lbEnt.SelectedItem as Ent);
			else
				actionType.fields.Remove(lbEnt.SelectedItem as Ent);
			NewForm_FormClosed(null, null);

		}

		private void bSave_Click(object sender, EventArgs e)
		{
			if (tb.Text != "")
			{
				ent.Name = tb.Text;
				if (radioButton1.Checked)
				{
					ent.Type = "Number";
					ent.ents = null;
				}
				else if (radioButton2.Checked)
				{
					ent.Type = "Text";
					ent.ents = null;
				}
				else if (radioButton3.Checked)
					ent.Type = "ListObject";
				else 
				{
					ent.Type = "Position";
					ent.ents = null;
				}
				if (!edit)
					if (parentEnt != null)
						parentEnt.ents.Add(ent);
					else
						actionType.fields.Add(ent);
				this.Close();
			}
			else MessageBox.Show("No name");

		}
	}
}
