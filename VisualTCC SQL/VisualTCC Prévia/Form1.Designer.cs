namespace VisualTCC_Prévia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Conf = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 60;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Conf
            // 
            this.Conf.Animated = true;
            this.Conf.AutoRoundedCorners = true;
            this.Conf.BackColor = System.Drawing.Color.Transparent;
            this.Conf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(106)))), ((int)(((byte)(201)))));
            this.Conf.BorderRadius = 17;
            this.Conf.BorderThickness = 1;
            this.Conf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Conf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Conf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Conf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Conf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.Conf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Conf.ForeColor = System.Drawing.Color.White;
            this.Conf.Location = new System.Drawing.Point(140, 246);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(132, 36);
            this.Conf.TabIndex = 3;
            this.Conf.Text = "Login";
            this.Conf.UseTransparentBackground = true;
            this.Conf.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(106)))), ((int)(((byte)(201)))));
            this.guna2TextBox2.BorderRadius = 8;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(51, 147);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '●';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.PlaceholderText = "Senha";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(221, 36);
            this.guna2TextBox2.TabIndex = 2;
            this.guna2TextBox2.UseSystemPasswordChar = true;
            this.guna2TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox2_KeyPress);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(106)))), ((int)(((byte)(201)))));
            this.guna2TextBox1.BorderRadius = 8;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(51, 63);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.PlaceholderText = "Usuário";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(221, 36);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 13;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(88)))), ((int)(((byte)(219)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(120)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(679, 376);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(73, 29);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.Text = "Sair";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualTCC_Prévia.Properties.Resources.logo_animada1;
            this.pictureBox1.Location = new System.Drawing.Point(335, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.Conf);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button Conf;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

