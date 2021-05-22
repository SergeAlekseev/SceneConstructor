
namespace SceneConstructor
{
	partial class AddEnt
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
			this.lbEnt = new System.Windows.Forms.ListBox();
			this.gbTypeScene = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb = new System.Windows.Forms.TextBox();
			this.bSave = new System.Windows.Forms.Button();
			this.bDelete = new System.Windows.Forms.Button();
			this.bEdit = new System.Windows.Forms.Button();
			this.bAdd = new System.Windows.Forms.Button();
			this.gbTypeScene.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbEnt
			// 
			this.lbEnt.Enabled = false;
			this.lbEnt.FormattingEnabled = true;
			this.lbEnt.Location = new System.Drawing.Point(12, 118);
			this.lbEnt.Name = "lbEnt";
			this.lbEnt.Size = new System.Drawing.Size(160, 212);
			this.lbEnt.TabIndex = 22;
			// 
			// gbTypeScene
			// 
			this.gbTypeScene.Controls.Add(this.radioButton1);
			this.gbTypeScene.Controls.Add(this.radioButton2);
			this.gbTypeScene.Controls.Add(this.radioButton3);
			this.gbTypeScene.Location = new System.Drawing.Point(190, 6);
			this.gbTypeScene.Name = "gbTypeScene";
			this.gbTypeScene.Size = new System.Drawing.Size(120, 100);
			this.gbTypeScene.TabIndex = 21;
			this.gbTypeScene.TabStop = false;
			this.gbTypeScene.Text = "Тип атрибута";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(57, 17);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Число";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 42);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(55, 17);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.Text = "Текст";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(6, 65);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(112, 17);
			this.radioButton3.TabIndex = 11;
			this.radioButton3.Text = "Список обьектов";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "Поля обьекта в списке";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Имя Атрибута";
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(12, 22);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(160, 20);
			this.tb.TabIndex = 17;
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(190, 307);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(117, 23);
			this.bSave.TabIndex = 16;
			this.bSave.Text = "Сохранить";
			this.bSave.UseVisualStyleBackColor = false;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// bDelete
			// 
			this.bDelete.Enabled = false;
			this.bDelete.Location = new System.Drawing.Point(190, 176);
			this.bDelete.Name = "bDelete";
			this.bDelete.Size = new System.Drawing.Size(117, 23);
			this.bDelete.TabIndex = 27;
			this.bDelete.Text = "Удалить";
			this.bDelete.UseVisualStyleBackColor = true;
			this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
			// 
			// bEdit
			// 
			this.bEdit.Enabled = false;
			this.bEdit.Location = new System.Drawing.Point(190, 147);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(117, 23);
			this.bEdit.TabIndex = 26;
			this.bEdit.Text = "Редактировать";
			this.bEdit.UseVisualStyleBackColor = true;
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// bAdd
			// 
			this.bAdd.Enabled = false;
			this.bAdd.Location = new System.Drawing.Point(190, 118);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(117, 23);
			this.bAdd.TabIndex = 25;
			this.bAdd.Text = "Добавить";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// AddEnt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 344);
			this.Controls.Add(this.bDelete);
			this.Controls.Add(this.bEdit);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.lbEnt);
			this.Controls.Add(this.gbTypeScene);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.bSave);
			this.Name = "AddEnt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddEnt";
			this.gbTypeScene.ResumeLayout(false);
			this.gbTypeScene.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbEnt;
		private System.Windows.Forms.GroupBox gbTypeScene;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.Button bDelete;
		private System.Windows.Forms.Button bEdit;
		private System.Windows.Forms.Button bAdd;
	}
}