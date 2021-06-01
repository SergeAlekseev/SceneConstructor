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
	public partial class SaveSceneAs : Form
	{

		Scene scene;

		public SaveSceneAs(Scene scene)
		{
			InitializeComponent();
			this.scene = scene;
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			if (tbTitle.Text != "")
			{
				scene.name = tbTitle.Text;
				scene.saveScene();
				this.Close();
			}
			else MessageBox.Show("No name");
		}
	}
}
