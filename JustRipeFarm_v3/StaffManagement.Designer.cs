namespace JustRipeFarm_v3
{
    partial class StaffManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backpictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBtnIndic1 = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.pnlAddStaff = new System.Windows.Forms.Panel();
            this.pnlBtnIndic2 = new System.Windows.Forms.Panel();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.btnAddLabourer = new System.Windows.Forms.Button();
            this.btnAddSalesStaff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.picBocSearch = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backpictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAddStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBocSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backpictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(491, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Staff Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backpictureBox
            // 
            this.backpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backpictureBox.Image")));
            this.backpictureBox.Location = new System.Drawing.Point(12, 6);
            this.backpictureBox.Name = "backpictureBox";
            this.backpictureBox.Size = new System.Drawing.Size(69, 56);
            this.backpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backpictureBox.TabIndex = 1;
            this.backpictureBox.TabStop = false;
            this.backpictureBox.Click += new System.EventHandler(this.backpictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pnlBtnIndic2);
            this.panel2.Controls.Add(this.pnlBtnIndic1);
            this.panel2.Controls.Add(this.btnAssign);
            this.panel2.Controls.Add(this.btnAddStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 694);
            this.panel2.TabIndex = 1;
            // 
            // pnlBtnIndic1
            // 
            this.pnlBtnIndic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.pnlBtnIndic1.Location = new System.Drawing.Point(0, 85);
            this.pnlBtnIndic1.Name = "pnlBtnIndic1";
            this.pnlBtnIndic1.Size = new System.Drawing.Size(7, 79);
            this.pnlBtnIndic1.TabIndex = 35;
            // 
            // btnAssign
            // 
            this.btnAssign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(3, 203);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(203, 79);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign Labourer Task";
            this.btnAssign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnAddStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(3, 85);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(203, 79);
            this.btnAddStaff.TabIndex = 2;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // pnlAddStaff
            // 
            this.pnlAddStaff.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlAddStaff.Controls.Add(this.btnUpdate);
            this.pnlAddStaff.Controls.Add(this.picBocSearch);
            this.pnlAddStaff.Controls.Add(this.searchComboBox);
            this.pnlAddStaff.Controls.Add(this.label2);
            this.pnlAddStaff.Controls.Add(this.dataGridView1);
            this.pnlAddStaff.Controls.Add(this.btnAddSalesStaff);
            this.pnlAddStaff.Controls.Add(this.btnAddLabourer);
            this.pnlAddStaff.Controls.Add(this.btnAddManager);
            this.pnlAddStaff.Location = new System.Drawing.Point(207, 68);
            this.pnlAddStaff.Name = "pnlAddStaff";
            this.pnlAddStaff.Size = new System.Drawing.Size(1023, 694);
            this.pnlAddStaff.TabIndex = 2;
            // 
            // pnlBtnIndic2
            // 
            this.pnlBtnIndic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.pnlBtnIndic2.Location = new System.Drawing.Point(0, 203);
            this.pnlBtnIndic2.Name = "pnlBtnIndic2";
            this.pnlBtnIndic2.Size = new System.Drawing.Size(7, 79);
            this.pnlBtnIndic2.TabIndex = 36;
            // 
            // btnAddManager
            // 
            this.btnAddManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnAddManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAddManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAddManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManager.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManager.ForeColor = System.Drawing.Color.White;
            this.btnAddManager.Location = new System.Drawing.Point(33, 21);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(203, 79);
            this.btnAddManager.TabIndex = 3;
            this.btnAddManager.Text = "Manager";
            this.btnAddManager.UseVisualStyleBackColor = false;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // btnAddLabourer
            // 
            this.btnAddLabourer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnAddLabourer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAddLabourer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAddLabourer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLabourer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLabourer.ForeColor = System.Drawing.Color.White;
            this.btnAddLabourer.Location = new System.Drawing.Point(412, 21);
            this.btnAddLabourer.Name = "btnAddLabourer";
            this.btnAddLabourer.Size = new System.Drawing.Size(203, 79);
            this.btnAddLabourer.TabIndex = 4;
            this.btnAddLabourer.Text = "Labourer";
            this.btnAddLabourer.UseVisualStyleBackColor = false;
            this.btnAddLabourer.Click += new System.EventHandler(this.btnAddLabourer_Click);
            // 
            // btnAddSalesStaff
            // 
            this.btnAddSalesStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnAddSalesStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAddSalesStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAddSalesStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSalesStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalesStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddSalesStaff.Location = new System.Drawing.Point(786, 21);
            this.btnAddSalesStaff.Name = "btnAddSalesStaff";
            this.btnAddSalesStaff.Size = new System.Drawing.Size(203, 79);
            this.btnAddSalesStaff.TabIndex = 5;
            this.btnAddSalesStaff.Text = "Sales Staff";
            this.btnAddSalesStaff.UseVisualStyleBackColor = false;
            this.btnAddSalesStaff.Click += new System.EventHandler(this.btnAddSalesStaff_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 409);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Staff Role:";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Manager",
            "Driver",
            "Field Worker",
            "Sales Staff"});
            this.searchComboBox.Location = new System.Drawing.Point(186, 167);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(182, 28);
            this.searchComboBox.TabIndex = 8;
            // 
            // picBocSearch
            // 
            this.picBocSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBocSearch.Image = ((System.Drawing.Image)(resources.GetObject("picBocSearch.Image")));
            this.picBocSearch.Location = new System.Drawing.Point(374, 158);
            this.picBocSearch.Name = "picBocSearch";
            this.picBocSearch.Size = new System.Drawing.Size(53, 48);
            this.picBocSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBocSearch.TabIndex = 9;
            this.picBocSearch.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(788, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 51);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 762);
            this.Controls.Add(this.pnlAddStaff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabourerManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backpictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlAddStaff.ResumeLayout(false);
            this.pnlAddStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBocSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backpictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Panel pnlAddStaff;
        private System.Windows.Forms.Panel pnlBtnIndic1;
        private System.Windows.Forms.Panel pnlBtnIndic2;
        private System.Windows.Forms.PictureBox picBocSearch;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAddSalesStaff;
        public System.Windows.Forms.Button btnAddLabourer;
        public System.Windows.Forms.Button btnAddManager;
    }
}