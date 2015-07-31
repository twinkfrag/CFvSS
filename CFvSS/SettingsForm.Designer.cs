namespace net.twinkfrag.CFvSS
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modKeyContainer = new System.Windows.Forms.GroupBox();
			this.checkBoxAlt = new System.Windows.Forms.CheckBox();
			this.checkBoxCtrl = new System.Windows.Forms.CheckBox();
			this.checkBoxShift = new System.Windows.Forms.CheckBox();
			this.checkBoxWin = new System.Windows.Forms.CheckBox();
			this.hotkey_label = new System.Windows.Forms.Label();
			this.HotKeyBox = new System.Windows.Forms.TextBox();
			this.folderContainer = new System.Windows.Forms.GroupBox();
			this.folderDestLabel = new System.Windows.Forms.Label();
			this.folderBox = new System.Windows.Forms.TextBox();
			this.FolderSelect = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.fileNameContainer = new System.Windows.Forms.GroupBox();
			this.fileDescriptionLabel = new System.Windows.Forms.Label();
			this.fileNameBox = new System.Windows.Forms.TextBox();
			this.RegexContainer = new System.Windows.Forms.GroupBox();
			this.regexOutLabel = new System.Windows.Forms.Label();
			this.regexOutBox = new System.Windows.Forms.TextBox();
			this.RegexInLabel = new System.Windows.Forms.Label();
			this.regexInBox = new System.Windows.Forms.TextBox();
			this.regexTestContainer = new System.Windows.Forms.GroupBox();
			this.regexTestTextLabel = new System.Windows.Forms.Label();
			this.regexTestOutBox = new System.Windows.Forms.TextBox();
			this.regexTestInBox = new System.Windows.Forms.TextBox();
			this.fileTypeLabel = new System.Windows.Forms.Label();
			this.fileTypeComboBox = new System.Windows.Forms.ComboBox();
			this.Save = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.modKeyContainer.SuspendLayout();
			this.folderContainer.SuspendLayout();
			this.fileNameContainer.SuspendLayout();
			this.RegexContainer.SuspendLayout();
			this.regexTestContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(319, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// modKeyContainer
			// 
			this.modKeyContainer.Controls.Add(this.checkBoxAlt);
			this.modKeyContainer.Controls.Add(this.checkBoxCtrl);
			this.modKeyContainer.Controls.Add(this.checkBoxShift);
			this.modKeyContainer.Controls.Add(this.checkBoxWin);
			this.modKeyContainer.Location = new System.Drawing.Point(12, 27);
			this.modKeyContainer.Name = "modKeyContainer";
			this.modKeyContainer.Size = new System.Drawing.Size(211, 45);
			this.modKeyContainer.TabIndex = 10;
			this.modKeyContainer.TabStop = false;
			this.modKeyContainer.Text = "ModKey";
			// 
			// checkBoxAlt
			// 
			this.checkBoxAlt.AutoSize = true;
			this.checkBoxAlt.Location = new System.Drawing.Point(6, 18);
			this.checkBoxAlt.Name = "checkBoxAlt";
			this.checkBoxAlt.Size = new System.Drawing.Size(39, 16);
			this.checkBoxAlt.TabIndex = 11;
			this.checkBoxAlt.Text = "Alt";
			this.checkBoxAlt.UseVisualStyleBackColor = true;
			// 
			// checkBoxCtrl
			// 
			this.checkBoxCtrl.AutoSize = true;
			this.checkBoxCtrl.Location = new System.Drawing.Point(51, 18);
			this.checkBoxCtrl.Name = "checkBoxCtrl";
			this.checkBoxCtrl.Size = new System.Drawing.Size(43, 16);
			this.checkBoxCtrl.TabIndex = 12;
			this.checkBoxCtrl.Text = "Ctrl";
			this.checkBoxCtrl.UseVisualStyleBackColor = true;
			// 
			// checkBoxShift
			// 
			this.checkBoxShift.AutoSize = true;
			this.checkBoxShift.Location = new System.Drawing.Point(100, 18);
			this.checkBoxShift.Name = "checkBoxShift";
			this.checkBoxShift.Size = new System.Drawing.Size(48, 16);
			this.checkBoxShift.TabIndex = 13;
			this.checkBoxShift.Text = "Shift";
			this.checkBoxShift.UseVisualStyleBackColor = true;
			// 
			// checkBoxWin
			// 
			this.checkBoxWin.AutoSize = true;
			this.checkBoxWin.Location = new System.Drawing.Point(152, 18);
			this.checkBoxWin.Name = "checkBoxWin";
			this.checkBoxWin.Size = new System.Drawing.Size(42, 16);
			this.checkBoxWin.TabIndex = 14;
			this.checkBoxWin.Text = "Win";
			this.checkBoxWin.UseVisualStyleBackColor = true;
			// 
			// hotkey_label
			// 
			this.hotkey_label.AutoSize = true;
			this.hotkey_label.Location = new System.Drawing.Point(10, 81);
			this.hotkey_label.Name = "hotkey_label";
			this.hotkey_label.Size = new System.Drawing.Size(42, 12);
			this.hotkey_label.TabIndex = 9;
			this.hotkey_label.Text = "HotKey";
			// 
			// HotKeyBox
			// 
			this.HotKeyBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.HotKeyBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.HotKeyBox.Location = new System.Drawing.Point(58, 78);
			this.HotKeyBox.MaxLength = 1;
			this.HotKeyBox.Name = "HotKeyBox";
			this.HotKeyBox.ShortcutsEnabled = false;
			this.HotKeyBox.Size = new System.Drawing.Size(19, 19);
			this.HotKeyBox.TabIndex = 21;
			// 
			// folderContainer
			// 
			this.folderContainer.Controls.Add(this.folderDestLabel);
			this.folderContainer.Controls.Add(this.folderBox);
			this.folderContainer.Controls.Add(this.FolderSelect);
			this.folderContainer.Location = new System.Drawing.Point(12, 103);
			this.folderContainer.Name = "folderContainer";
			this.folderContainer.Size = new System.Drawing.Size(282, 58);
			this.folderContainer.TabIndex = 30;
			this.folderContainer.TabStop = false;
			this.folderContainer.Text = "フォルダ選択";
			// 
			// folderDestLabel
			// 
			this.folderDestLabel.AutoSize = true;
			this.folderDestLabel.Location = new System.Drawing.Point(6, 40);
			this.folderDestLabel.Name = "folderDestLabel";
			this.folderDestLabel.Size = new System.Drawing.Size(181, 12);
			this.folderDestLabel.TabIndex = 12;
			this.folderDestLabel.Text = "ボタンで選択あるいは相対パスを入力";
			// 
			// folderBox
			// 
			this.folderBox.Location = new System.Drawing.Point(6, 18);
			this.folderBox.Name = "folderBox";
			this.folderBox.Size = new System.Drawing.Size(189, 19);
			this.folderBox.TabIndex = 31;
			// 
			// FolderSelect
			// 
			this.FolderSelect.Location = new System.Drawing.Point(201, 18);
			this.FolderSelect.Name = "FolderSelect";
			this.FolderSelect.Size = new System.Drawing.Size(75, 23);
			this.FolderSelect.TabIndex = 32;
			this.FolderSelect.Text = "選択";
			this.FolderSelect.UseVisualStyleBackColor = true;
			this.FolderSelect.Click += new System.EventHandler(this.FolderSelect_Click);
			// 
			// fileNameContainer
			// 
			this.fileNameContainer.Controls.Add(this.fileDescriptionLabel);
			this.fileNameContainer.Controls.Add(this.fileNameBox);
			this.fileNameContainer.Location = new System.Drawing.Point(12, 167);
			this.fileNameContainer.Name = "fileNameContainer";
			this.fileNameContainer.Size = new System.Drawing.Size(282, 84);
			this.fileNameContainer.TabIndex = 40;
			this.fileNameContainer.TabStop = false;
			this.fileNameContainer.Text = "ファイル名";
			// 
			// fileDescriptionLabel
			// 
			this.fileDescriptionLabel.AutoSize = true;
			this.fileDescriptionLabel.Location = new System.Drawing.Point(6, 40);
			this.fileDescriptionLabel.Name = "fileDescriptionLabel";
			this.fileDescriptionLabel.Size = new System.Drawing.Size(249, 36);
			this.fileDescriptionLabel.TabIndex = 1;
			this.fileDescriptionLabel.Text = "利用可能な置き換え\r\n現在時刻: %yyyy, %yy, %MM, %dd, %HH, %mm, %ss\r\nウインドウタイトル: %wt";
			// 
			// fileNameBox
			// 
			this.fileNameBox.Location = new System.Drawing.Point(6, 18);
			this.fileNameBox.Name = "fileNameBox";
			this.fileNameBox.Size = new System.Drawing.Size(270, 19);
			this.fileNameBox.TabIndex = 41;
			// 
			// RegexContainer
			// 
			this.RegexContainer.Controls.Add(this.regexOutLabel);
			this.RegexContainer.Controls.Add(this.regexOutBox);
			this.RegexContainer.Controls.Add(this.RegexInLabel);
			this.RegexContainer.Controls.Add(this.regexInBox);
			this.RegexContainer.Location = new System.Drawing.Point(12, 257);
			this.RegexContainer.Name = "RegexContainer";
			this.RegexContainer.Size = new System.Drawing.Size(282, 71);
			this.RegexContainer.TabIndex = 50;
			this.RegexContainer.TabStop = false;
			this.RegexContainer.Text = "正規表現置換";
			// 
			// regexOutLabel
			// 
			this.regexOutLabel.AutoSize = true;
			this.regexOutLabel.Location = new System.Drawing.Point(4, 46);
			this.regexOutLabel.Name = "regexOutLabel";
			this.regexOutLabel.Size = new System.Drawing.Size(53, 12);
			this.regexOutLabel.TabIndex = 3;
			this.regexOutLabel.Text = "置換出力";
			// 
			// regexOutBox
			// 
			this.regexOutBox.Location = new System.Drawing.Point(63, 43);
			this.regexOutBox.Name = "regexOutBox";
			this.regexOutBox.Size = new System.Drawing.Size(213, 19);
			this.regexOutBox.TabIndex = 52;
			// 
			// RegexInLabel
			// 
			this.RegexInLabel.AutoSize = true;
			this.RegexInLabel.Location = new System.Drawing.Point(4, 21);
			this.RegexInLabel.Name = "RegexInLabel";
			this.RegexInLabel.Size = new System.Drawing.Size(53, 12);
			this.RegexInLabel.TabIndex = 1;
			this.RegexInLabel.Text = "置換対象";
			// 
			// regexInBox
			// 
			this.regexInBox.Location = new System.Drawing.Point(63, 18);
			this.regexInBox.Name = "regexInBox";
			this.regexInBox.Size = new System.Drawing.Size(213, 19);
			this.regexInBox.TabIndex = 51;
			// 
			// regexTestContainer
			// 
			this.regexTestContainer.Controls.Add(this.regexTestTextLabel);
			this.regexTestContainer.Controls.Add(this.regexTestOutBox);
			this.regexTestContainer.Controls.Add(this.regexTestInBox);
			this.regexTestContainer.Location = new System.Drawing.Point(12, 334);
			this.regexTestContainer.Name = "regexTestContainer";
			this.regexTestContainer.Size = new System.Drawing.Size(282, 96);
			this.regexTestContainer.TabIndex = 60;
			this.regexTestContainer.TabStop = false;
			this.regexTestContainer.Text = "置換テスト";
			// 
			// regexTestTextLabel
			// 
			this.regexTestTextLabel.AutoSize = true;
			this.regexTestTextLabel.Location = new System.Drawing.Point(4, 40);
			this.regexTestTextLabel.Name = "regexTestTextLabel";
			this.regexTestTextLabel.Size = new System.Drawing.Size(246, 24);
			this.regexTestTextLabel.TabIndex = 2;
			this.regexTestTextLabel.Text = "上のテキストボックスをウインドウタイトルとした場合の\r\n置換結果を表示します(保存後に反映)";
			// 
			// regexTestOutBox
			// 
			this.regexTestOutBox.Location = new System.Drawing.Point(6, 67);
			this.regexTestOutBox.Name = "regexTestOutBox";
			this.regexTestOutBox.ReadOnly = true;
			this.regexTestOutBox.Size = new System.Drawing.Size(270, 19);
			this.regexTestOutBox.TabIndex = 62;
			this.regexTestOutBox.TabStop = false;
			// 
			// regexTestInBox
			// 
			this.regexTestInBox.Location = new System.Drawing.Point(6, 18);
			this.regexTestInBox.Name = "regexTestInBox";
			this.regexTestInBox.Size = new System.Drawing.Size(270, 19);
			this.regexTestInBox.TabIndex = 61;
			this.regexTestInBox.TextChanged += new System.EventHandler(this.regexTestInBox_TextChanged);
			// 
			// fileTypeLabel
			// 
			this.fileTypeLabel.AutoSize = true;
			this.fileTypeLabel.Location = new System.Drawing.Point(10, 439);
			this.fileTypeLabel.Name = "fileTypeLabel";
			this.fileTypeLabel.Size = new System.Drawing.Size(65, 12);
			this.fileTypeLabel.TabIndex = 15;
			this.fileTypeLabel.Text = "ファイルタイプ";
			// 
			// fileTypeComboBox
			// 
			this.fileTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fileTypeComboBox.FormattingEnabled = true;
			this.fileTypeComboBox.Items.AddRange(new object[] {
            "Png",
            "Jpg",
            "Bmp"});
			this.fileTypeComboBox.Location = new System.Drawing.Point(81, 436);
			this.fileTypeComboBox.Name = "fileTypeComboBox";
			this.fileTypeComboBox.Size = new System.Drawing.Size(53, 20);
			this.fileTypeComboBox.TabIndex = 71;
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(12, 462);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 91;
			this.Save.Text = "保存";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(93, 462);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 23);
			this.ResetButton.TabIndex = 92;
			this.ResetButton.Text = "変更を破棄";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 497);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.regexTestContainer);
			this.Controls.Add(this.RegexContainer);
			this.Controls.Add(this.fileTypeLabel);
			this.Controls.Add(this.fileTypeComboBox);
			this.Controls.Add(this.fileNameContainer);
			this.Controls.Add(this.folderContainer);
			this.Controls.Add(this.modKeyContainer);
			this.Controls.Add(this.hotkey_label);
			this.Controls.Add(this.HotKeyBox);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SettingsForm";
			this.Text = "せってーい";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.modKeyContainer.ResumeLayout(false);
			this.modKeyContainer.PerformLayout();
			this.folderContainer.ResumeLayout(false);
			this.folderContainer.PerformLayout();
			this.fileNameContainer.ResumeLayout(false);
			this.fileNameContainer.PerformLayout();
			this.RegexContainer.ResumeLayout(false);
			this.RegexContainer.PerformLayout();
			this.regexTestContainer.ResumeLayout(false);
			this.regexTestContainer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxCtrl;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkBoxAlt;
		private System.Windows.Forms.CheckBox checkBoxShift;
		private System.Windows.Forms.CheckBox checkBoxWin;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.TextBox HotKeyBox;
		private System.Windows.Forms.Label hotkey_label;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button FolderSelect;
		private System.Windows.Forms.TextBox folderBox;
		private System.Windows.Forms.GroupBox modKeyContainer;
		private System.Windows.Forms.GroupBox folderContainer;
		private System.Windows.Forms.Label folderDestLabel;
		private System.Windows.Forms.GroupBox fileNameContainer;
		private System.Windows.Forms.Label fileDescriptionLabel;
		private System.Windows.Forms.TextBox fileNameBox;
		private System.Windows.Forms.Label fileTypeLabel;
		private System.Windows.Forms.GroupBox RegexContainer;
		private System.Windows.Forms.TextBox regexInBox;
		private System.Windows.Forms.Label regexOutLabel;
		private System.Windows.Forms.TextBox regexOutBox;
		private System.Windows.Forms.Label RegexInLabel;
		private System.Windows.Forms.ComboBox fileTypeComboBox;
		private System.Windows.Forms.GroupBox regexTestContainer;
		private System.Windows.Forms.Label regexTestTextLabel;
		private System.Windows.Forms.TextBox regexTestOutBox;
		private System.Windows.Forms.TextBox regexTestInBox;
		private System.Windows.Forms.Button ResetButton;
	}
}