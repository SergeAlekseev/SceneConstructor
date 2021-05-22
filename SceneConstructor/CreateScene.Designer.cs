
namespace SceneConstructor
{
	partial class CreateScene
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
			this.tb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.bSelectJS = new System.Windows.Forms.Button();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.gbTypeScene = new System.Windows.Forms.GroupBox();
			this.lbActions = new System.Windows.Forms.ListBox();
			this.bDelete = new System.Windows.Forms.Button();
			this.bEdit = new System.Windows.Forms.Button();
			this.gbTypeScene.SuspendLayout();
			this.SuspendLayout();
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(200, 387);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(94, 23);
			this.bSave.TabIndex = 0;
			this.bSave.Text = "Готово";
			this.bSave.UseVisualStyleBackColor = false;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(15, 29);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(179, 20);
			this.tb.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Имя сцены";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Действия";
			// 
			// bSelectJS
			// 
			this.bSelectJS.Location = new System.Drawing.Point(200, 85);
			this.bSelectJS.Name = "bSelectJS";
			this.bSelectJS.Size = new System.Drawing.Size(94, 23);
			this.bSelectJS.TabIndex = 5;
			this.bSelectJS.Text = "Добавить";
			this.bSelectJS.UseVisualStyleBackColor = true;
			this.bSelectJS.Click += new System.EventHandler(this.bSelectJS_Click);
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog1";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(58, 17);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Marker";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 42);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(89, 17);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.Text = "Image marker";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(6, 65);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(77, 17);
			this.radioButton3.TabIndex = 11;
			this.radioButton3.Text = "Not marker";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// gbTypeScene
			// 
			this.gbTypeScene.Controls.Add(this.radioButton1);
			this.gbTypeScene.Controls.Add(this.radioButton2);
			this.gbTypeScene.Controls.Add(this.radioButton3);
			this.gbTypeScene.Location = new System.Drawing.Point(15, 310);
			this.gbTypeScene.Name = "gbTypeScene";
			this.gbTypeScene.Size = new System.Drawing.Size(99, 100);
			this.gbTypeScene.TabIndex = 14;
			this.gbTypeScene.TabStop = false;
			this.gbTypeScene.Text = "Тип сцены";
			// 
			// lbActions
			// 
			this.lbActions.FormattingEnabled = true;
			this.lbActions.Location = new System.Drawing.Point(15, 85);
			this.lbActions.Name = "lbActions";
			this.lbActions.Size = new System.Drawing.Size(179, 212);
			this.lbActions.TabIndex = 15;
			// 
			// bDelete
			// 
			this.bDelete.Location = new System.Drawing.Point(200, 143);
			this.bDelete.Name = "bDelete";
			this.bDelete.Size = new System.Drawing.Size(94, 23);
			this.bDelete.TabIndex = 19;
			this.bDelete.Text = "Удалить";
			this.bDelete.UseVisualStyleBackColor = true;
			this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
			// 
			// bEdit
			// 
			this.bEdit.Location = new System.Drawing.Point(200, 114);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(94, 23);
			this.bEdit.TabIndex = 18;
			this.bEdit.Text = "Редактировать";
			this.bEdit.UseVisualStyleBackColor = true;
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// CreateScene
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 420);
			this.Controls.Add(this.bDelete);
			this.Controls.Add(this.bEdit);
			this.Controls.Add(this.lbActions);
			this.Controls.Add(this.gbTypeScene);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bSelectJS);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.bSave);
			this.Name = "CreateScene";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CreateScene";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateScene_FormClosing);
			this.gbTypeScene.ResumeLayout(false);
			this.gbTypeScene.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bSelectJS;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox gbTypeScene;
		private System.Windows.Forms.ListBox lbActions;
		private System.Windows.Forms.Button bDelete;
		private System.Windows.Forms.Button bEdit;
	}
}