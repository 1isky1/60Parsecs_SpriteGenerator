namespace _60_Parsecs_Sprite_Generator
{
	partial class GenForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenForm));
			this.NamesList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupGStats = new System.Windows.Forms.GroupBox();
			this.buttDead = new System.Windows.Forms.RadioButton();
			this.buttComm = new System.Windows.Forms.RadioButton();
			this.buttAndr = new System.Windows.Forms.RadioButton();
			this.buttAlien = new System.Windows.Forms.RadioButton();
			this.buttWFed = new System.Windows.Forms.RadioButton();
			this.buttStarv = new System.Windows.Forms.RadioButton();
			this.buttNormal = new System.Windows.Forms.RadioButton();
			this.groupHair = new System.Windows.Forms.GroupBox();
			this.buttH0 = new System.Windows.Forms.RadioButton();
			this.buttH3 = new System.Windows.Forms.RadioButton();
			this.buttH2 = new System.Windows.Forms.RadioButton();
			this.buttH1 = new System.Windows.Forms.RadioButton();
			this.checkInjr = new System.Windows.Forms.CheckBox();
			this.checkSick = new System.Windows.Forms.CheckBox();
			this.checkWeak = new System.Windows.Forms.CheckBox();
			this.checkHero = new System.Windows.Forms.CheckBox();
			this.groupMor = new System.Windows.Forms.GroupBox();
			this.buttMorNor = new System.Windows.Forms.RadioButton();
			this.buttMorDown = new System.Windows.Forms.RadioButton();
			this.buttMorUp = new System.Windows.Forms.RadioButton();
			this.checkIns = new System.Windows.Forms.CheckBox();
			this.groupOStats = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSpriteAssItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBSprite = new System.Windows.Forms.GroupBox();
			this.PBoxSprite = new System.Windows.Forms.PictureBox();
			this.verLabel = new System.Windows.Forms.Label();
			this.groupGStats.SuspendLayout();
			this.groupHair.SuspendLayout();
			this.groupMor.SuspendLayout();
			this.groupOStats.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBSprite.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBoxSprite)).BeginInit();
			this.SuspendLayout();
			// 
			// NamesList
			// 
			this.NamesList.BackColor = System.Drawing.SystemColors.Window;
			this.NamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.NamesList.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NamesList.FormattingEnabled = true;
			this.NamesList.Items.AddRange(new object[] {
            "April",
            "Baby",
            "Deedee",
            "Emmet",
            "Maegan",
            "Tom"});
			this.NamesList.Location = new System.Drawing.Point(92, 35);
			this.NamesList.Name = "NamesList";
			this.NamesList.Size = new System.Drawing.Size(160, 21);
			this.NamesList.TabIndex = 1;
			this.NamesList.SelectedIndexChanged += new System.EventHandler(this.NamesListCharactChanged);
			this.NamesList.TextChanged += new System.EventHandler(this.changedEvent);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(23, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Character";
			// 
			// groupGStats
			// 
			this.groupGStats.BackColor = System.Drawing.Color.Transparent;
			this.groupGStats.Controls.Add(this.buttDead);
			this.groupGStats.Controls.Add(this.buttComm);
			this.groupGStats.Controls.Add(this.buttAndr);
			this.groupGStats.Controls.Add(this.buttAlien);
			this.groupGStats.Controls.Add(this.buttWFed);
			this.groupGStats.Controls.Add(this.buttStarv);
			this.groupGStats.Controls.Add(this.buttNormal);
			this.groupGStats.Enabled = false;
			this.groupGStats.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupGStats.Location = new System.Drawing.Point(26, 62);
			this.groupGStats.Name = "groupGStats";
			this.groupGStats.Size = new System.Drawing.Size(373, 83);
			this.groupGStats.TabIndex = 3;
			this.groupGStats.TabStop = false;
			this.groupGStats.Text = "General status";
			// 
			// buttDead
			// 
			this.buttDead.AutoSize = true;
			this.buttDead.Location = new System.Drawing.Point(299, 35);
			this.buttDead.Name = "buttDead";
			this.buttDead.Size = new System.Drawing.Size(51, 17);
			this.buttDead.TabIndex = 15;
			this.buttDead.TabStop = true;
			this.buttDead.Text = "Dead";
			this.buttDead.UseVisualStyleBackColor = true;
			this.buttDead.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttComm
			// 
			this.buttComm.AutoSize = true;
			this.buttComm.Location = new System.Drawing.Point(198, 51);
			this.buttComm.Name = "buttComm";
			this.buttComm.Size = new System.Drawing.Size(76, 17);
			this.buttComm.TabIndex = 15;
			this.buttComm.TabStop = true;
			this.buttComm.Text = "Communist";
			this.buttComm.UseVisualStyleBackColor = true;
			this.buttComm.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttAndr
			// 
			this.buttAndr.AutoSize = true;
			this.buttAndr.Location = new System.Drawing.Point(103, 51);
			this.buttAndr.Name = "buttAndr";
			this.buttAndr.Size = new System.Drawing.Size(61, 17);
			this.buttAndr.TabIndex = 15;
			this.buttAndr.TabStop = true;
			this.buttAndr.Text = "Android";
			this.buttAndr.UseVisualStyleBackColor = true;
			this.buttAndr.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttAlien
			// 
			this.buttAlien.AutoSize = true;
			this.buttAlien.Location = new System.Drawing.Point(17, 51);
			this.buttAlien.Name = "buttAlien";
			this.buttAlien.Size = new System.Drawing.Size(48, 17);
			this.buttAlien.TabIndex = 15;
			this.buttAlien.TabStop = true;
			this.buttAlien.Text = "Alien";
			this.buttAlien.UseVisualStyleBackColor = true;
			this.buttAlien.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttWFed
			// 
			this.buttWFed.AutoSize = true;
			this.buttWFed.Location = new System.Drawing.Point(198, 19);
			this.buttWFed.Name = "buttWFed";
			this.buttWFed.Size = new System.Drawing.Size(64, 17);
			this.buttWFed.TabIndex = 6;
			this.buttWFed.TabStop = true;
			this.buttWFed.Text = "WellFed";
			this.buttWFed.UseVisualStyleBackColor = true;
			this.buttWFed.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttStarv
			// 
			this.buttStarv.AutoSize = true;
			this.buttStarv.Location = new System.Drawing.Point(103, 19);
			this.buttStarv.Name = "buttStarv";
			this.buttStarv.Size = new System.Drawing.Size(64, 17);
			this.buttStarv.TabIndex = 5;
			this.buttStarv.TabStop = true;
			this.buttStarv.Text = "Starving";
			this.buttStarv.UseVisualStyleBackColor = true;
			this.buttStarv.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttNormal
			// 
			this.buttNormal.AutoSize = true;
			this.buttNormal.Location = new System.Drawing.Point(17, 19);
			this.buttNormal.Name = "buttNormal";
			this.buttNormal.Size = new System.Drawing.Size(58, 17);
			this.buttNormal.TabIndex = 4;
			this.buttNormal.TabStop = true;
			this.buttNormal.Text = "Normal";
			this.buttNormal.UseVisualStyleBackColor = true;
			this.buttNormal.Click += new System.EventHandler(this.changedEvent);
			// 
			// groupHair
			// 
			this.groupHair.BackColor = System.Drawing.Color.Transparent;
			this.groupHair.Controls.Add(this.buttH0);
			this.groupHair.Controls.Add(this.buttH3);
			this.groupHair.Controls.Add(this.buttH2);
			this.groupHair.Controls.Add(this.buttH1);
			this.groupHair.Enabled = false;
			this.groupHair.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupHair.Location = new System.Drawing.Point(26, 165);
			this.groupHair.Name = "groupHair";
			this.groupHair.Size = new System.Drawing.Size(373, 40);
			this.groupHair.TabIndex = 5;
			this.groupHair.TabStop = false;
			this.groupHair.Text = "Hair progress";
			// 
			// buttH0
			// 
			this.buttH0.AutoSize = true;
			this.buttH0.Location = new System.Drawing.Point(19, 17);
			this.buttH0.Name = "buttH0";
			this.buttH0.Size = new System.Drawing.Size(50, 17);
			this.buttH0.TabIndex = 7;
			this.buttH0.TabStop = true;
			this.buttH0.Text = "Hair0";
			this.buttH0.UseVisualStyleBackColor = true;
			this.buttH0.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttH3
			// 
			this.buttH3.AutoSize = true;
			this.buttH3.Location = new System.Drawing.Point(245, 17);
			this.buttH3.Name = "buttH3";
			this.buttH3.Size = new System.Drawing.Size(50, 17);
			this.buttH3.TabIndex = 6;
			this.buttH3.TabStop = true;
			this.buttH3.Text = "Hair3";
			this.buttH3.UseVisualStyleBackColor = true;
			this.buttH3.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttH2
			// 
			this.buttH2.AutoSize = true;
			this.buttH2.Location = new System.Drawing.Point(173, 17);
			this.buttH2.Name = "buttH2";
			this.buttH2.Size = new System.Drawing.Size(50, 17);
			this.buttH2.TabIndex = 6;
			this.buttH2.TabStop = true;
			this.buttH2.Text = "Hair2";
			this.buttH2.UseVisualStyleBackColor = true;
			this.buttH2.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttH1
			// 
			this.buttH1.AutoSize = true;
			this.buttH1.Location = new System.Drawing.Point(92, 17);
			this.buttH1.Name = "buttH1";
			this.buttH1.Size = new System.Drawing.Size(50, 17);
			this.buttH1.TabIndex = 6;
			this.buttH1.TabStop = true;
			this.buttH1.Text = "Hair1";
			this.buttH1.UseVisualStyleBackColor = true;
			this.buttH1.Click += new System.EventHandler(this.changedEvent);
			// 
			// checkInjr
			// 
			this.checkInjr.AutoSize = true;
			this.checkInjr.Location = new System.Drawing.Point(19, 42);
			this.checkInjr.Name = "checkInjr";
			this.checkInjr.Size = new System.Drawing.Size(46, 17);
			this.checkInjr.TabIndex = 6;
			this.checkInjr.Text = "Hurt";
			this.checkInjr.UseVisualStyleBackColor = true;
			this.checkInjr.Click += new System.EventHandler(this.changedEvent);
			// 
			// checkSick
			// 
			this.checkSick.AutoSize = true;
			this.checkSick.Location = new System.Drawing.Point(19, 65);
			this.checkSick.Name = "checkSick";
			this.checkSick.Size = new System.Drawing.Size(47, 17);
			this.checkSick.TabIndex = 7;
			this.checkSick.Text = "Sick";
			this.checkSick.UseVisualStyleBackColor = true;
			this.checkSick.Click += new System.EventHandler(this.changedEvent);
			// 
			// checkWeak
			// 
			this.checkWeak.AutoSize = true;
			this.checkWeak.Location = new System.Drawing.Point(19, 88);
			this.checkWeak.Name = "checkWeak";
			this.checkWeak.Size = new System.Drawing.Size(55, 17);
			this.checkWeak.TabIndex = 8;
			this.checkWeak.Text = "Weak";
			this.checkWeak.UseVisualStyleBackColor = true;
			this.checkWeak.Click += new System.EventHandler(this.changedEvent);
			// 
			// checkHero
			// 
			this.checkHero.AutoSize = true;
			this.checkHero.Location = new System.Drawing.Point(19, 111);
			this.checkHero.Name = "checkHero";
			this.checkHero.Size = new System.Drawing.Size(49, 17);
			this.checkHero.TabIndex = 9;
			this.checkHero.Text = "Hero";
			this.checkHero.UseVisualStyleBackColor = true;
			this.checkHero.Click += new System.EventHandler(this.changedEvent);
			// 
			// groupMor
			// 
			this.groupMor.BackColor = System.Drawing.Color.Transparent;
			this.groupMor.Controls.Add(this.buttMorNor);
			this.groupMor.Controls.Add(this.buttMorDown);
			this.groupMor.Controls.Add(this.buttMorUp);
			this.groupMor.Enabled = false;
			this.groupMor.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupMor.Location = new System.Drawing.Point(26, 227);
			this.groupMor.Name = "groupMor";
			this.groupMor.Size = new System.Drawing.Size(373, 47);
			this.groupMor.TabIndex = 10;
			this.groupMor.TabStop = false;
			this.groupMor.Text = "Morale";
			// 
			// buttMorNor
			// 
			this.buttMorNor.AutoSize = true;
			this.buttMorNor.Location = new System.Drawing.Point(17, 19);
			this.buttMorNor.Name = "buttMorNor";
			this.buttMorNor.Size = new System.Drawing.Size(58, 17);
			this.buttMorNor.TabIndex = 11;
			this.buttMorNor.TabStop = true;
			this.buttMorNor.Text = "Normal";
			this.buttMorNor.UseVisualStyleBackColor = true;
			this.buttMorNor.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttMorDown
			// 
			this.buttMorDown.AutoSize = true;
			this.buttMorDown.Location = new System.Drawing.Point(173, 19);
			this.buttMorDown.Name = "buttMorDown";
			this.buttMorDown.Size = new System.Drawing.Size(53, 17);
			this.buttMorDown.TabIndex = 11;
			this.buttMorDown.TabStop = true;
			this.buttMorDown.Text = "Down";
			this.buttMorDown.UseVisualStyleBackColor = true;
			this.buttMorDown.Click += new System.EventHandler(this.changedEvent);
			// 
			// buttMorUp
			// 
			this.buttMorUp.AutoSize = true;
			this.buttMorUp.Location = new System.Drawing.Point(103, 19);
			this.buttMorUp.Name = "buttMorUp";
			this.buttMorUp.Size = new System.Drawing.Size(39, 17);
			this.buttMorUp.TabIndex = 11;
			this.buttMorUp.TabStop = true;
			this.buttMorUp.Text = "Up";
			this.buttMorUp.UseVisualStyleBackColor = true;
			this.buttMorUp.Click += new System.EventHandler(this.changedEvent);
			// 
			// checkIns
			// 
			this.checkIns.AutoSize = true;
			this.checkIns.Location = new System.Drawing.Point(19, 19);
			this.checkIns.Name = "checkIns";
			this.checkIns.Size = new System.Drawing.Size(58, 17);
			this.checkIns.TabIndex = 11;
			this.checkIns.Text = "Insane";
			this.checkIns.UseVisualStyleBackColor = true;
			this.checkIns.Click += new System.EventHandler(this.changedEvent);
			// 
			// groupOStats
			// 
			this.groupOStats.BackColor = System.Drawing.Color.Transparent;
			this.groupOStats.Controls.Add(this.checkIns);
			this.groupOStats.Controls.Add(this.checkInjr);
			this.groupOStats.Controls.Add(this.checkSick);
			this.groupOStats.Controls.Add(this.checkWeak);
			this.groupOStats.Controls.Add(this.checkHero);
			this.groupOStats.Enabled = false;
			this.groupOStats.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupOStats.Location = new System.Drawing.Point(26, 299);
			this.groupOStats.Name = "groupOStats";
			this.groupOStats.Size = new System.Drawing.Size(200, 133);
			this.groupOStats.TabIndex = 14;
			this.groupOStats.TabStop = false;
			this.groupOStats.Text = "Other statuses";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(954, 24);
			this.menuStrip1.TabIndex = 16;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSpriteAssItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveSpriteAssItem
			// 
			this.saveSpriteAssItem.BackColor = System.Drawing.SystemColors.Control;
			this.saveSpriteAssItem.Name = "saveSpriteAssItem";
			this.saveSpriteAssItem.Size = new System.Drawing.Size(180, 22);
			this.saveSpriteAssItem.Text = "Save Sprite to PNG";
			this.saveSpriteAssItem.Click += new System.EventHandler(this.saveSpriteAsToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeThemeToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// changeThemeToolStripMenuItem
			// 
			this.changeThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
			this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
			this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.changeThemeToolStripMenuItem.Text = "Change theme";
			// 
			// darkToolStripMenuItem
			// 
			this.darkToolStripMenuItem.CheckOnClick = true;
			this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
			this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.darkToolStripMenuItem.Text = "Dark";
			this.darkToolStripMenuItem.Click += new System.EventHandler(this.DarkThemeSelect);
			// 
			// lightToolStripMenuItem
			// 
			this.lightToolStripMenuItem.Checked = true;
			this.lightToolStripMenuItem.CheckOnClick = true;
			this.lightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
			this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.lightToolStripMenuItem.Text = "Light";
			this.lightToolStripMenuItem.Click += new System.EventHandler(this.LightThemeSelect);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(12, 769);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(287, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "All rights reserved, Original 60 Parsecs @ Robot Gentleman";
			// 
			// groupBSprite
			// 
			this.groupBSprite.BackColor = System.Drawing.Color.Transparent;
			this.groupBSprite.Controls.Add(this.PBoxSprite);
			this.groupBSprite.Location = new System.Drawing.Point(430, 35);
			this.groupBSprite.Name = "groupBSprite";
			this.groupBSprite.Size = new System.Drawing.Size(513, 749);
			this.groupBSprite.TabIndex = 18;
			this.groupBSprite.TabStop = false;
			this.groupBSprite.Text = "SpriteView";
			// 
			// PBoxSprite
			// 
			this.PBoxSprite.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PBoxSprite.BackColor = System.Drawing.Color.DarkGray;
			this.PBoxSprite.BackgroundImage = global::_60_Parsecs_Sprite_Generator.Properties.Resources.BackShut;
			this.PBoxSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PBoxSprite.Location = new System.Drawing.Point(18, 19);
			this.PBoxSprite.Name = "PBoxSprite";
			this.PBoxSprite.Size = new System.Drawing.Size(480, 720);
			this.PBoxSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PBoxSprite.TabIndex = 0;
			this.PBoxSprite.TabStop = false;
			// 
			// verLabel
			// 
			this.verLabel.AutoSize = true;
			this.verLabel.Location = new System.Drawing.Point(12, 746);
			this.verLabel.Name = "verLabel";
			this.verLabel.Size = new System.Drawing.Size(69, 13);
			this.verLabel.TabIndex = 19;
			this.verLabel.Text = "v0.1.0_alpha";
			// 
			// GenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(954, 791);
			this.Controls.Add(this.verLabel);
			this.Controls.Add(this.groupBSprite);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupOStats);
			this.Controls.Add(this.groupMor);
			this.Controls.Add(this.groupHair);
			this.Controls.Add(this.groupGStats);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NamesList);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "GenForm";
			this.Text = "60 Parsecs Sprite Generator";
			this.groupGStats.ResumeLayout(false);
			this.groupGStats.PerformLayout();
			this.groupHair.ResumeLayout(false);
			this.groupHair.PerformLayout();
			this.groupMor.ResumeLayout(false);
			this.groupMor.PerformLayout();
			this.groupOStats.ResumeLayout(false);
			this.groupOStats.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBSprite.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PBoxSprite)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PBoxSprite;
		private System.Windows.Forms.ComboBox NamesList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupGStats;
		private System.Windows.Forms.RadioButton buttStarv;
		private System.Windows.Forms.RadioButton buttNormal;
		private System.Windows.Forms.RadioButton buttWFed;
		private System.Windows.Forms.GroupBox groupHair;
		private System.Windows.Forms.RadioButton buttH3;
		private System.Windows.Forms.RadioButton buttH2;
		private System.Windows.Forms.RadioButton buttH1;
		private System.Windows.Forms.CheckBox checkInjr;
		private System.Windows.Forms.CheckBox checkSick;
		private System.Windows.Forms.CheckBox checkWeak;
		private System.Windows.Forms.CheckBox checkHero;
		private System.Windows.Forms.GroupBox groupMor;
		private System.Windows.Forms.RadioButton buttMorDown;
		private System.Windows.Forms.RadioButton buttMorUp;
		private System.Windows.Forms.RadioButton buttMorNor;
		private System.Windows.Forms.CheckBox checkIns;
		private System.Windows.Forms.GroupBox groupOStats;
		private System.Windows.Forms.RadioButton buttDead;
		private System.Windows.Forms.RadioButton buttComm;
		private System.Windows.Forms.RadioButton buttAndr;
		private System.Windows.Forms.RadioButton buttAlien;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSpriteAssItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton buttH0;
		private System.Windows.Forms.GroupBox groupBSprite;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.Label verLabel;
	}
}

