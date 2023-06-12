using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace SceneConstructor
{
	public partial class WYSIWYG : Form
	{
		private Scene scene;
		private Marker marker;
		private WEB web;

		public WYSIWYG(Scene scene, Marker marker, WEB web)
		{
			InitializeComponent();
			this.scene = scene;
			this.marker = marker;
			this.web = web;
			this.Size = new Size(800, 800);
			foreach (var model in this.marker.models) {
				System.Windows.Forms.Button bEdit = new System.Windows.Forms.Button
				{
					Text = model.model.title,
					Location = new Point((int)(model.position.x * 50 + 400 - 25 * model.size.x), (int)(model.position.z * 50 + 400 - 25 * model.size.x)),
					Size = new Size((int)(50 * model.size.x), (int)(50 * model.size.x)),
				
				};
				bEdit.Click += (s, e) =>
				{
					AddModel newForm = new AddModel(model, web);
					newForm.Owner = this;
					newForm.FormClosing += checkBox1_CheckedChanged;
					newForm.ShowDialog();
				};
				this.Controls.Add(bEdit);
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			List<System.Windows.Forms.Button> list = new List<System.Windows.Forms.Button>();
			foreach(var control  in this.Controls)
			{
				if (control is System.Windows.Forms.Button) {
					list.Add(control as System.Windows.Forms.Button);
				}
			}
			foreach(var control in list)
			{
				this.Controls.Remove(control);
			}
			if (!checkBox1.Checked)
			{
				foreach (var model in this.marker.models)
				{
					System.Windows.Forms.Button bEdit = new System.Windows.Forms.Button
					{
						Text = model.model.title,
						Location = new Point((int)(model.position.x * 50 + 400 - 25), (int)(model.position.z * 50 + 400 - 25)),
						Size = new Size((int)(50), (int)(50)),

					};
					bEdit.Click += (s, ee) =>
					{
						AddModel newForm = new AddModel(model, web);
						newForm.Owner = this;
						newForm.ShowDialog();
					};
					this.Controls.Add(bEdit);
				}
			} else if (checkBox1.Checked) {
				foreach (var model in this.marker.models)
				{
					System.Windows.Forms.Button bEdit = new System.Windows.Forms.Button
					{
						Text = model.model.title,
						Location = new Point((int)(model.position.x * 50 + 400 - 25 * model.size.x), (int)(model.position.z * 50 + 400 - 25 * model.size.x)),
						Size = new Size((int)(50 * model.size.x), (int)(50 * model.size.x)),

					};
					bEdit.Click += (s, ee) =>
					{
						AddModel newForm = new AddModel(model, web);
						newForm.Owner = this;
						newForm.ShowDialog();
					};
					this.Controls.Add(bEdit);
				}
			}
		}
	}
}
