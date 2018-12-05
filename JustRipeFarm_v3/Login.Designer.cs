namespace JustRipeFarm_v3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resetPasswordLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exitPictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 130);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(110, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Just Ripe Farm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(40, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 1);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(232, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(133, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "login to your account";
            // 
            // resetPasswordLabel
            // 
            this.resetPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetPasswordLabel.AutoSize = true;
            this.resetPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordLabel.ForeColor = System.Drawing.Color.Silver;
            this.resetPasswordLabel.Location = new System.Drawing.Point(169, 441);
            this.resetPasswordLabel.Name = "resetPasswordLabel";
            this.resetPasswordLabel.Size = new System.Drawing.Size(200, 24);
            this.resetPasswordLabel.TabIndex = 3;
            this.resetPasswordLabel.Text = "forgot your password ?";
            this.resetPasswordLabel.Click += new System.EventHandler(this.resetPasswordLabel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(52, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "username:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(60, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(67, 365);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(414, 56);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxUsername.Location = new System.Drawing.Point(207, 232);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(258, 29);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxUsername.UseWaitCursor = true;
            this.txtBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxUsername_KeyDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(207, 339);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 1);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SeaGreen;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(207, 263);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 1);
            this.panel7.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPassword.Location = new System.Drawing.Point(207, 308);
            this.txtBoxPassword.MaxLength = 15;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '●';
            this.txtBoxPassword.Size = new System.Drawing.Size(258, 29);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxPassword.UseWaitCursor = true;
            this.txtBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPassword_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.ImageActive = null;
            this.exitPictureBox.Location = new System.Drawing.Point(486, 12);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(31, 29);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 8;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Zoom = 30;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(529, 611);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.resetPasswordLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label resetPasswordLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton exitPictureBox;
    }
}

