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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backpictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBtnIndic1 = new System.Windows.Forms.Panel();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.pnlAddStaff = new System.Windows.Forms.Panel();
            this.dataGridViewStaff = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnStaff = new System.Windows.Forms.Button();
            this.picBocSearch = new System.Windows.Forms.PictureBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backpictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAddStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBocSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.backpictureBox);
            this.panel1.Controls.Add(this.btnTask);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 68);
            this.panel1.TabIndex = 0;
            // 
            // backpictureBox
            // 
            this.backpictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.backpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backpictureBox.Image")));
            this.backpictureBox.ImageActive = null;
            this.backpictureBox.Location = new System.Drawing.Point(12, 12);
            this.backpictureBox.Name = "backpictureBox";
            this.backpictureBox.Size = new System.Drawing.Size(42, 45);
            this.backpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backpictureBox.TabIndex = 13;
            this.backpictureBox.TabStop = false;
            this.backpictureBox.Zoom = 30;
            this.backpictureBox.Click += new System.EventHandler(this.backpictureBox_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.White;
            this.btnTask.Location = new System.Drawing.Point(1044, 9);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(175, 51);
            this.btnTask.TabIndex = 12;
            this.btnTask.Text = "Assign Task";
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(476, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Staff Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pnlBtnIndic1);
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
            this.pnlAddStaff.Controls.Add(this.dataGridViewStaff);
            this.pnlAddStaff.Controls.Add(this.btnStaff);
            this.pnlAddStaff.Controls.Add(this.picBocSearch);
            this.pnlAddStaff.Controls.Add(this.searchComboBox);
            this.pnlAddStaff.Controls.Add(this.label2);
            this.pnlAddStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddStaff.Location = new System.Drawing.Point(207, 68);
            this.pnlAddStaff.Name = "pnlAddStaff";
            this.pnlAddStaff.Size = new System.Drawing.Size(1023, 694);
            this.pnlAddStaff.TabIndex = 2;
            // 
            // dataGridViewStaff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.DoubleBuffered = true;
            this.dataGridViewStaff.EnableHeadersVisualStyles = false;
            this.dataGridViewStaff.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridViewStaff.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewStaff.Location = new System.Drawing.Point(46, 111);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStaff.RowHeadersVisible = false;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(931, 544);
            this.dataGridViewStaff.TabIndex = 12;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(783, 33);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(190, 51);
            this.btnStaff.TabIndex = 11;
            this.btnStaff.Text = "+ Add Record";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // picBocSearch
            // 
            this.picBocSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBocSearch.Image = ((System.Drawing.Image)(resources.GetObject("picBocSearch.Image")));
            this.picBocSearch.Location = new System.Drawing.Point(365, 24);
            this.picBocSearch.Name = "picBocSearch";
            this.picBocSearch.Size = new System.Drawing.Size(53, 48);
            this.picBocSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBocSearch.TabIndex = 9;
            this.picBocSearch.TabStop = false;
            this.picBocSearch.Click += new System.EventHandler(this.picBocSearch_Click);
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
            this.searchComboBox.Location = new System.Drawing.Point(177, 33);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(182, 28);
            this.searchComboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Staff Role:";
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
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backpictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlAddStaff.ResumeLayout(false);
            this.pnlAddStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBocSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Panel pnlAddStaff;
        private System.Windows.Forms.Panel pnlBtnIndic1;
        private System.Windows.Forms.PictureBox picBocSearch;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStaff;
        private Bunifu.Framework.UI.BunifuImageButton backpictureBox;
        public System.Windows.Forms.Button btnTask;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewStaff;
    }
}