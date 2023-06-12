
namespace SceneConstructor
{
	partial class EditorScene
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
			this.bAddMetk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bAddAction = new System.Windows.Forms.Button();
			this.bEditAction = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.bPreVision = new System.Windows.Forms.Button();
			this.bSave = new System.Windows.Forms.Button();
			this.bUploadFTP = new System.Windows.Forms.Button();
			this.bLoadScene = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.bAddModel = new System.Windows.Forms.Button();
			this.bEditModel = new System.Windows.Forms.Button();
			this.lbMetk = new System.Windows.Forms.ListBox();
			this.lbModel = new System.Windows.Forms.ListBox();
			this.lbUsing = new System.Windows.Forms.ListBox();
			this.lbAction = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bEditMetk = new System.Windows.Forms.Button();
			this.bDeleteUsing = new System.Windows.Forms.Button();
			this.bAddUsing = new System.Windows.Forms.Button();
			this.bDeleteMetk = new System.Windows.Forms.Button();
			this.bDeleteModel = new System.Windows.Forms.Button();
			this.bEditUsing = new System.Windows.Forms.Button();
			this.bSaveAs = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.bWYSWIWG = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bAddMetk
			// 
			this.bAddMetk.Location = new System.Drawing.Point(12, 420);
			this.bAddMetk.Name = "bAddMetk";
			this.bAddMetk.Size = new System.Drawing.Size(154, 23);
			this.bAddMetk.TabIndex = 9;
			this.bAddMetk.Text = "Добавить метку";
			this.bAddMetk.UseVisualStyleBackColor = true;
			this.bAddMetk.Click += new System.EventHandler(this.bAddMetk_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Модель";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(516, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Действия переключателя";
			// 
			// bAddAction
			// 
			this.bAddAction.Location = new System.Drawing.Point(519, 420);
			this.bAddAction.Name = "bAddAction";
			this.bAddAction.Size = new System.Drawing.Size(154, 23);
			this.bAddAction.TabIndex = 14;
			this.bAddAction.Text = "Добавить действие";
			this.bAddAction.UseVisualStyleBackColor = true;
			this.bAddAction.Click += new System.EventHandler(this.bAddAction_Click);
			// 
			// bEditAction
			// 
			this.bEditAction.Location = new System.Drawing.Point(519, 449);
			this.bEditAction.Name = "bEditAction";
			this.bEditAction.Size = new System.Drawing.Size(154, 23);
			this.bEditAction.TabIndex = 15;
			this.bEditAction.Text = "Редактировать";
			this.bEditAction.UseVisualStyleBackColor = true;
			this.bEditAction.Click += new System.EventHandler(this.bEditAction_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(519, 478);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(154, 23);
			this.button4.TabIndex = 16;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.bDeleteCtion_Click);
			// 
			// bPreVision
			// 
			this.bPreVision.Location = new System.Drawing.Point(679, 30);
			this.bPreVision.Name = "bPreVision";
			this.bPreVision.Size = new System.Drawing.Size(146, 23);
			this.bPreVision.TabIndex = 17;
			this.bPreVision.Text = "Предпросмотр";
			this.bPreVision.UseVisualStyleBackColor = true;
			this.bPreVision.Click += new System.EventHandler(this.bPreVision_Click);
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(679, 115);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(146, 23);
			this.bSave.TabIndex = 19;
			this.bSave.Text = "Сохранить";
			this.bSave.UseVisualStyleBackColor = true;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// bUploadFTP
			// 
			this.bUploadFTP.Location = new System.Drawing.Point(678, 388);
			this.bUploadFTP.Name = "bUploadFTP";
			this.bUploadFTP.Size = new System.Drawing.Size(146, 23);
			this.bUploadFTP.TabIndex = 21;
			this.bUploadFTP.Text = "Загрузка по FTP";
			this.bUploadFTP.UseVisualStyleBackColor = true;
			this.bUploadFTP.Click += new System.EventHandler(this.bUploadFTP_Click);
			// 
			// bLoadScene
			// 
			this.bLoadScene.Location = new System.Drawing.Point(679, 173);
			this.bLoadScene.Name = "bLoadScene";
			this.bLoadScene.Size = new System.Drawing.Size(146, 23);
			this.bLoadScene.TabIndex = 23;
			this.bLoadScene.Text = "Загрузить";
			this.bLoadScene.UseVisualStyleBackColor = true;
			this.bLoadScene.Click += new System.EventHandler(this.bLoadScene_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Метки";
			// 
			// bAddModel
			// 
			this.bAddModel.Location = new System.Drawing.Point(181, 420);
			this.bAddModel.Name = "bAddModel";
			this.bAddModel.Size = new System.Drawing.Size(154, 23);
			this.bAddModel.TabIndex = 27;
			this.bAddModel.Text = "Добавить модель к метке";
			this.bAddModel.UseVisualStyleBackColor = true;
			this.bAddModel.Click += new System.EventHandler(this.bAddModel_Click);
			// 
			// bEditModel
			// 
			this.bEditModel.Location = new System.Drawing.Point(181, 449);
			this.bEditModel.Name = "bEditModel";
			this.bEditModel.Size = new System.Drawing.Size(154, 23);
			this.bEditModel.TabIndex = 28;
			this.bEditModel.Text = "Редактировать";
			this.bEditModel.UseVisualStyleBackColor = true;
			this.bEditModel.Click += new System.EventHandler(this.bEditModel_Click);
			// 
			// lbMetk
			// 
			this.lbMetk.FormattingEnabled = true;
			this.lbMetk.Location = new System.Drawing.Point(12, 30);
			this.lbMetk.Name = "lbMetk";
			this.lbMetk.Size = new System.Drawing.Size(154, 381);
			this.lbMetk.TabIndex = 29;
			this.lbMetk.SelectedIndexChanged += new System.EventHandler(this.lbMetk_SelectedIndexChanged);
			// 
			// lbModel
			// 
			this.lbModel.FormattingEnabled = true;
			this.lbModel.Location = new System.Drawing.Point(181, 30);
			this.lbModel.Name = "lbModel";
			this.lbModel.Size = new System.Drawing.Size(154, 381);
			this.lbModel.TabIndex = 30;
			this.lbModel.SelectedIndexChanged += new System.EventHandler(this.lbModel_SelectedIndexChanged);
			// 
			// lbUsing
			// 
			this.lbUsing.FormattingEnabled = true;
			this.lbUsing.Location = new System.Drawing.Point(350, 30);
			this.lbUsing.Name = "lbUsing";
			this.lbUsing.Size = new System.Drawing.Size(154, 381);
			this.lbUsing.TabIndex = 31;
			this.lbUsing.SelectedIndexChanged += new System.EventHandler(this.lbUsing_SelectedIndexChanged);
			// 
			// lbAction
			// 
			this.lbAction.FormattingEnabled = true;
			this.lbAction.Location = new System.Drawing.Point(519, 30);
			this.lbAction.Name = "lbAction";
			this.lbAction.Size = new System.Drawing.Size(154, 381);
			this.lbAction.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(347, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "Переключатель модели";
			// 
			// bEditMetk
			// 
			this.bEditMetk.Location = new System.Drawing.Point(12, 449);
			this.bEditMetk.Name = "bEditMetk";
			this.bEditMetk.Size = new System.Drawing.Size(154, 23);
			this.bEditMetk.TabIndex = 34;
			this.bEditMetk.Text = "Редактировать";
			this.bEditMetk.UseVisualStyleBackColor = true;
			this.bEditMetk.Click += new System.EventHandler(this.bEditMetk_Click);
			// 
			// bDeleteUsing
			// 
			this.bDeleteUsing.Location = new System.Drawing.Point(350, 478);
			this.bDeleteUsing.Name = "bDeleteUsing";
			this.bDeleteUsing.Size = new System.Drawing.Size(154, 23);
			this.bDeleteUsing.TabIndex = 36;
			this.bDeleteUsing.Text = "Удалить";
			this.bDeleteUsing.UseVisualStyleBackColor = true;
			this.bDeleteUsing.Click += new System.EventHandler(this.bDeleteUsing_Click);
			// 
			// bAddUsing
			// 
			this.bAddUsing.Location = new System.Drawing.Point(350, 420);
			this.bAddUsing.Name = "bAddUsing";
			this.bAddUsing.Size = new System.Drawing.Size(154, 23);
			this.bAddUsing.TabIndex = 35;
			this.bAddUsing.Text = "Добавить переключатель";
			this.bAddUsing.UseVisualStyleBackColor = true;
			this.bAddUsing.Click += new System.EventHandler(this.bAddUsing_Click);
			// 
			// bDeleteMetk
			// 
			this.bDeleteMetk.Location = new System.Drawing.Point(12, 478);
			this.bDeleteMetk.Name = "bDeleteMetk";
			this.bDeleteMetk.Size = new System.Drawing.Size(154, 23);
			this.bDeleteMetk.TabIndex = 38;
			this.bDeleteMetk.Text = "Удалить";
			this.bDeleteMetk.UseVisualStyleBackColor = true;
			this.bDeleteMetk.Click += new System.EventHandler(this.bDeleteMetk_Click);
			// 
			// bDeleteModel
			// 
			this.bDeleteModel.Location = new System.Drawing.Point(181, 478);
			this.bDeleteModel.Name = "bDeleteModel";
			this.bDeleteModel.Size = new System.Drawing.Size(154, 23);
			this.bDeleteModel.TabIndex = 37;
			this.bDeleteModel.Text = "Удалить";
			this.bDeleteModel.UseVisualStyleBackColor = true;
			this.bDeleteModel.Click += new System.EventHandler(this.bDeleteModel_Click);
			// 
			// bEditUsing
			// 
			this.bEditUsing.Location = new System.Drawing.Point(350, 449);
			this.bEditUsing.Name = "bEditUsing";
			this.bEditUsing.Size = new System.Drawing.Size(154, 23);
			this.bEditUsing.TabIndex = 39;
			this.bEditUsing.Text = "Редактировать";
			this.bEditUsing.UseVisualStyleBackColor = true;
			this.bEditUsing.Click += new System.EventHandler(this.bEditUsing_Click);
			// 
			// bSaveAs
			// 
			this.bSaveAs.Location = new System.Drawing.Point(679, 144);
			this.bSaveAs.Name = "bSaveAs";
			this.bSaveAs.Size = new System.Drawing.Size(146, 23);
			this.bSaveAs.TabIndex = 40;
			this.bSaveAs.Text = "Сохранить как";
			this.bSaveAs.UseVisualStyleBackColor = true;
			this.bSaveAs.Click += new System.EventHandler(this.bSaveAs_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// bWYSWIWG
			// 
			this.bWYSWIWG.Location = new System.Drawing.Point(678, 59);
			this.bWYSWIWG.Name = "bWYSWIWG";
			this.bWYSWIWG.Size = new System.Drawing.Size(145, 23);
			this.bWYSWIWG.TabIndex = 41;
			this.bWYSWIWG.Text = "WYSIWYG";
			this.bWYSWIWG.UseVisualStyleBackColor = true;
			this.bWYSWIWG.Click += new System.EventHandler(this.button1_Click);
			// 
			// EditorScene
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 508);
			this.Controls.Add(this.bWYSWIWG);
			this.Controls.Add(this.bSaveAs);
			this.Controls.Add(this.bEditUsing);
			this.Controls.Add(this.bDeleteMetk);
			this.Controls.Add(this.bDeleteModel);
			this.Controls.Add(this.bDeleteUsing);
			this.Controls.Add(this.bAddUsing);
			this.Controls.Add(this.bEditMetk);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbAction);
			this.Controls.Add(this.lbUsing);
			this.Controls.Add(this.lbModel);
			this.Controls.Add(this.lbMetk);
			this.Controls.Add(this.bEditModel);
			this.Controls.Add(this.bAddModel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bLoadScene);
			this.Controls.Add(this.bUploadFTP);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.bPreVision);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.bEditAction);
			this.Controls.Add(this.bAddAction);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bAddMetk);
			this.Name = "EditorScene";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditorScene";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorScene_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bAddMetk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bAddAction;
		private System.Windows.Forms.Button bEditAction;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button bPreVision;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.Button bUploadFTP;
		private System.Windows.Forms.Button bLoadScene;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bAddModel;
		private System.Windows.Forms.Button bEditModel;
		private System.Windows.Forms.ListBox lbMetk;
		private System.Windows.Forms.ListBox lbModel;
		private System.Windows.Forms.ListBox lbUsing;
		private System.Windows.Forms.ListBox lbAction;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bEditMetk;
		private System.Windows.Forms.Button bDeleteUsing;
		private System.Windows.Forms.Button bAddUsing;
		private System.Windows.Forms.Button bDeleteMetk;
		private System.Windows.Forms.Button bDeleteModel;
		private System.Windows.Forms.Button bEditUsing;
		private System.Windows.Forms.Button bSaveAs;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button bWYSWIWG;
	}
}