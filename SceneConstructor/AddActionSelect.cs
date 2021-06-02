using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class AddActionSelect : Form
	{
		Using usingM;
		public AddActionSelect(Using usingM, Scene scene)
		{
			InitializeComponent();
			this.usingM = usingM;
			lbActions.DataSource = scene.actionTypes;
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			if (tb.Text != "")
			{
				if (lbActions.SelectedItem != null)
				{
				
					AddAction newForm = new AddAction(lbActions.SelectedItem as ActionType, usingM, tb.Text);
					newForm.Owner = this;
					this.Hide();
					newForm.ShowDialog();
					this.Close();
				}
				else MessageBox.Show("No select action");
			}
			else MessageBox.Show("No name");
		}
	}
}
