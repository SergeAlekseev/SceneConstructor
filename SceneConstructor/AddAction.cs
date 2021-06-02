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
	public partial class AddAction : Form
	{
		ActionType actionType;
		Using usingM;
		ActionU action;
		int yPos = 50;
		bool edit;

		public AddAction(ActionType actionType, Using usingM, string name)
		{
			InitializeComponent();
			this.actionType = actionType;
			this.usingM = usingM;
			action = new ActionU();
			action.action = actionType.name;
			action.name = name;
			constrList(this, actionType.fields, action.fields);

		}


		public void constrList(AddAction addAction, List<Ent> list, Dictionary<string, object> fields)
		{
			foreach (Ent ent in list)
			{
				if (ent.Type == "Number")
				{
					Label label = new Label();
					label.Location = new Point(12, yPos);
					yPos += 25;
					label.Text = ent.Name;
					TextBox textBox = new TextBox();
					textBox.Location = new Point(12, yPos);
					yPos += 35;

					textBox.Text = "0";
					textBox.KeyPress += KeyPressNumber;
					textBox.TextChanged += TextChangedNumber;
					fields.Add(ent.Name, 0);


					textBox.TextChanged += (s, e) =>
					{
						double value;
						Double.TryParse((s as TextBox).Text, out value);
						fields[ent.Name] = value;
					};

					this.Controls.Add(label);
					this.Controls.Add(textBox);

				}
				else if (ent.Type == "Text")
				{
					Label label = new Label();
					label.Location = new Point(12, yPos);
					yPos += 25;
					label.Text = ent.Name;
					TextBox textBox = new TextBox();
					textBox.Location = new Point(12, yPos);
					yPos += 35;
					fields.Add(ent.Name, "");

					textBox.TextChanged += (s, e) =>
					{
						fields[ent.Name] = (s as TextBox).Text;
					};

					this.Controls.Add(label);
					this.Controls.Add(textBox);
				}

			}
		}

		private void KeyPressNumber(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((!Char.IsDigit(number) && number != 8 && number != 44) || ((sender as TextBox).Text.Contains(",") && number == 44))
			{
				e.Handled = true;
			}
		}

		private void TextChangedNumber(object sender, EventArgs e)
		{
			if ((sender as TextBox).Text == "")
				(sender as TextBox).Text = "0";
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			if (!edit) 
			{
				usingM.actions.Add(action);
				this.Close();
			}
		}
	}
}
