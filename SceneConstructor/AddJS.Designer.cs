
namespace SceneConstructor
{
	partial class AddJS
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bSelectModel = new System.Windows.Forms.Button();
			this.bSelectJS = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.bAdd = new System.Windows.Forms.Button();
			this.bEdit = new System.Windows.Forms.Button();
			this.bDelete = new System.Windows.Forms.Button();
			this.lbEnt = new System.Windows.Forms.ListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Имя действия";
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(12, 27);
			this.tb.MaxLength = 15;
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(153, 20);
			this.tb.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "JS скрипт";
			// 
			// bSelectModel
			// 
			this.bSelectModel.Location = new System.Drawing.Point(173, 73);
			this.bSelectModel.Name = "bSelectModel";
			this.bSelectModel.Size = new System.Drawing.Size(94, 23);
			this.bSelectModel.TabIndex = 5;
			this.bSelectModel.Text = "Выбор..";
			this.bSelectModel.UseVisualStyleBackColor = true;
			this.bSelectModel.Click += new System.EventHandler(this.bSelectModel_Click);
			// 
			// bSelectJS
			// 
			this.bSelectJS.Location = new System.Drawing.Point(173, 381);
			this.bSelectJS.Name = "bSelectJS";
			this.bSelectJS.Size = new System.Drawing.Size(94, 23);
			this.bSelectJS.TabIndex = 12;
			this.bSelectJS.Text = "Готово";
			this.bSelectJS.UseVisualStyleBackColor = true;
			this.bSelectJS.Click += new System.EventHandler(this.bSelectJS_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Поля";
			// 
			// bAdd
			// 
			this.bAdd.Location = new System.Drawing.Point(173, 127);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(94, 23);
			this.bAdd.TabIndex = 15;
			this.bAdd.Text = "Добавить";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bEdit
			// 
			this.bEdit.Location = new System.Drawing.Point(173, 156);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(94, 23);
			this.bEdit.TabIndex = 16;
			this.bEdit.Text = "Редактировать";
			this.bEdit.UseVisualStyleBackColor = true;
			this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
			// 
			// bDelete
			// 
			this.bDelete.Location = new System.Drawing.Point(173, 185);
			this.bDelete.Name = "bDelete";
			this.bDelete.Size = new System.Drawing.Size(94, 23);
			this.bDelete.TabIndex = 17;
			this.bDelete.Text = "Удалить";
			this.bDelete.UseVisualStyleBackColor = true;
			this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
			// 
			// lbEnt
			// 
			this.lbEnt.FormattingEnabled = true;
			this.lbEnt.Location = new System.Drawing.Point(12, 127);
			this.lbEnt.Name = "lbEnt";
			this.lbEnt.Size = new System.Drawing.Size(153, 277);
			this.lbEnt.TabIndex = 18;
			this.lbEnt.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(12, 75);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(153, 20);
			this.textBox1.TabIndex = 19;
			// 
			// AddJS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 413);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lbEnt);
			this.Controls.Add(this.bDelete);
			this.Controls.Add(this.bEdit);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bSelectJS);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bSelectModel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb);
			this.Name = "AddJS";
			this.Text = "AddJS";
			this.Load += new System.EventHandler(this.AddJS_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bSelectModel;
		private System.Windows.Forms.Button bSelectJS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bEdit;
		private System.Windows.Forms.Button bDelete;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.ListBox lbEnt;
	}
}