
namespace SceneConstructor
{
	partial class SaveSceneAs
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.bSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Имя сцены";
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(12, 26);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(177, 20);
			this.tbTitle.TabIndex = 9;
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(114, 52);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(75, 23);
			this.bSave.TabIndex = 11;
			this.bSave.Text = "Сохранить";
			this.bSave.UseVisualStyleBackColor = false;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// SaveSceneAs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(201, 86);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTitle);
			this.Name = "SaveSceneAs";
			this.Text = "SaveSceneAs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.Button bSave;
	}
}