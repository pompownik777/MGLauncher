namespace MGLauncher
{
    partial class microsoftLoginGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(microsoftLoginGUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.buttonbox = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
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
            this.bunifuLabel1.Location = new System.Drawing.Point(81, 25);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(269, 69);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Logowanie Microsoft (Premium)";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.buttonbox.BackColor1 = System.Drawing.Color.Green;
            this.buttonbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonbox.BackgroundImage")));
            this.buttonbox.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.ButtonText = "Zaloguj za pomocą konta Microsoft";
            this.buttonbox.ButtonTextMarginLeft = 0;
            this.buttonbox.ColorContrastOnClick = 45;
            this.buttonbox.ColorContrastOnHover = 45;
            this.buttonbox.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonbox.CustomizableEdges = borderEdges2;
            this.buttonbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonbox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonbox.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonbox.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonbox.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonbox.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonbox.IdleBorderColor = System.Drawing.Color.Green;
            this.buttonbox.IdleBorderRadius = 45;
            this.buttonbox.IdleBorderThickness = 2;
            this.buttonbox.IdleFillColor = System.Drawing.Color.Green;
            this.buttonbox.IdleIconLeftImage = null;
            this.buttonbox.IdleIconRightImage = null;
            this.buttonbox.IndicateFocus = false;
            this.buttonbox.Location = new System.Drawing.Point(69, 156);
            this.buttonbox.Name = "buttonbox";
            this.buttonbox.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonbox.OnDisabledState.BorderRadius = 45;
            this.buttonbox.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.OnDisabledState.BorderThickness = 2;
            this.buttonbox.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonbox.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonbox.OnDisabledState.IconLeftImage = null;
            this.buttonbox.OnDisabledState.IconRightImage = null;
            this.buttonbox.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonbox.onHoverState.BorderRadius = 45;
            this.buttonbox.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.onHoverState.BorderThickness = 2;
            this.buttonbox.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.buttonbox.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonbox.onHoverState.IconLeftImage = null;
            this.buttonbox.onHoverState.IconRightImage = null;
            this.buttonbox.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.buttonbox.OnIdleState.BorderRadius = 45;
            this.buttonbox.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.OnIdleState.BorderThickness = 2;
            this.buttonbox.OnIdleState.FillColor = System.Drawing.Color.Green;
            this.buttonbox.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonbox.OnIdleState.IconLeftImage = null;
            this.buttonbox.OnIdleState.IconRightImage = null;
            this.buttonbox.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonbox.OnPressedState.BorderRadius = 45;
            this.buttonbox.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonbox.OnPressedState.BorderThickness = 2;
            this.buttonbox.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonbox.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonbox.OnPressedState.IconLeftImage = null;
            this.buttonbox.OnPressedState.IconRightImage = null;
            this.buttonbox.Size = new System.Drawing.Size(302, 80);
            this.buttonbox.TabIndex = 13;
            this.buttonbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonbox.TextMarginLeft = 0;
            this.buttonbox.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonbox.UseDefaultRadiusAndThickness = true;
            this.buttonbox.Click += new System.EventHandler(this.buttonbox_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel2.Location = new System.Drawing.Point(118, 370);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(220, 18);
            this.bunifuLabel2.TabIndex = 14;
            this.bunifuLabel2.Text = "Połączenie jest zabezpieczone certyfikatem SSL";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Ivory;
            this.bunifuLabel3.Location = new System.Drawing.Point(69, 272);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(333, 92);
            this.bunifuLabel3.TabIndex = 15;
            this.bunifuLabel3.Text = "(: Jeśli podczas instalacji launchera nie było żadnych problemów, minecraft powin" +
    "ien sie zaraz uruchomić :)";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Visible = false;
            // 
            // microsoftLoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.buttonbox);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "microsoftLoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonbox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}