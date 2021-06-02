using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SceneConstructor
{
	public partial class EditorScene : Form
	{
		Scene scene;

		public EditorScene(Scene scene)
		{
			InitializeComponent();
			this.scene = scene;
			init();
		}

		private void init()
		{
			lbMetk.Enabled = true;
			bAddMetk.Enabled = true;
			bEditMetk.Enabled = true;
			bDeleteMetk.Enabled = true;

			Marker marker = new Marker();
			if (scene.typeMarkers == "NOTMARKER")
			{
				lbMetk.Enabled = false;
				bAddMetk.Enabled = false;
				bEditMetk.Enabled = false;
				bDeleteMetk.Enabled = false;
				marker.markerValue = "All models";
				scene.markers.Add(marker);
			}

			lbMetk.DataSource = null;
			lbMetk.DataSource = scene.markers;
			lbMetk.SelectedItem = marker;
			lbModel.DataSource = null;
			lbUsing.DataSource = null;
			lbAction.DataSource = null;
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
				lbModel.DataSource = (lbMetk.SelectedItem as Marker).models;
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
				lbAction.DataSource = (lbUsing.SelectedItem as Using).actions;
			}
		}

		private void bAddMetk_Click(object sender, EventArgs e)
		{
			AddMarker newForm = new AddMarker(scene);
			newForm.FormClosed += Marker_FormClosed;
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
			(lbMetk.SelectedItem as Marker).models.Remove(lbModel.SelectedItem as ModelScene);
			AddModel_FormClosed(null, null);
		}

		private void AddModel_FormClosed(object sender, FormClosedEventArgs e)
		{
			lbModel.DataSource = null;
			lbModel.DataSource = (lbMetk.SelectedItem as Marker).models;
			lbUsing.DataSource = null;
			lbAction.DataSource = null;
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			scene.saveScene();
		}

		private void bSaveAs_Click(object sender, EventArgs e)
		{
			SaveSceneAs newForm = new SaveSceneAs(scene);
			newForm.Owner = this;
			newForm.ShowDialog();
		}

		private void bAddUsing_Click(object sender, EventArgs e)
		{
			if (lbModel.SelectedItem != null)
			{
				AddUsing newForm = new AddUsing(lbModel.SelectedItem as ModelScene);
				newForm.FormClosed += AddUsing_FormClosed;
				newForm.Owner = this;
				newForm.ShowDialog();
			}
		}

		private void bEditUsing_Click(object sender, EventArgs e)
		{
			if (lbUsing.SelectedItem != null)
			{
				AddUsing newForm = new AddUsing(lbUsing.SelectedItem as Using);
				newForm.FormClosed += AddUsing_FormClosed;
				newForm.Owner = this;
				newForm.ShowDialog();
			}
		}

		private void AddUsing_FormClosed(object sender, FormClosedEventArgs e)
		{
			lbUsing.DataSource = null;
			lbUsing.DataSource = (lbModel.SelectedItem as ModelScene).model.anchors;
			lbAction.DataSource = null;
		}

		private void bLoadScene_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "JSON files(*.json)|*.json";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filename = openFileDialog1.FileName;
				try
				{
					scene = Scene.openScene(filename);
					init();
				}
				catch
				{
					MessageBox.Show("Not scene in file");
				}
			}
			else
				return;
		}

		private void bAddAction_Click(object sender, EventArgs e)
		{
			if (lbUsing.SelectedItem != null)
			{
				AddActionSelect newForm = new AddActionSelect(lbUsing.SelectedItem as Using, scene);
				newForm.Owner = this;
				newForm.ShowDialog();
			}
		}
	}
}
