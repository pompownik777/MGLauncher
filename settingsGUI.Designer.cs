namespace MGLauncher
{
    partial class settingsGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.checkboxinfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.hidingcheckbox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.rambox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 16;
            this.bunifuPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(392, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(33, 33);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // checkboxinfo
            // 
            this.checkboxinfo.AllowParentOverrides = false;
            this.checkboxinfo.AutoEllipsis = false;
            this.checkboxinfo.CursorType = null;
            this.checkboxinfo.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxinfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkboxinfo.Location = new System.Drawing.Point(66, 80);
            this.checkboxinfo.Name = "checkboxinfo";
            this.checkboxinfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkboxinfo.Size = new System.Drawing.Size(352, 18);
            this.checkboxinfo.TabIndex = 9;
            this.checkboxinfo.Text = "Zminimalizuj launcher do traya po włączeniu Minecrafta";
            this.checkboxinfo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.checkboxinfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // hidingcheckbox
            // 
            this.hidingcheckbox.AllowBindingControlAnimation = true;
            this.hidingcheckbox.AllowBindingControlColorChanges = false;
            this.hidingcheckbox.AllowBindingControlLocation = true;
            this.hidingcheckbox.AllowCheckBoxAnimation = false;
            this.hidingcheckbox.AllowCheckmarkAnimation = true;
            this.hidingcheckbox.AllowOnHoverStates = true;
            this.hidingcheckbox.AutoCheck = true;
            this.hidingcheckbox.BackColor = System.Drawing.Color.Transparent;
            this.hidingcheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidingcheckbox.BackgroundImage")));
            this.hidingcheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hidingcheckbox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.hidingcheckbox.BorderRadius = 12;
            this.hidingcheckbox.Checked = false;
            this.hidingcheckbox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.hidingcheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.hidingcheckbox.CustomCheckmarkImage = null;
            this.hidingcheckbox.Location = new System.Drawing.Point(39, 77);
            this.hidingcheckbox.MinimumSize = new System.Drawing.Size(17, 17);
            this.hidingcheckbox.Name = "hidingcheckbox";
            this.hidingcheckbox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.hidingcheckbox.OnCheck.BorderRadius = 12;
            this.hidingcheckbox.OnCheck.BorderThickness = 2;
            this.hidingcheckbox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.hidingcheckbox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.hidingcheckbox.OnCheck.CheckmarkThickness = 2;
            this.hidingcheckbox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.hidingcheckbox.OnDisable.BorderRadius = 12;
            this.hidingcheckbox.OnDisable.BorderThickness = 2;
            this.hidingcheckbox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.hidingcheckbox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.hidingcheckbox.OnDisable.CheckmarkThickness = 2;
            this.hidingcheckbox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hidingcheckbox.OnHoverChecked.BorderRadius = 12;
            this.hidingcheckbox.OnHoverChecked.BorderThickness = 2;
            this.hidingcheckbox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hidingcheckbox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.hidingcheckbox.OnHoverChecked.CheckmarkThickness = 2;
            this.hidingcheckbox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hidingcheckbox.OnHoverUnchecked.BorderRadius = 12;
            this.hidingcheckbox.OnHoverUnchecked.BorderThickness = 1;
            this.hidingcheckbox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.hidingcheckbox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.hidingcheckbox.OnUncheck.BorderRadius = 12;
            this.hidingcheckbox.OnUncheck.BorderThickness = 1;
            this.hidingcheckbox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.hidingcheckbox.Size = new System.Drawing.Size(21, 21);
            this.hidingcheckbox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.hidingcheckbox.TabIndex = 8;
            this.hidingcheckbox.ThreeState = false;
            this.hidingcheckbox.ToolTipText = null;
            this.hidingcheckbox.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.hidingcheckbox_CheckedChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(105, 16);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(215, 29);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Ustawienia launchera";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(133, 131);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(161, 18);
            this.bunifuLabel2.TabIndex = 11;
            this.bunifuLabel2.Text = "Przydzielony RAM do MC:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // rambox
            // 
            this.rambox.AcceptsReturn = false;
            this.rambox.AcceptsTab = false;
            this.rambox.AnimationSpeed = 200;
            this.rambox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.rambox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.rambox.BackColor = System.Drawing.Color.Transparent;
            this.rambox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rambox.BackgroundImage")));
            this.rambox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.rambox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rambox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.rambox.BorderColorIdle = System.Drawing.Color.Silver;
            this.rambox.BorderRadius = 15;
            this.rambox.BorderThickness = 1;
            this.rambox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.rambox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rambox.DefaultFont = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rambox.DefaultText = "2048";
            this.rambox.FillColor = System.Drawing.Color.White;
            this.rambox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rambox.HideSelection = true;
            this.rambox.IconLeft = null;
            this.rambox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.rambox.IconPadding = 10;
            this.rambox.IconRight = null;
            this.rambox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.rambox.Lines = new string[] {
        "2048"};
            this.rambox.Location = new System.Drawing.Point(133, 167);
            this.rambox.MaxLength = 12000;
            this.rambox.MinimumSize = new System.Drawing.Size(1, 1);
            this.rambox.Modified = false;
            this.rambox.Multiline = false;
            this.rambox.Name = "rambox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.rambox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.rambox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.rambox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.rambox.OnIdleState = stateProperties8;
            this.rambox.Padding = new System.Windows.Forms.Padding(3);
            this.rambox.PasswordChar = '\0';
            this.rambox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.rambox.PlaceholderText = "w MB (np. 4096)";
            this.rambox.ReadOnly = false;
            this.rambox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rambox.SelectedText = "";
            this.rambox.SelectionLength = 0;
            this.rambox.SelectionStart = 4;
            this.rambox.ShortcutsEnabled = true;
            this.rambox.Size = new System.Drawing.Size(161, 36);
            this.rambox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.rambox.TabIndex = 12;
            this.rambox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rambox.TextMarginBottom = 0;
            this.rambox.TextMarginLeft = 3;
            this.rambox.TextMarginTop = 0;
            this.rambox.TextPlaceholder = "w MB (np. 4096)";
            this.rambox.UseSystemPasswordChar = false;
            this.rambox.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ustawienia zapisują się automatycznie.";
            // 
            // settingsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rambox);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.checkboxinfo);
            this.Controls.Add(this.hidingcheckbox);
            this.Controls.Add(this.bunifuPictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.settingsGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel checkboxinfo;
        private Bunifu.UI.WinForms.BunifuCheckBox hidingcheckbox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox rambox;
        private System.Windows.Forms.Label label1;
    }
}