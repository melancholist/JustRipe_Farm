namespace JustRipeFarm_v3
{
    partial class AddNewMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMachine));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboBoxMachineType = new System.Windows.Forms.ComboBox();
            this.comboBoxMachineStatus = new System.Windows.Forms.ComboBox();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.exitPictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Machine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(104, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Machine Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(104, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(104, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Machine Status";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSave.Location = new System.Drawing.Point(400, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(285, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBoxMachineType
            // 
            this.comboBoxMachineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.comboBoxMachineType.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxMachineType.FormattingEnabled = true;
            this.comboBoxMachineType.Items.AddRange(new object[] {
            "Tractor",
            "ATV/UTV",
            "Backhoe",
            "Front-End Loader",
            "Cultivator",
            "Plow",
            "Sprayer",
            "Irrigation System",
            "Seed Drills",
            "Mower"});
            this.comboBoxMachineType.Location = new System.Drawing.Point(273, 123);
            this.comboBoxMachineType.Name = "comboBoxMachineType";
            this.comboBoxMachineType.Size = new System.Drawing.Size(186, 24);
            this.comboBoxMachineType.TabIndex = 6;
            // 
            // comboBoxMachineStatus
            // 
            this.comboBoxMachineStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.comboBoxMachineStatus.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxMachineStatus.FormattingEnabled = true;
            this.comboBoxMachineStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable",
            "In Maintenance"});
            this.comboBoxMachineStatus.Location = new System.Drawing.Point(273, 225);
            this.comboBoxMachineStatus.Name = "comboBoxMachineStatus";
            this.comboBoxMachineStatus.Size = new System.Drawing.Size(186, 24);
            this.comboBoxMachineStatus.TabIndex = 7;
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.textBoxModelName.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxModelName.Location = new System.Drawing.Point(273, 176);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(186, 22);
            this.textBoxModelName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(104, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.textBoxPrice.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxPrice.Location = new System.Drawing.Point(273, 273);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(186, 22);
            this.textBoxPrice.TabIndex = 12;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.ImageActive = null;
            this.exitPictureBox.Location = new System.Drawing.Point(511, 12);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(31, 29);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 34;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Zoom = 30;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 76);
            this.panel1.TabIndex = 53;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddNewMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(566, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxModelName);
            this.Controls.Add(this.comboBoxMachineStatus);
            this.Controls.Add(this.comboBoxMachineType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewMachine";
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comboBoxMachineType;
        private System.Windows.Forms.ComboBox comboBoxMachineStatus;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice;
        private Bunifu.Framework.UI.BunifuImageButton exitPictureBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}