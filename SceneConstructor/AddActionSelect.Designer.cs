
namespace SceneConstructor
{
	partial class AddActionSelect
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
			this.lbActions = new System.Windows.Forms.ListBox();
			this.bSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbActions
			// 
			this.lbActions.FormattingEnabled = true;
			this.lbActions.Location = new System.Drawing.Point(12, 52);
			this.lbActions.Name = "lbActions";
			this.lbActions.Size = new System.Drawing.Size(195, 212);
			this.lbActions.TabIndex = 16;
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(113, 270);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(94, 23);
			this.bSave.TabIndex = 17;
			this.bSave.Text = "Далее";
			this.bSave.UseVisualStyleBackColor = false;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Имя действия";
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(12, 26);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(195, 20);
			this.tb.TabIndex = 18;
			// 
			// AddActionSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(219, 303);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.lbActions);
			this.Name = "AddActionSelect";
			this.Text = "AddActionSelect";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbActions;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb;
	}
}