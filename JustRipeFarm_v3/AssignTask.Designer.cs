namespace JustRipeFarm_v3
{
    partial class AssignTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTask));
            this.picBoxBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSowing = new System.Windows.Forms.Button();
            this.btnHarvest = new System.Windows.Forms.Button();
            this.btnTreating = new System.Windows.Forms.Button();
            this.btnDriving = new System.Windows.Forms.Button();
            this.pnlSowing = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSowing.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxBack
            // 
            this.picBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBack.Image")));
            this.picBoxBack.Location = new System.Drawing.Point(2, 4);
            this.picBoxBack.Name = "picBoxBack";
            this.picBoxBack.Size = new System.Drawing.Size(45, 39);
            this.picBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBack.TabIndex = 0;
            this.picBoxBack.TabStop = false;
            this.picBoxBack.Click += new System.EventHandler(this.picBoxBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBoxBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(413, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assigning Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnDriving);
            this.panel2.Controls.Add(this.btnSowing);
            this.panel2.Controls.Add(this.btnTreating);
            this.panel2.Controls.Add(this.btnHarvest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 622);
            this.panel2.TabIndex = 2;
            // 
            // btnSowing
            // 
            this.btnSowing.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSowing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSowing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSowing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSowing.ForeColor = System.Drawing.Color.White;
            this.btnSowing.Location = new System.Drawing.Point(2, 24);
            this.btnSowing.Name = "btnSowing";
            this.btnSowing.Size = new System.Drawing.Size(169, 63);
            this.btnSowing.TabIndex = 3;
            this.btnSowing.Text = "Sowing";
            this.btnSowing.UseVisualStyleBackColor = true;
            // 
            // btnHarvest
            // 
            this.btnHarvest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHarvest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnHarvest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnHarvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarvest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarvest.ForeColor = System.Drawing.Color.White;
            this.btnHarvest.Location = new System.Drawing.Point(2, 93);
            this.btnHarvest.Name = "btnHarvest";
            this.btnHarvest.Size = new System.Drawing.Size(169, 63);
            this.btnHarvest.TabIndex = 4;
            this.btnHarvest.Text = "Harvest";
            this.btnHarvest.UseVisualStyleBackColor = true;
            // 
            // btnTreating
            // 
            this.btnTreating.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTreating.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnTreating.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnTreating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreating.ForeColor = System.Drawing.Color.White;
            this.btnTreating.Location = new System.Drawing.Point(2, 162);
            this.btnTreating.Name = "btnTreating";
            this.btnTreating.Size = new System.Drawing.Size(169, 63);
            this.btnTreating.TabIndex = 5;
            this.btnTreating.Text = "Treating";
            this.btnTreating.UseVisualStyleBackColor = true;
            // 
            // btnDriving
            // 
            this.btnDriving.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDriving.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDriving.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDriving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriving.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriving.ForeColor = System.Drawing.Color.White;
            this.btnDriving.Location = new System.Drawing.Point(2, 231);
            this.btnDriving.Name = "btnDriving";
            this.btnDriving.Size = new System.Drawing.Size(169, 63);
            this.btnDriving.TabIndex = 6;
            this.btnDriving.Text = "Driving";
            this.btnDriving.UseVisualStyleBackColor = true;
            // 
            // pnlSowing
            // 
            this.pnlSowing.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSowing.Controls.Add(this.comboBox1);
            this.pnlSowing.Controls.Add(this.label3);
            this.pnlSowing.Controls.Add(this.comboBoxWorkers);
            this.pnlSowing.Controls.Add(this.label2);
            this.pnlSowing.Location = new System.Drawing.Point(177, 48);
            this.pnlSowing.Name = "pnlSowing";
            this.pnlSowing.Size = new System.Drawing.Size(892, 622);
            this.pnlSowing.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Field Workers:";
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWorkers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(180, 43);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(243, 29);
            this.comboBoxWorkers.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Methods:";
            // 
            // AssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1069, 670);
            this.Controls.Add(this.pnlSowing);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignTask";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlSowing.ResumeLayout(false);
            this.pnlSowing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDriving;
        private System.Windows.Forms.Button btnSowing;
        private System.Windows.Forms.Button btnTreating;
        private System.Windows.Forms.Button btnHarvest;
        private System.Windows.Forms.Panel pnlSowing;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.Label label2;
    }
}