namespace VisualTCC_Prévia
{
    partial class Menu
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.guna2Panel1.Controls.Add(this.guna2GradientButton4);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton3);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton2);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(134, 728);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.MaxAnimationTime = 2000;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1145, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 5;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 60;
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(140)))), ((int)(((byte)(156)))));
            this.guna2Panel2.Location = new System.Drawing.Point(150, 50);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1027, 666);
            this.guna2Panel2.TabIndex = 6;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Animated = true;
            this.guna2GradientButton4.AutoRoundedCorners = true;
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderRadius = 21;
            this.guna2GradientButton4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Transition1.SetDecoration(this.guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(84)))), ((int)(((byte)(137)))));
            this.guna2GradientButton4.Image = global::VisualTCC_Prévia.Properties.Resources.icons8_gráfico_64;
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.Location = new System.Drawing.Point(12, 460);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(119, 45);
            this.guna2GradientButton4.TabIndex = 7;
            this.guna2GradientButton4.Text = "Dashboard";
            this.guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2GradientButton4.UseTransparentBackground = true;
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.AutoRoundedCorners = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 21;
            this.guna2GradientButton3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Transition1.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(84)))), ((int)(((byte)(137)))));
            this.guna2GradientButton3.Image = global::VisualTCC_Prévia.Properties.Resources.icons8_cadastro_100;
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.Location = new System.Drawing.Point(12, 360);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(119, 45);
            this.guna2GradientButton3.TabIndex = 4;
            this.guna2GradientButton3.Text = "Cadastro";
            this.guna2GradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2GradientButton3.UseTransparentBackground = true;
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click_1);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AutoRoundedCorners = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 21;
            this.guna2GradientButton2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Transition1.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(84)))), ((int)(((byte)(137)))));
            this.guna2GradientButton2.Image = global::VisualTCC_Prévia.Properties.Resources.icons8_empilhadeira_64;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.Location = new System.Drawing.Point(12, 260);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(119, 45);
            this.guna2GradientButton2.TabIndex = 2;
            this.guna2GradientButton2.Text = "Estoque";
            this.guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2GradientButton2.UseTransparentBackground = true;
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 21;
            this.guna2GradientButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Transition1.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(84)))), ((int)(((byte)(137)))));
            this.guna2GradientButton1.Image = global::VisualTCC_Prévia.Properties.Resources.icons8_receba_dólar_100;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.Location = new System.Drawing.Point(12, 160);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(119, 45);
            this.guna2GradientButton1.TabIndex = 1;
            this.guna2GradientButton1.Text = "Caixa";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::VisualTCC_Prévia.Properties.Resources.LOGO_NOVA;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-32, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(209, 88);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1202, 728);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}