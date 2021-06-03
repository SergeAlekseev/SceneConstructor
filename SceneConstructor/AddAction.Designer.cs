
namespace SceneConstructor
{
	partial class AddAction
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bSave
			// 
			this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bSave.Location = new System.Drawing.Point(12, 12);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(300, 23);
			this.bSave.TabIndex = 0;
			this.bSave.Text = "Готово";
			this.bSave.UseVisualStyleBackColor = true;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// AddAction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(324, 302);
			this.Controls.Add(this.bSave);
			this.Name = "AddAction";
			this.Text = "AddAction";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bSave;
	}
}