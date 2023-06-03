
namespace SceneConstructor
{
	partial class AddModel
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
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.bSave = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bSelectModel = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.tbx1 = new System.Windows.Forms.TextBox();
			this.tby1 = new System.Windows.Forms.TextBox();
			this.tbz1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbz2 = new System.Windows.Forms.TextBox();
			this.tby2 = new System.Windows.Forms.TextBox();
			this.tbx2 = new System.Windows.Forms.TextBox();
			this.tbSize = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbSubtitle = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbDesc = new System.Windows.Forms.TextBox();
			this.tbp1 = new System.Windows.Forms.TrackBar();
			this.tbp2 = new System.Windows.Forms.TrackBar();
			this.tbp3 = new System.Windows.Forms.TrackBar();
			this.tbpm1 = new System.Windows.Forms.TrackBar();
			this.tbpm2 = new System.Windows.Forms.TrackBar();
			this.tbpm3 = new System.Windows.Forms.TrackBar();
			this.tbs = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.tbp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbp2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbp3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpm1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpm2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpm3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbs)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, -125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Имя сцены";
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(3, -109);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(160, 20);
			this.tb.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Имя модели";
			// 
			// tbTitle
			// 
			this.tbTitle.Location = new System.Drawing.Point(12, 28);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(446, 20);
			this.tbTitle.TabIndex = 7;
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(383, 383);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(75, 23);
			this.bSave.TabIndex = 6;
			this.bSave.Text = "Готово";
			this.bSave.UseVisualStyleBackColor = false;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(16, 352);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(345, 20);
			this.textBox2.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 331);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Файл модели";
			// 
			// bSelectModel
			// 
			this.bSelectModel.Location = new System.Drawing.Point(383, 350);
			this.bSelectModel.Name = "bSelectModel";
			this.bSelectModel.Size = new System.Drawing.Size(75, 23);
			this.bSelectModel.TabIndex = 14;
			this.bSelectModel.Text = "Выбор..";
			this.bSelectModel.UseVisualStyleBackColor = true;
			this.bSelectModel.Click += new System.EventHandler(this.bSelectModel_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Позиция";
			// 
			// tbx1
			// 
			this.tbx1.Location = new System.Drawing.Point(14, 182);
			this.tbx1.Name = "tbx1";
			this.tbx1.Size = new System.Drawing.Size(42, 20);
			this.tbx1.TabIndex = 17;
			this.tbx1.Text = "0";
			this.tbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
			this.tbx1.Leave += new System.EventHandler(this.AddModel_TextChanged);
			// 
			// tby1
			// 
			this.tby1.Location = new System.Drawing.Point(167, 182);
			this.tby1.Name = "tby1";
			this.tby1.Size = new System.Drawing.Size(42, 20);
			this.tby1.TabIndex = 19;
			this.tby1.Text = "0";
			this.tby1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
			this.tby1.Leave += new System.EventHandler(this.AddModel_TextChanged);
			// 
			// tbz1
			// 
			this.tbz1.Location = new System.Drawing.Point(319, 182);
			this.tbz1.Name = "tbz1";
			this.tbz1.Size = new System.Drawing.Size(42, 20);
			this.tbz1.TabIndex = 20;
			this.tbz1.Text = "0";
			this.tbz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
			this.tbz1.Leave += new System.EventHandler(this.AddModel_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 13);
			this.label5.TabIndex = 22;
			this.label5.Text = "Позиция в маркере";
			// 
			// tbz2
			// 
			this.tbz2.Location = new System.Drawing.Point(319, 246);
			this.tbz2.Name = "tbz2";
			this.tbz2.Size = new System.Drawing.Size(42, 20);
			this.tbz2.TabIndex = 25;
			this.tbz2.Text = "0";
			this.tbz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
			this.tbz2.Leave += new System.EventHandler(this.AddModel_TextChanged);
			// 
			// tby2
			// 
			this.tby2.Location = new System.Drawing.Point(167, 246);
			this.tby2.Name = "tby2";
			this.tby2.Size = new System.Drawing.Size(42, 20);
			this.tby2.TabIndex = 24;
			this.tby2.Text = "0";
			this.tby2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
			this.tby2.Leave += new System.EventHandler(this.AddModel_TextChanged);
			// 
			// tbx2
			// 
			this.tbx2.Location = new System.Drawing.Point(14, 246);
			this.tbx2.Name = "tbx2";
			this.tbx2.Size = new System.Drawing.Size(42, 20);
			this.tbx2.TabIndex = 23;
			this.tbx2.Text = "0";
			this.tbx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
			this.tbx2.Leave += new System.EventHandler(this.AddModel_TextChanged);
			// 
			// tbSize
			// 
			this.tbSize.Location = new System.Drawing.Point(16, 308);
			this.tbSize.Name = "tbSize";
			this.tbSize.Size = new System.Drawing.Size(193, 20);
			this.tbSize.TabIndex = 27;
			this.tbSize.Text = "1";
			this.tbSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
			this.tbSize.Leave += new System.EventHandler(this.AddModel_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 292);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 26;
			this.label6.Text = "Размер";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 13);
			this.label7.TabIndex = 31;
			this.label7.Text = "Краткое описание модели";
			// 
			// tbSubtitle
			// 
			this.tbSubtitle.Location = new System.Drawing.Point(13, 69);
			this.tbSubtitle.Name = "tbSubtitle";
			this.tbSubtitle.Size = new System.Drawing.Size(445, 20);
			this.tbSubtitle.TabIndex = 30;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 92);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 13);
			this.label8.TabIndex = 29;
			this.label8.Text = "Описание модели";
			// 
			// tbDesc
			// 
			this.tbDesc.Location = new System.Drawing.Point(13, 108);
			this.tbDesc.Multiline = true;
			this.tbDesc.Name = "tbDesc";
			this.tbDesc.Size = new System.Drawing.Size(445, 55);
			this.tbDesc.TabIndex = 28;
			// 
			// tbp1
			// 
			this.tbp1.Location = new System.Drawing.Point(62, 182);
			this.tbp1.Minimum = -10;
			this.tbp1.Name = "tbp1";
			this.tbp1.Size = new System.Drawing.Size(104, 45);
			this.tbp1.TabIndex = 32;
			this.tbp1.ValueChanged += new System.EventHandler(this.tbp1_ValueChanged);
			this.tbp1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbp1_MouseUp);
			// 
			// tbp2
			// 
			this.tbp2.Location = new System.Drawing.Point(215, 182);
			this.tbp2.Minimum = -10;
			this.tbp2.Name = "tbp2";
			this.tbp2.Size = new System.Drawing.Size(104, 45);
			this.tbp2.TabIndex = 33;
			this.tbp2.ValueChanged += new System.EventHandler(this.tbp2_ValueChanged);
			this.tbp2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbp2_MouseUp);
			// 
			// tbp3
			// 
			this.tbp3.Location = new System.Drawing.Point(367, 182);
			this.tbp3.Minimum = -10;
			this.tbp3.Name = "tbp3";
			this.tbp3.Size = new System.Drawing.Size(104, 45);
			this.tbp3.TabIndex = 34;
			this.tbp3.ValueChanged += new System.EventHandler(this.tbp3_ValueChanged);
			this.tbp3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbp3_MouseUp);
			// 
			// tbpm1
			// 
			this.tbpm1.Location = new System.Drawing.Point(62, 246);
			this.tbpm1.Minimum = -10;
			this.tbpm1.Name = "tbpm1";
			this.tbpm1.Size = new System.Drawing.Size(104, 45);
			this.tbpm1.TabIndex = 35;
			this.tbpm1.ValueChanged += new System.EventHandler(this.tbpm1_ValueChanged);
			this.tbpm1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbpm1_MouseUp);
			// 
			// tbpm2
			// 
			this.tbpm2.Location = new System.Drawing.Point(215, 246);
			this.tbpm2.Minimum = -10;
			this.tbpm2.Name = "tbpm2";
			this.tbpm2.Size = new System.Drawing.Size(104, 45);
			this.tbpm2.TabIndex = 36;
			this.tbpm2.ValueChanged += new System.EventHandler(this.tbpm2_ValueChanged);
			this.tbpm2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbpm2_MouseUp);
			// 
			// tbpm3
			// 
			this.tbpm3.Location = new System.Drawing.Point(367, 246);
			this.tbpm3.Minimum = -10;
			this.tbpm3.Name = "tbpm3";
			this.tbpm3.Size = new System.Drawing.Size(104, 45);
			this.tbpm3.TabIndex = 37;
			this.tbpm3.ValueChanged += new System.EventHandler(this.tbpm3_ValueChanged);
			this.tbpm3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbpm3_MouseUp);
			// 
			// tbs
			// 
			this.tbs.Location = new System.Drawing.Point(215, 301);
			this.tbs.Minimum = -10;
			this.tbs.Name = "tbs";
			this.tbs.Size = new System.Drawing.Size(104, 45);
			this.tbs.TabIndex = 38;
			this.tbs.ValueChanged += new System.EventHandler(this.tbs_ValueChanged);
			this.tbs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbs_MouseUp);
			// 
			// AddModel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 427);
			this.Controls.Add(this.tbs);
			this.Controls.Add(this.tbpm3);
			this.Controls.Add(this.tbpm2);
			this.Controls.Add(this.tbpm1);
			this.Controls.Add(this.tbp3);
			this.Controls.Add(this.tbp2);
			this.Controls.Add(this.tbp1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbSubtitle);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbDesc);
			this.Controls.Add(this.tbSize);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbz2);
			this.Controls.Add(this.tby2);
			this.Controls.Add(this.tbx2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbz1);
			this.Controls.Add(this.tby1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbx1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bSelectModel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb);
			this.Name = "AddModel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddModel";
			this.TextChanged += new System.EventHandler(this.AddModel_TextChanged);
			((System.ComponentModel.ISupportInitialize)(this.tbp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbp2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbp3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpm1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpm2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpm3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTitle;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bSelectModel;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tby1;
		private System.Windows.Forms.TextBox tbz1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbz2;
		private System.Windows.Forms.TextBox tby2;
		private System.Windows.Forms.TextBox tbx2;
		private System.Windows.Forms.TextBox tbSize;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbSubtitle;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbDesc;
		private System.Windows.Forms.TrackBar tbp2;
		private System.Windows.Forms.TrackBar tbp3;
		private System.Windows.Forms.TrackBar tbpm1;
		private System.Windows.Forms.TrackBar tbpm2;
		private System.Windows.Forms.TrackBar tbpm3;
		private System.Windows.Forms.TrackBar tbs;
		private System.Windows.Forms.TrackBar tbp1;
		public System.Windows.Forms.TextBox tbx1;
	}
}