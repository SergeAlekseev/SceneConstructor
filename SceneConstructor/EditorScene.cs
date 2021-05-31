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
	public partial class EditorScene : Form
	{
		Scene scene;
		List<ModelScene> models;

		public EditorScene(Scene scene)
		{
			InitializeComponent();
			this.scene = scene;
			/*
						var choices = new Dictionary<string, string>();
						choices["A"] = "Arthur";
						choices["F"] = "Ford";
						choices["T"] = "Trillian";
						choices["Z"] = "Zaphod";
						lbMetk.DataSource = new BindingSource(choices, null);
						lbMetk.DisplayMember = "Key";
						lbMetk.ValueMember = "Value";*/


			if (scene.typeMarkers == "NOTMARKER")
			{
				lbMetk.Enabled = false;
				bAddMetk.Enabled = false;
				bEditMetk.Enabled = false;
				bDeleteMetk.Enabled = false;
				models = scene.OtherModels;
			}

			lbMetk.DataSource = scene.markers;

		}

		private void EditorScene_FormClosing(object sender, FormClosingEventArgs e)
		{
			Owner.Show();
		}

		private void bPreVision_Click(object sender, EventArgs e)
		{

		}

		private void bUploadFTP_Click(object sender, EventArgs e)
		{

		}

		private void lbMetk_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbMetk.SelectedItem != null)
			{
				lbModel.DataSource = null;
				lbModel.DataSource = (lbMetk.SelectedItem as Marker).models; ////
				models = (lbMetk.SelectedItem as Marker).models;
				lbUsing.DataSource = null;
				lbAction.DataSource = null;
			}
		}

		private void lbModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbModel.SelectedItem != null)
			{
				lbUsing.DataSource = null;
				lbUsing.DataSource = (lbModel.SelectedItem as ModelScene).model.anchors;
				lbAction.DataSource = null;
			}
		}

		private void lbUsing_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbUsing.SelectedItem != null)
			{
				lbAction.DataSource = null;
				lbAction.DataSource = (lbUsing.SelectedItem as Using).Actions;
			}
		}

		private void bAddMetk_Click(object sender, EventArgs e)
		{
			AddMarker newForm = new AddMarker(scene);
			newForm.FormClosed += Marker_FormClosed; ;
			newForm.Owner = this;
			newForm.ShowDialog();
		}

		private void bEditMetk_Click(object sender, EventArgs e)
		{
			if (lbMetk.SelectedItem != null)
			{
				AddMarker newForm = new AddMarker(scene, lbMetk.SelectedItem as Marker);
				newForm.FormClosed += Marker_FormClosed;
				newForm.Owner = this;
				newForm.ShowDialog();
			}
		}

		private void bDeleteMetk_Click(object sender, EventArgs e)
		{
			scene.markers.Remove(lbMetk.SelectedItem as Marker);
			Marker_FormClosed(null, null);
		}

		private void Marker_FormClosed(object sender, FormClosedEventArgs e)
		{
			lbMetk.DataSource = null;
			lbMetk.DataSource = scene.markers;
			lbModel.DataSource = null;
			lbUsing.DataSource = null;
			lbAction.DataSource = null;
		}

		private void bAddModel_Click(object sender, EventArgs e)
		{
			if (lbMetk.SelectedItem != null)
			{
				AddModel newForm = new AddModel(lbMetk.SelectedItem as Marker);
				newForm.FormClosed += AddModel_FormClosed;
				newForm.Owner = this;
				newForm.ShowDialog();
			}
		}



		private void bEditModel_Click(object sender, EventArgs e)
		{
			if (lbModel.SelectedItem != null)
			{
				AddModel newForm = new AddModel(lbModel.SelectedItem as ModelScene);
				newForm.FormClosed += AddModel_FormClosed;
				newForm.Owner = this;
				newForm.ShowDialog();
			}
		}

		private void bDeleteModel_Click(object sender, EventArgs e)
		{

		}

		private void AddModel_FormClosed(object sender, FormClosedEventArgs e)
		{

			lbModel.DataSource = null;
			lbModel.DataSource = (lbMetk.SelectedItem as Marker).models;
			models = (lbMetk.SelectedItem as Marker).models;
			lbUsing.DataSource = null;
			lbAction.DataSource = null;

		}
	}
}
