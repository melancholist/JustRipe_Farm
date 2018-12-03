namespace JustRipeFarm_v3
{
    partial class ResetPasswordManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordManager));
            this.textBoxMangrNewPass = new System.Windows.Forms.TextBox();
            this.textBoxMangrConfirmPass = new System.Windows.Forms.TextBox();
            this.textBoxMangrUser = new System.Windows.Forms.TextBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.btnManagerConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMangrNewPass
            // 
            this.textBoxMangrNewPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMangrNewPass.Location = new System.Drawing.Point(253, 178);
            this.textBoxMangrNewPass.Multiline = true;
            this.textBoxMangrNewPass.Name = "textBoxMangrNewPass";
            this.textBoxMangrNewPass.PasswordChar = '●';
            this.textBoxMangrNewPass.Size = new System.Drawing.Size(183, 32);
            this.textBoxMangrNewPass.TabIndex = 30;
            // 
            // textBoxMangrConfirmPass
            // 
            this.textBoxMangrConfirmPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMangrConfirmPass.Location = new System.Drawing.Point(253, 229);
            this.textBoxMangrConfirmPass.Multiline = true;
            this.textBoxMangrConfirmPass.Name = "textBoxMangrConfirmPass";
            this.textBoxMangrConfirmPass.PasswordChar = '●';
            this.textBoxMangrConfirmPass.Size = new System.Drawing.Size(183, 32);
            this.textBoxMangrConfirmPass.TabIndex = 29;
            // 
            // textBoxMangrUser
            // 
            this.textBoxMangrUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMangrUser.Location = new System.Drawing.Point(253, 127);
            this.textBoxMangrUser.Multiline = true;
            this.textBoxMangrUser.Name = "textBoxMangrUser";
            this.textBoxMangrUser.Size = new System.Drawing.Size(183, 32);
            this.textBoxMangrUser.TabIndex = 28;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(431, 12);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(35, 38);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 23;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // btnManagerConfirm
            // 
            this.btnManagerConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnManagerConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagerConfirm.FlatAppearance.BorderSize = 0;
            this.btnManagerConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerConfirm.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerConfirm.ForeColor = System.Drawing.Color.White;
            this.btnManagerConfirm.Location = new System.Drawing.Point(114, 296);
            this.btnManagerConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnManagerConfirm.Name = "btnManagerConfirm";
            this.btnManagerConfirm.Size = new System.Drawing.Size(268, 50);
            this.btnManagerConfirm.TabIndex = 27;
            this.btnManagerConfirm.Text = "confirm";
            this.btnManagerConfirm.UseVisualStyleBackColor = false;
            this.btnManagerConfirm.Click += new System.EventHandler(this.btnManagerConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reset your Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "confirm password:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "enter username:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "enter new password:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 81);
            this.panel1.TabIndex = 31;
            // 
            // ResetPasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(478, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxMangrNewPass);
            this.Controls.Add(this.textBoxMangrConfirmPass);
            this.Controls.Add(this.textBoxMangrUser);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.btnManagerConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPasswordManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordManager";
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMangrNewPass;
        private System.Windows.Forms.TextBox textBoxMangrConfirmPass;
        private System.Windows.Forms.TextBox textBoxMangrUser;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Button btnManagerConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}