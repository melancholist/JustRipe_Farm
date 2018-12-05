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
            this.pnlFieldWorkers = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnHarvest = new System.Windows.Forms.Button();
            this.btnSowing = new System.Windows.Forms.Button();
            this.btnTreating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlFieldWorkers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxBack
            // 
            this.picBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBack.Image")));
            this.picBoxBack.Location = new System.Drawing.Point(2, 3);
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
            this.panel1.Size = new System.Drawing.Size(1073, 43);
            this.panel1.TabIndex = 4;
            // 
            // pnlFieldWorkers
            // 
            this.pnlFieldWorkers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlFieldWorkers.Controls.Add(this.comboBox1);
            this.pnlFieldWorkers.Controls.Add(this.label4);
            this.pnlFieldWorkers.Controls.Add(this.label2);
            this.pnlFieldWorkers.Controls.Add(this.comboBoxWorkers);
            this.pnlFieldWorkers.Location = new System.Drawing.Point(155, 43);
            this.pnlFieldWorkers.Name = "pnlFieldWorkers";
            this.pnlFieldWorkers.Size = new System.Drawing.Size(915, 553);
            this.pnlFieldWorkers.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(452, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assigning Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWorkers.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(186, 31);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(204, 29);
            this.comboBoxWorkers.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Field Workers:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sowing",
            "Harvest",
            "Treating"});
            this.comboBox1.Location = new System.Drawing.Point(186, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 29);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Method:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTreating);
            this.panel2.Controls.Add(this.btnSowing);
            this.panel2.Controls.Add(this.btnHarvest);
            this.panel2.Controls.Add(this.btnDrivers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 553);
            this.panel2.TabIndex = 5;
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnDrivers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Location = new System.Drawing.Point(6, 243);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(144, 69);
            this.btnDrivers.TabIndex = 3;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.UseVisualStyleBackColor = false;
            // 
            // btnHarvest
            // 
            this.btnHarvest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnHarvest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHarvest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnHarvest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnHarvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHarvest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarvest.ForeColor = System.Drawing.Color.White;
            this.btnHarvest.Location = new System.Drawing.Point(6, 93);
            this.btnHarvest.Name = "btnHarvest";
            this.btnHarvest.Size = new System.Drawing.Size(144, 69);
            this.btnHarvest.TabIndex = 4;
            this.btnHarvest.Text = "Harvest";
            this.btnHarvest.UseVisualStyleBackColor = false;
            // 
            // btnSowing
            // 
            this.btnSowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnSowing.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSowing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSowing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSowing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSowing.ForeColor = System.Drawing.Color.White;
            this.btnSowing.Location = new System.Drawing.Point(6, 18);
            this.btnSowing.Name = "btnSowing";
            this.btnSowing.Size = new System.Drawing.Size(144, 69);
            this.btnSowing.TabIndex = 5;
            this.btnSowing.Text = "Sowing";
            this.btnSowing.UseVisualStyleBackColor = false;
            // 
            // btnTreating
            // 
            this.btnTreating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnTreating.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTreating.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnTreating.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnTreating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreating.ForeColor = System.Drawing.Color.White;
            this.btnTreating.Location = new System.Drawing.Point(5, 168);
            this.btnTreating.Name = "btnTreating";
            this.btnTreating.Size = new System.Drawing.Size(144, 69);
            this.btnTreating.TabIndex = 6;
            this.btnTreating.Text = "Treating";
            this.btnTreating.UseVisualStyleBackColor = false;
            // 
            // AssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1073, 596);
            this.Controls.Add(this.pnlFieldWorkers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignTask";
            this.Text = "AssignTask";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFieldWorkers.ResumeLayout(false);
            this.pnlFieldWorkers.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFieldWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnTreating;
        private System.Windows.Forms.Button btnSowing;
        private System.Windows.Forms.Button btnHarvest;
    }
}