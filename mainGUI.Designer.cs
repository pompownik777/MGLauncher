namespace MGLauncher
{
    partial class mainGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.logo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.closepic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.minpic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.discordpic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.checkboxinfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.loggedinas = new Bunifu.UI.WinForms.BunifuLabel();
            this.loggeduser = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.settingsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.launchButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.downloadlabel = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discordpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AllowFocused = false;
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.AutoSizeHeight = false;
            this.logo.BorderRadius = 132;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.IsCircle = true;
            this.logo.Location = new System.Drawing.Point(260, -43);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(265, 265);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // closepic
            // 
            this.closepic.AllowFocused = false;
            this.closepic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closepic.AutoSizeHeight = false;
            this.closepic.BorderRadius = 19;
            this.closepic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closepic.Image = ((System.Drawing.Image)(resources.GetObject("closepic.Image")));
            this.closepic.IsCircle = true;
            this.closepic.Location = new System.Drawing.Point(683, 21);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(39, 39);
            this.closepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepic.TabIndex = 2;
            this.closepic.TabStop = false;
            this.closepic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // minpic
            // 
            this.minpic.AllowFocused = false;
            this.minpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minpic.AutoSizeHeight = false;
            this.minpic.BorderRadius = 19;
            this.minpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minpic.Image = ((System.Drawing.Image)(resources.GetObject("minpic.Image")));
            this.minpic.IsCircle = true;
            this.minpic.Location = new System.Drawing.Point(639, 22);
            this.minpic.Name = "minpic";
            this.minpic.Size = new System.Drawing.Size(39, 39);
            this.minpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minpic.TabIndex = 3;
            this.minpic.TabStop = false;
            this.minpic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.minpic.Click += new System.EventHandler(this.minpic_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel1.Location = new System.Drawing.Point(13, 371);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(73, 18);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Wersja: 2.0";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // discordpic
            // 
            this.discordpic.AllowFocused = false;
            this.discordpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discordpic.AutoSizeHeight = false;
            this.discordpic.BorderRadius = 24;
            this.discordpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordpic.Image = ((System.Drawing.Image)(resources.GetObject("discordpic.Image")));
            this.discordpic.IsCircle = true;
            this.discordpic.Location = new System.Drawing.Point(690, 340);
            this.discordpic.Name = "discordpic";
            this.discordpic.Size = new System.Drawing.Size(48, 48);
            this.discordpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.discordpic.TabIndex = 5;
            this.discordpic.TabStop = false;
            this.discordpic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.discordpic.Click += new System.EventHandler(this.bunifuPictureBox4_Click);
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.BorderRadius = 12;
            this.bunifuCheckBox1.Checked = false;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(229, 337);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 6;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            this.bunifuCheckBox1.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.bunifuCheckBox1_CheckedChanged);
            // 
            // checkboxinfo
            // 
            this.checkboxinfo.AllowParentOverrides = false;
            this.checkboxinfo.AutoEllipsis = false;
            this.checkboxinfo.AutoSize = false;
            this.checkboxinfo.CursorType = null;
            this.checkboxinfo.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxinfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkboxinfo.Location = new System.Drawing.Point(256, 340);
            this.checkboxinfo.Name = "checkboxinfo";
            this.checkboxinfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkboxinfo.Size = new System.Drawing.Size(314, 18);
            this.checkboxinfo.TabIndex = 7;
            this.checkboxinfo.Text = "Akceptuje regulamin korzystania z paczki modów.";
            this.checkboxinfo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.checkboxinfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MGLauncher";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(13, 12);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(112, 18);
            this.bunifuLabel2.TabIndex = 9;
            this.bunifuLabel2.Text = "Zalogowano jako: ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // loggedinas
            // 
            this.loggedinas.AllowParentOverrides = false;
            this.loggedinas.AutoEllipsis = false;
            this.loggedinas.Cursor = System.Windows.Forms.Cursors.Default;
            this.loggedinas.CursorType = System.Windows.Forms.Cursors.Default;
            this.loggedinas.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedinas.ForeColor = System.Drawing.Color.YellowGreen;
            this.loggedinas.Location = new System.Drawing.Point(13, 36);
            this.loggedinas.Name = "loggedinas";
            this.loggedinas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loggedinas.Size = new System.Drawing.Size(0, 0);
            this.loggedinas.TabIndex = 10;
            this.loggedinas.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.loggedinas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // loggeduser
            // 
            this.loggeduser.AllowParentOverrides = false;
            this.loggeduser.AutoEllipsis = false;
            this.loggeduser.AutoSize = false;
            this.loggeduser.Cursor = System.Windows.Forms.Cursors.Default;
            this.loggeduser.CursorType = System.Windows.Forms.Cursors.Default;
            this.loggeduser.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggeduser.ForeColor = System.Drawing.Color.LightGreen;
            this.loggeduser.Location = new System.Drawing.Point(54, 43);
            this.loggeduser.Name = "loggeduser";
            this.loggeduser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loggeduser.Size = new System.Drawing.Size(93, 23);
            this.loggeduser.TabIndex = 11;
            this.loggeduser.Text = "Użytkownik";
            this.loggeduser.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.loggeduser.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 17;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 36);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(34, 34);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 12;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // settingsButton
            // 
            this.settingsButton.AllowAnimations = true;
            this.settingsButton.AllowMouseEffects = true;
            this.settingsButton.AllowToggling = false;
            this.settingsButton.AnimationSpeed = 200;
            this.settingsButton.AutoGenerateColors = false;
            this.settingsButton.AutoRoundBorders = false;
            this.settingsButton.AutoSizeLeftIcon = true;
            this.settingsButton.AutoSizeRightIcon = true;
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.ButtonText = "Ustawienia";
            this.settingsButton.ButtonTextMarginLeft = 0;
            this.settingsButton.ColorContrastOnClick = 45;
            this.settingsButton.ColorContrastOnHover = 45;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.settingsButton.CustomizableEdges = borderEdges11;
            this.settingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.settingsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.settingsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.settingsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.settingsButton.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.settingsButton.IconMarginLeft = 11;
            this.settingsButton.IconPadding = 10;
            this.settingsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.settingsButton.IconSize = 25;
            this.settingsButton.IdleBorderColor = System.Drawing.Color.DarkOrange;
            this.settingsButton.IdleBorderRadius = 50;
            this.settingsButton.IdleBorderThickness = 1;
            this.settingsButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.settingsButton.IdleIconLeftImage = null;
            this.settingsButton.IdleIconRightImage = null;
            this.settingsButton.IndicateFocus = false;
            this.settingsButton.Location = new System.Drawing.Point(276, 259);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.settingsButton.OnDisabledState.BorderRadius = 50;
            this.settingsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.OnDisabledState.BorderThickness = 1;
            this.settingsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.settingsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.settingsButton.OnDisabledState.IconLeftImage = null;
            this.settingsButton.OnDisabledState.IconRightImage = null;
            this.settingsButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(150)))), ((int)(((byte)(2)))));
            this.settingsButton.onHoverState.BorderRadius = 50;
            this.settingsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.onHoverState.BorderThickness = 1;
            this.settingsButton.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.settingsButton.onHoverState.ForeColor = System.Drawing.Color.LightGray;
            this.settingsButton.onHoverState.IconLeftImage = null;
            this.settingsButton.onHoverState.IconRightImage = null;
            this.settingsButton.OnIdleState.BorderColor = System.Drawing.Color.DarkOrange;
            this.settingsButton.OnIdleState.BorderRadius = 50;
            this.settingsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.OnIdleState.BorderThickness = 1;
            this.settingsButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.settingsButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.settingsButton.OnIdleState.IconLeftImage = null;
            this.settingsButton.OnIdleState.IconRightImage = null;
            this.settingsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.settingsButton.OnPressedState.BorderRadius = 50;
            this.settingsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.settingsButton.OnPressedState.BorderThickness = 1;
            this.settingsButton.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.settingsButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.settingsButton.OnPressedState.IconLeftImage = null;
            this.settingsButton.OnPressedState.IconRightImage = null;
            this.settingsButton.Size = new System.Drawing.Size(237, 49);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsButton.TextMarginLeft = 0;
            this.settingsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.settingsButton.UseDefaultRadiusAndThickness = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.AllowAnimations = true;
            this.launchButton.AllowMouseEffects = true;
            this.launchButton.AllowToggling = false;
            this.launchButton.AnimationSpeed = 200;
            this.launchButton.AutoGenerateColors = false;
            this.launchButton.AutoRoundBorders = false;
            this.launchButton.AutoSizeLeftIcon = true;
            this.launchButton.AutoSizeRightIcon = true;
            this.launchButton.BackColor = System.Drawing.Color.Transparent;
            this.launchButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.launchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("launchButton.BackgroundImage")));
            this.launchButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.launchButton.ButtonText = "Zagraj!";
            this.launchButton.ButtonTextMarginLeft = 0;
            this.launchButton.ColorContrastOnClick = 45;
            this.launchButton.ColorContrastOnHover = 45;
            this.launchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.launchButton.CustomizableEdges = borderEdges12;
            this.launchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.launchButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.launchButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.launchButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.launchButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.launchButton.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.Color.White;
            this.launchButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.launchButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.launchButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.launchButton.IconMarginLeft = 11;
            this.launchButton.IconPadding = 10;
            this.launchButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.launchButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.launchButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.launchButton.IconSize = 25;
            this.launchButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.launchButton.IdleBorderRadius = 50;
            this.launchButton.IdleBorderThickness = 1;
            this.launchButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.launchButton.IdleIconLeftImage = null;
            this.launchButton.IdleIconRightImage = null;
            this.launchButton.IndicateFocus = false;
            this.launchButton.Location = new System.Drawing.Point(260, 188);
            this.launchButton.Name = "launchButton";
            this.launchButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.launchButton.OnDisabledState.BorderRadius = 50;
            this.launchButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.launchButton.OnDisabledState.BorderThickness = 1;
            this.launchButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.launchButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.launchButton.OnDisabledState.IconLeftImage = null;
            this.launchButton.OnDisabledState.IconRightImage = null;
            this.launchButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(150)))), ((int)(((byte)(2)))));
            this.launchButton.onHoverState.BorderRadius = 50;
            this.launchButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.launchButton.onHoverState.BorderThickness = 1;
            this.launchButton.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.launchButton.onHoverState.ForeColor = System.Drawing.Color.LightGray;
            this.launchButton.onHoverState.IconLeftImage = null;
            this.launchButton.onHoverState.IconRightImage = null;
            this.launchButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.launchButton.OnIdleState.BorderRadius = 50;
            this.launchButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.launchButton.OnIdleState.BorderThickness = 1;
            this.launchButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.launchButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.launchButton.OnIdleState.IconLeftImage = null;
            this.launchButton.OnIdleState.IconRightImage = null;
            this.launchButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.launchButton.OnPressedState.BorderRadius = 50;
            this.launchButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.launchButton.OnPressedState.BorderThickness = 1;
            this.launchButton.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.launchButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.launchButton.OnPressedState.IconLeftImage = null;
            this.launchButton.OnPressedState.IconRightImage = null;
            this.launchButton.Size = new System.Drawing.Size(265, 54);
            this.launchButton.TabIndex = 1;
            this.launchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.launchButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.launchButton.TextMarginLeft = 0;
            this.launchButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.launchButton.UseDefaultRadiusAndThickness = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // downloadlabel
            // 
            this.downloadlabel.AllowParentOverrides = false;
            this.downloadlabel.AutoEllipsis = false;
            this.downloadlabel.AutoSize = false;
            this.downloadlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.downloadlabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.downloadlabel.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadlabel.ForeColor = System.Drawing.Color.LightGreen;
            this.downloadlabel.Location = new System.Drawing.Point(140, 137);
            this.downloadlabel.Name = "downloadlabel";
            this.downloadlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.downloadlabel.Size = new System.Drawing.Size(516, 45);
            this.downloadlabel.TabIndex = 13;
            this.downloadlabel.Text = "Przy pobieraniu  launcher może ulec ścięciu, ale nie należy się tym przejmować. Z" +
    "ależnie od przepustowości łącza, za chwile powinien ci się pokazać monit o ukońc" +
    "zonym pobieraniu";
            this.downloadlabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.downloadlabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.downloadlabel.Visible = false;
            // 
            // mainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.downloadlabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.loggeduser);
            this.Controls.Add(this.loggedinas);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.checkboxinfo);
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(this.discordpic);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.minpic);
            this.Controls.Add(this.closepic);
            this.Controls.Add(this.logo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " MGLauncher";
            this.Load += new System.EventHandler(this.mainGUI_Load);
            this.Shown += new System.EventHandler(this.mainGUI_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainGUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainGUI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainGUI_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discordpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox logo;
        private Bunifu.UI.WinForms.BunifuPictureBox closepic;
        private Bunifu.UI.WinForms.BunifuPictureBox minpic;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox discordpic;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private Bunifu.UI.WinForms.BunifuLabel checkboxinfo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel loggedinas;
        private Bunifu.UI.WinForms.BunifuLabel loggeduser;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton settingsButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton launchButton;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private Bunifu.UI.WinForms.BunifuLabel downloadlabel;
    }
}

