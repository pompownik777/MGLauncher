namespace MGLauncher
{
    partial class offlineLoginGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(offlineLoginGUI));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.logbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.buttonbox = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
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
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(146, 21);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(138, 64);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Logowanie no-premium";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // logbox
            // 
            this.logbox.AcceptsReturn = false;
            this.logbox.AcceptsTab = false;
            this.logbox.AnimationSpeed = 200;
            this.logbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.logbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.logbox.BackColor = System.Drawing.Color.Transparent;
            this.logbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logbox.BackgroundImage")));
            this.logbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.logbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.logbox.BorderColorIdle = System.Drawing.Color.Aqua;
            this.logbox.BorderRadius = 15;
            this.logbox.BorderThickness = 2;
            this.logbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.logbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logbox.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbox.DefaultText = "";
            this.logbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.logbox.HideSelection = true;
            this.logbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("logbox.IconLeft")));
            this.logbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.logbox.IconPadding = 10;
            this.logbox.IconRight = null;
            this.logbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.logbox.Lines = new string[0];
            this.logbox.Location = new System.Drawing.Point(89, 107);
            this.logbox.MaxLength = 16;
            this.logbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.logbox.Modified = false;
            this.logbox.Multiline = false;
            this.logbox.Name = "logbox";
            stateProperties1.BorderColor = System.Drawing.Color.Silver;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.logbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.logbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.logbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Aqua;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.logbox.OnIdleState = stateProperties4;
            this.logbox.Padding = new System.Windows.Forms.Padding(3);
            this.logbox.PasswordChar = '\0';
            this.logbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.logbox.PlaceholderText = "Nickname";
            this.logbox.ReadOnly = false;
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logbox.SelectedText = "";
            this.logbox.SelectionLength = 0;
            this.logbox.SelectionStart = 0;
            this.logbox.ShortcutsEnabled = true;
            this.logbox.Size = new System.Drawing.Size(263, 50);
            this.logbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.logbox.TabIndex = 11;
            this.logbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logbox.TextMarginBottom = 0;
            this.logbox.TextMarginLeft = 10;
            this.logbox.TextMarginTop = 0;
            this.logbox.TextPlaceholder = "Nickname";
            this.logbox.UseSystemPasswordChar = false;
            this.logbox.WordWrap = true;
            // 
            // buttonbox
            // 
            this.buttonbox.AllowAnimations = true;
            this.buttonbox.AllowMouseEffects = true;
            this.buttonbox.AllowToggling = false;
            this.buttonbox.AnimationSpeed = 200;
            this.buttonbox.AutoGenerateColors = false;
            this.buttonbox.AutoRoundBorders = false;
            this.buttonbox.AutoSizeLeftIcon = true;
            this.buttonbox.AutoSizeRightIcon = true;
            this.buttonbox.BackColor = System.Drawing.Color.Transparent;
            this.buttonbox.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.buttonbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonbox.BackgroundImage")));
            this.buttonbox.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.ButtonText = "Zabierz mnie do kwadratowego świata!";
            this.buttonbox.ButtonTextMarginLeft = 0;
            this.buttonbox.ColorContrastOnClick = 45;
            this.buttonbox.ColorContrastOnHover = 45;
            this.buttonbox.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonbox.CustomizableEdges = borderEdges1;
            this.buttonbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonbox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonbox.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonbox.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonbox.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonbox.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbox.ForeColor = System.Drawing.Color.White;
            this.buttonbox.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonbox.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonbox.IconMarginLeft = 11;
            this.buttonbox.IconPadding = 10;
            this.buttonbox.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonbox.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonbox.IconSize = 25;
            this.buttonbox.IdleBorderColor = System.Drawing.Color.Aquamarine;
            this.buttonbox.IdleBorderRadius = 35;
            this.buttonbox.IdleBorderThickness = 1;
            this.buttonbox.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.buttonbox.IdleIconLeftImage = null;
            this.buttonbox.IdleIconRightImage = null;
            this.buttonbox.IndicateFocus = false;
            this.buttonbox.Location = new System.Drawing.Point(89, 195);
            this.buttonbox.Name = "buttonbox";
            this.buttonbox.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonbox.OnDisabledState.BorderRadius = 35;
            this.buttonbox.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.OnDisabledState.BorderThickness = 1;
            this.buttonbox.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonbox.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonbox.OnDisabledState.IconLeftImage = null;
            this.buttonbox.OnDisabledState.IconRightImage = null;
            this.buttonbox.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonbox.onHoverState.BorderRadius = 35;
            this.buttonbox.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.onHoverState.BorderThickness = 1;
            this.buttonbox.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.buttonbox.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonbox.onHoverState.IconLeftImage = null;
            this.buttonbox.onHoverState.IconRightImage = null;
            this.buttonbox.OnIdleState.BorderColor = System.Drawing.Color.Aquamarine;
            this.buttonbox.OnIdleState.BorderRadius = 35;
            this.buttonbox.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.OnIdleState.BorderThickness = 1;
            this.buttonbox.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.buttonbox.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonbox.OnIdleState.IconLeftImage = null;
            this.buttonbox.OnIdleState.IconRightImage = null;
            this.buttonbox.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonbox.OnPressedState.BorderRadius = 35;
            this.buttonbox.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.OnPressedState.BorderThickness = 1;
            this.buttonbox.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.buttonbox.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonbox.OnPressedState.IconLeftImage = null;
            this.buttonbox.OnPressedState.IconRightImage = null;
            this.buttonbox.Size = new System.Drawing.Size(270, 56);
            this.buttonbox.TabIndex = 13;
            this.buttonbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonbox.TextMarginLeft = 0;
            this.buttonbox.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonbox.UseDefaultRadiusAndThickness = true;
            this.buttonbox.Click += new System.EventHandler(this.buttonbox_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Ivory;
            this.bunifuLabel3.Location = new System.Drawing.Point(68, 296);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(333, 62);
            this.bunifuLabel3.TabIndex = 16;
            this.bunifuLabel3.Text = "(: Jeśli podczas instalacji launchera nie było żadnych problemów, minecraft powin" +
    "ien sie zaraz uruchomić :)";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Visible = false;
            // 
            // offlineLoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.buttonbox);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "offlineLoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        public Bunifu.UI.WinForms.BunifuTextBox logbox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonbox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}