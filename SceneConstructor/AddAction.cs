using Newtonsoft.Json.Linq;
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
		bool addList;
		List<Dictionary<string, object>> fieldsList;
		Dictionary<string, object> fieldsEnt;
		private List<Ent> ents;
		private Dictionary<string, object> dictionary;

		public AddAction(ActionType actionType, Using usingM, string name)
		{
			InitializeComponent();
			this.actionType = actionType;
			this.usingM = usingM;
			action = new ActionU();
			action.action = actionType.name;
			action.name = name;
			constrList(actionType.fields, action.fields);

		}

		public AddAction(List<Ent> ents, List<Dictionary<string, object>> fieldsList)
		{
			InitializeComponent();
			fieldsEnt = new Dictionary<string, object>();
			this.fieldsList = fieldsList;
			addList = true;
			constrList(ents, fieldsEnt);
		}

		public AddAction(ActionU actionU, ActionType at)
		{
			InitializeComponent();
			fieldsEnt = new Dictionary<string, object>();
			action = actionU;
			edit = true;
			constrList(at.fields, actionU.fields);
		}

		public AddAction(List<Ent> ents, Dictionary<string, object> dictionary)
		{
			InitializeComponent();
			fieldsEnt = dictionary;
			edit = true;
			addList = true;
			constrList(ents, fieldsEnt);
		}

		public void constrList(List<Ent> list, Dictionary<string, object> fields)
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

					object v;
					fields.TryGetValue(ent.Name, out v);
					if (fields.TryGetValue(ent.Name, out v))
						textBox.Text += (double)v;
					else
					{
						fields.Add(ent.Name, 0);
						textBox.Text = "0";
					}
					textBox.KeyPress += KeyPressNumber;
					textBox.TextChanged += TextChangedNumber;
					textBox.Size = new Size(300, 23);


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
					textBox.Size = new Size(300, 23);

					object v;
					fields.TryGetValue(ent.Name, out v);
					if (fields.TryGetValue(ent.Name, out v))
						textBox.Text = (string)v;
					else
					fields.Add(ent.Name, "");

					textBox.TextChanged += (s, e) =>
					{
						fields[ent.Name] = (s as TextBox).Text;
					};

					this.Controls.Add(label);
					this.Controls.Add(textBox);
				}
				else if (ent.Type == "Position")
				{
					Position pos = new Position();


					Label label = new Label();
					label.Location = new Point(12, yPos);
					yPos += 25;
					label.Text = ent.Name;

					TextBox textBox1 = new TextBox();
					textBox1.Location = new Point(12, yPos);
					textBox1.Text = "0";
					textBox1.KeyPress += KeyPressNumber;
					textBox1.TextChanged += TextChangedNumber;
					textBox1.Size = new Size(80, 23);
					textBox1.TextChanged += (s, e) =>
					{
						double value;
						Double.TryParse((s as TextBox).Text, out value);
						pos.x = value;
					};

					TextBox textBox2 = new TextBox();
					textBox2.Location = new Point(112, yPos);
					textBox2.Text = "0";
					textBox2.KeyPress += KeyPressNumber;
					textBox2.TextChanged += TextChangedNumber;
					textBox2.Size = new Size(80, 23);
					textBox2.TextChanged += (s, e) =>
					{
						double value;
						Double.TryParse((s as TextBox).Text, out value);
						pos.y = value;
					};

					TextBox textBox3 = new TextBox();
					textBox3.Location = new Point(212, yPos);
					textBox3.Text = "0";
					textBox3.KeyPress += KeyPressNumber;
					textBox3.TextChanged += TextChangedNumber;
					textBox3.Size = new Size(80, 23);
					textBox3.TextChanged += (s, e) =>
					{
						double value;
						Double.TryParse((s as TextBox).Text, out value);
						pos.z = value;
					};

					yPos += 35;

					object v;
					fields.TryGetValue(ent.Name, out v);
					if (fields.TryGetValue(ent.Name, out v))
					{
						textBox1.Text = "" + ((JObject)v).GetValue("x");
						textBox2.Text = "" + ((JObject)v).GetValue("y");
						textBox3.Text = "" + ((JObject)v).GetValue("z");
					}
					else
						fields.Add(ent.Name, pos);


					this.Controls.Add(label);
					this.Controls.Add(textBox1);
					this.Controls.Add(textBox2);
					this.Controls.Add(textBox3);


				}
				else if (ent.Type == "ListObject")
				{
					List<Dictionary<string, object>> entList;
					object v;
					fields.TryGetValue(ent.Name, out v);
					if (fields.TryGetValue(ent.Name, out v))
						entList = (v as JArray).ToObject<List<Dictionary<string, object>>>();
					else
					{
						entList = new List<Dictionary<string, object>>();
						fields.Add(ent.Name, entList);
					}

					Label label = new Label();
					label.Location = new Point(12, yPos);
					yPos += 25;
					label.Text = ent.Name;

					ListBox listBox = new ListBox();
					listBox.Location = new Point(12, yPos);
					listBox.DataSource = entList;

					Button bAdd = new Button();
					bAdd.Text = "Добавить";
					bAdd.Location = new Point(142, yPos);
					bAdd.Click += (s, e) =>
					{
						AddAction newForm = new AddAction(ent.ents, entList);
						newForm.Owner = this;
						newForm.FormClosed += (sen, ee) =>
						{
							listBox.DataSource = null;
							listBox.DataSource = entList;
						};
						newForm.ShowDialog();
					};

					yPos += 35;


					Button bEdit = new Button();
					bEdit.Text = "Редактировать";
					bEdit.Location = new Point(142, yPos);
					bEdit.Click += (s, e) =>
					{
						if (listBox.SelectedItem != null)
						{
							AddAction newForm = new AddAction(ent.ents, listBox.SelectedItem as Dictionary<string, object>);
							newForm.Owner = this;
							newForm.FormClosed += (sen, ee) =>
							{
								listBox.DataSource = null;
								listBox.DataSource = entList;
							};
							newForm.ShowDialog();
						}
						else MessageBox.Show("Not select");
					};

					yPos += 35;


					Button bDelete = new Button();
					bDelete.Text = "Удалить";
					bDelete.Location = new Point(142, yPos);
					bDelete.Click += (s, e) =>
					{
						if (listBox.SelectedItem != null)
						{
							entList.Remove(listBox.SelectedItem as Dictionary<string, object>);
						}
						else MessageBox.Show("Not select");
					};

					yPos += 35;


					this.Controls.Add(label);
					this.Controls.Add(listBox);
					this.Controls.Add(bAdd);
					this.Controls.Add(bEdit);
					this.Controls.Add(bDelete);

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
			if (!edit && !addList)
			{
				usingM.actions.Add(action);
			}
			else if (!edit && addList)
			{
				fieldsList.Add(fieldsEnt);
			}
			this.Close();

		}
	}
}
