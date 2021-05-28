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
	public partial class AddModel : Form
	{
		private ModelScene modelScene;

		public AddModel(Marker marker)
		{
			InitializeComponent();
		}

		public AddModel(ModelScene modelScene)
		{
			this.modelScene = modelScene;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
