namespace JustRipeFarm_v3
{
    partial class AddNewIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewIncome));
            this.lblCustomer = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxIncome = new System.Windows.Forms.ComboBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNewTransaction = new System.Windows.Forms.Label();
            this.exitPictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(32, 91);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(68, 17);
            this.lblCustomer.TabIndex = 28;
            this.lblCustomer.Text = "Customer";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(142, 233);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 22);
            this.textBoxDescription.TabIndex = 25;
            // 
            // comboBoxIncome
            // 
            this.comboBoxIncome.FormattingEnabled = true;
            this.comboBoxIncome.Items.AddRange(new object[] {
            "Sales of produce, grains and other products",
            "Coorperative distributions",
            "Agricultural program payments",
            "Crop insurance proceeds and federal crop disaster payments",
            "Custom hire (machine work) income",
            "Other income"});
            this.comboBoxIncome.Location = new System.Drawing.Point(142, 192);
            this.comboBoxIncome.Name = "comboBoxIncome";
            this.comboBoxIncome.Size = new System.Drawing.Size(200, 24);
            this.comboBoxIncome.TabIndex = 24;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(142, 86);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomer.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(142, 119);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxAmount.TabIndex = 21;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(35, 238);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(35, 199);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Category";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(35, 159);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(35, 124);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(68, 17);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount $";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNewTransaction
            // 
            this.lblNewTransaction.AutoSize = true;
            this.lblNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTransaction.ForeColor = System.Drawing.Color.White;
            this.lblNewTransaction.Location = new System.Drawing.Point(102, 8);
            this.lblNewTransaction.Name = "lblNewTransaction";
            this.lblNewTransaction.Size = new System.Drawing.Size(188, 32);
            this.lblNewTransaction.TabIndex = 32;
            this.lblNewTransaction.Text = "New  Income";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.ImageActive = null;
            this.exitPictureBox.Location = new System.Drawing.Point(349, 10);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(31, 29);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 33;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Zoom = 30;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lblNewTransaction);
            this.panel1.Controls.Add(this.exitPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 49);
            this.panel1.TabIndex = 52;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddNewIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(392, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxIncome);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxIncome;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNewTransaction;
        private Bunifu.Framework.UI.BunifuImageButton exitPictureBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}