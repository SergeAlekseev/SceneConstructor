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
	public partial class AddUsing : Form
	{
		private ModelScene modelScene;
		private Using usingModel;
		bool edit;

		public AddUsing(ModelScene modelScene)
		{
			InitializeComponent();
			usingModel = new Using();
			this.modelScene = modelScene;
		}

		public AddUsing(Using usingModel)
		{
			InitializeComponent();
			this.usingModel = usingModel;
			edit = true;
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			if (tb.Text != "")
			{
				usingModel.id = tb.Text;
				Double.TryParse(tbx3.Text, out usingModel.PositionLine.x);
				Double.TryParse(tby3.Text, out usingModel.PositionLine.y);
				Double.TryParse(tbz3.Text, out usingModel.PositionLine.z);
				Double.TryParse(tbx2.Text, out usingModel.PositionAfter.x);
				Double.TryParse(tby2.Text, out usingModel.PositionAfter.y);
				Double.TryParse(tbz2.Text, out usingModel.PositionAfter.z);
				Double.TryParse(tbx1.Text, out usingModel.Position.x);
				Double.TryParse(tby1.Text, out usingModel.Position.y);
				Double.TryParse(tbz2.Text, out usingModel.Position.z);
				if (!edit)
					modelScene.model.anchors.Add(usingModel);
				this.Close();
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

		private void tbx1_TextChanged(object sender, EventArgs e)
		{
			if ((sender as TextBox).Text == "")
				(sender as TextBox).Text = "0";
		}
	}
}
