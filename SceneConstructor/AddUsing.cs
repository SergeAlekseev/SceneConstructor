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
		WEB web;
		public AddUsing(ModelScene modelScene)
		{
			InitializeComponent();
			usingModel = new Using();
			this.modelScene = modelScene;
		}

		public AddUsing(Using usingModel, WEB web)
		{
			InitializeComponent();
			this.usingModel = usingModel;
			tb.Text = usingModel.id;
			tbx3.Text=""+ usingModel.PositionLine.x;
			tby3.Text=""+ usingModel.PositionLine.y;
			tbz3.Text=""+ usingModel.PositionLine.z;
			tbx2.Text=""+ usingModel.PositionAfter.x;
			tby2.Text=""+ usingModel.PositionAfter.y;
			tbz2.Text=""+ usingModel.PositionAfter.z;
			tbx1.Text=""+ usingModel.Position.x;
			tby1.Text=""+ usingModel.Position.y;
			tbz1.Text=""+ usingModel.Position.z;
			edit = true;

			this.web = web;
			if (web != null)
			{
				if (usingModel.GUID == "")
					usingModel.GUID = Guid.NewGuid().ToString();
				tbx1.TextChanged += Position_TextChanged;
				tby1.TextChanged += Position_TextChanged;
				tbz1.TextChanged += Position_TextChanged;
				tbx2.TextChanged += PositionAfter_TextChanged;
				tby2.TextChanged += PositionAfter_TextChanged;
				tbz2.TextChanged += PositionAfter_TextChanged;
				tbx3.TextChanged += PositionLine_TextChanged;
				tby3.TextChanged += PositionLine_TextChanged;
				tbz3.TextChanged += PositionLine_TextChanged;
			}
		}

		private void PositionLine_TextChanged(object sender, EventArgs e)
		{
			Double.TryParse(tbx3.Text, out usingModel.PositionLine.x);
			Double.TryParse(tby3.Text, out usingModel.PositionLine.y);
			Double.TryParse(tbz3.Text, out usingModel.PositionLine.z);
			string position = "" + usingModel.Position.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.Position.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.Position.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			string positionAfter = "" + usingModel.PositionAfter.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionAfter.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionAfter.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			string positionLine = "" + usingModel.PositionLine.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionLine.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionLine.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			string script = "let sphere = document.getElementById('" + usingModel.GUID + "'); " +
				"let line = document.getElementById('" + usingModel.GUID + "line" + "'); " +
				"if (sphere.getAttribute('color') === 'white') " +
				"{ " +
					 "line.setAttribute('line', { " +
						"'start' : '" + positionLine + "', " +
								 "'end' :  '" + position + "', " +
								 "'color' : 'white', " +
								 "'opacity' : 0.5 " +
								"}); " +
					"sphere.setAttribute('position', '" + position + "'); " +
				"} " +
				"else " +
				"{ " +
					"line.setAttribute('line', { " +
						"'start' : '" + positionLine + "', " +
								 "'end' :  '" + positionAfter + "', " +
								 "'color' : 'white', " +
								 "'opacity' : 0.5 " +

								"}); " +
					"sphere.setAttribute('position', '" + positionAfter + "'); " +
				"}; ";
			web.executeScript(script);
			updateUsing();
		}

		private void PositionAfter_TextChanged(object sender, EventArgs e)
		{
			Double.TryParse(tbx2.Text, out usingModel.PositionAfter.x);
			Double.TryParse(tby2.Text, out usingModel.PositionAfter.y);
			Double.TryParse(tbz2.Text, out usingModel.PositionAfter.z);
			updateUsing();
			
			string script = "let sphere = document.getElementById('" + usingModel.GUID + "'); " +
				"let line = document.getElementById('" + usingModel.GUID + "line" + "'); " +
				"if (sphere.getAttribute('color') === 'white') " +
				"{ " +
					 "sphere.click(); " +
				"}" +
				"else " +
				"{ " +
					 "sphere.click(); "+
					 "sphere.click(); " +
				"}; ";
			web.executeScript(script);
		}

		private void Position_TextChanged(object sender, EventArgs e)
		{
			Double.TryParse(tbx1.Text, out usingModel.Position.x);
			Double.TryParse(tby1.Text, out usingModel.Position.y);
			Double.TryParse(tbz1.Text, out usingModel.Position.z);
			updateUsing();

			string script = "let sphere = document.getElementById('" + usingModel.GUID + "'); " +
				"let line = document.getElementById('" + usingModel.GUID + "line" + "'); " +
				"if (sphere.getAttribute('color') === 'blue') " +
				"{ " +
					 "sphere.click(); " +
				"}" +
				"else " +
				"{ " +
					 "sphere.click(); " +
					 "sphere.click(); " +
				"}; ";
			web.executeScript(script);
		}

		private void updateUsing()
		{
			string position = "" + usingModel.Position.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.Position.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.Position.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			string positionAfter = "" + usingModel.PositionAfter.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionAfter.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionAfter.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			string positionLine = "" + usingModel.PositionLine.x.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionLine.y.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US")) + " " + usingModel.PositionLine.z.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			string script = "let sphere = document.getElementById('" + usingModel.GUID + "'); " +
				"let line = document.getElementById('" + usingModel.GUID + "line" + "'); " +
				"sphere.addEventListener('click', function (e) { " +
						"if (sphere.getAttribute('visible') === true) " +
				"if (sphere.getAttribute('color') === 'white') " +
				"{ " +
					 "line.setAttribute('line', { " +
						"'start' : '"+ positionLine + "', " +
								 "'end' :  '" + position + "', " +
								 "'color' : 'white', " +
								 "'opacity' : 0.5 " +
								"}); " +
					"sphere.setAttribute('position', '" + position + "'); " +
				"} " +
				"else " +
				"{ " +
					"line.setAttribute('line', { " +
						"'start' : '" + positionLine + "', " +
								 "'end' :  '" + positionAfter + "', " +
								 "'color' : 'white', " +
								 "'opacity' : 0.5 " +

								"}); " +
					"sphere.setAttribute('position', '" + positionAfter + "'); " +
				"} " +
			"});";

			web.executeScript(script);
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
				Double.TryParse(tbz1.Text, out usingModel.Position.z);
				if (!edit)
					modelScene.model.anchors.Add(usingModel);
				this.Close();
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
			else if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0) || (!(sender as TextBox).Text.Contains(",") && e.KeyChar == ',')))
				e.Handled = true;
		}

		private void tbx1_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbz1_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbx1_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}
