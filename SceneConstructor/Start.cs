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
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			CreateScene newForm = new CreateScene();
			newForm.Owner = this;
			newForm.ShowDialog();
		}

		private void bOpen_Click(object sender, EventArgs e)
		{

		}
	}
}
