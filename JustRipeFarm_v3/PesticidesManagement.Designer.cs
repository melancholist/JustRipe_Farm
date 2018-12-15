namespace JustRipeFarm_v3
{
    partial class PesticidesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesticidesManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitPictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlAddPesticides = new System.Windows.Forms.Panel();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.btnClearP = new System.Windows.Forms.Button();
            this.textBoxPesComp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPesQauntity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPesType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUpdatePes = new System.Windows.Forms.Panel();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.btnClearUpd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownUpdateQ = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUpdType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.pnlAddPesticides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPesQauntity)).BeginInit();
            this.pnlUpdatePes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 51);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pesticides";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.ImageActive = null;
            this.exitPictureBox.Location = new System.Drawing.Point(523, 11);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(31, 29);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 35;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Zoom = 30;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // pnlAddPesticides
            // 
            this.pnlAddPesticides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(209)))), ((int)(((byte)(182)))));
            this.pnlAddPesticides.Controls.Add(this.btnSaveP);
            this.pnlAddPesticides.Controls.Add(this.btnClearP);
            this.pnlAddPesticides.Controls.Add(this.textBoxPesComp);
            this.pnlAddPesticides.Controls.Add(this.label5);
            this.pnlAddPesticides.Controls.Add(this.numericUpDownPesQauntity);
            this.pnlAddPesticides.Controls.Add(this.comboBoxPesType);
            this.pnlAddPesticides.Controls.Add(this.label4);
            this.pnlAddPesticides.Controls.Add(this.label3);
            this.pnlAddPesticides.Controls.Add(this.label2);
            this.pnlAddPesticides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddPesticides.Location = new System.Drawing.Point(0, 51);
            this.pnlAddPesticides.Name = "pnlAddPesticides";
            this.pnlAddPesticides.Size = new System.Drawing.Size(566, 412);
            this.pnlAddPesticides.TabIndex = 39;
            // 
            // btnSaveP
            // 
            this.btnSaveP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnSaveP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSaveP.ForeColor = System.Drawing.Color.White;
            this.btnSaveP.Location = new System.Drawing.Point(341, 314);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(113, 43);
            this.btnSaveP.TabIndex = 63;
            this.btnSaveP.Text = "Save";
            this.btnSaveP.UseVisualStyleBackColor = false;
            this.btnSaveP.Click += new System.EventHandler(this.btnSaveP_Click);
            // 
            // btnClearP
            // 
            this.btnClearP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClearP.ForeColor = System.Drawing.Color.Black;
            this.btnClearP.Location = new System.Drawing.Point(113, 314);
            this.btnClearP.Name = "btnClearP";
            this.btnClearP.Size = new System.Drawing.Size(113, 43);
            this.btnClearP.TabIndex = 62;
            this.btnClearP.Text = "Clear All";
            this.btnClearP.UseVisualStyleBackColor = false;
            this.btnClearP.Click += new System.EventHandler(this.btnClearP_Click);
            // 
            // textBoxPesComp
            // 
            this.textBoxPesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBoxPesComp.Location = new System.Drawing.Point(304, 232);
            this.textBoxPesComp.Name = "textBoxPesComp";
            this.textBoxPesComp.Size = new System.Drawing.Size(191, 28);
            this.textBoxPesComp.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(451, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "kg";
            // 
            // numericUpDownPesQauntity
            // 
            this.numericUpDownPesQauntity.DecimalPlaces = 2;
            this.numericUpDownPesQauntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.numericUpDownPesQauntity.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownPesQauntity.Location = new System.Drawing.Point(304, 144);
            this.numericUpDownPesQauntity.Name = "numericUpDownPesQauntity";
            this.numericUpDownPesQauntity.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownPesQauntity.TabIndex = 41;
            this.numericUpDownPesQauntity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxPesType
            // 
            this.comboBoxPesType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.comboBoxPesType.FormattingEnabled = true;
            this.comboBoxPesType.Items.AddRange(new object[] {
            "Insecticides ",
            "Herbicides",
            "Rodenticides",
            "Bactericides",
            "Fungicides",
            "Larvicides"});
            this.comboBoxPesType.Location = new System.Drawing.Point(304, 56);
            this.comboBoxPesType.Name = "comboBoxPesType";
            this.comboBoxPesType.Size = new System.Drawing.Size(191, 30);
            this.comboBoxPesType.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Pesticide Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pesticide Company:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Pesticides Type:";
            // 
            // pnlUpdatePes
            // 
            this.pnlUpdatePes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(209)))), ((int)(((byte)(182)))));
            this.pnlUpdatePes.Controls.Add(this.btnSaveUpd);
            this.pnlUpdatePes.Controls.Add(this.btnClearUpd);
            this.pnlUpdatePes.Controls.Add(this.label6);
            this.pnlUpdatePes.Controls.Add(this.numericUpDownUpdateQ);
            this.pnlUpdatePes.Controls.Add(this.comboBoxUpdType);
            this.pnlUpdatePes.Controls.Add(this.label7);
            this.pnlUpdatePes.Controls.Add(this.label9);
            this.pnlUpdatePes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdatePes.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdatePes.Name = "pnlUpdatePes";
            this.pnlUpdatePes.Size = new System.Drawing.Size(566, 463);
            this.pnlUpdatePes.TabIndex = 44;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnSaveUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSaveUpd.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpd.Location = new System.Drawing.Point(341, 349);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(113, 43);
            this.btnSaveUpd.TabIndex = 63;
            this.btnSaveUpd.Text = "Update";
            this.btnSaveUpd.UseVisualStyleBackColor = false;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnClearUpd
            // 
            this.btnClearUpd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUpd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClearUpd.ForeColor = System.Drawing.Color.Black;
            this.btnClearUpd.Location = new System.Drawing.Point(113, 349);
            this.btnClearUpd.Name = "btnClearUpd";
            this.btnClearUpd.Size = new System.Drawing.Size(113, 43);
            this.btnClearUpd.TabIndex = 62;
            this.btnClearUpd.Text = "Clear All";
            this.btnClearUpd.UseVisualStyleBackColor = false;
            this.btnClearUpd.Click += new System.EventHandler(this.btnClearUpd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(439, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "kg";
            // 
            // numericUpDownUpdateQ
            // 
            this.numericUpDownUpdateQ.DecimalPlaces = 2;
            this.numericUpDownUpdateQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.numericUpDownUpdateQ.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownUpdateQ.Location = new System.Drawing.Point(303, 224);
            this.numericUpDownUpdateQ.Name = "numericUpDownUpdateQ";
            this.numericUpDownUpdateQ.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownUpdateQ.TabIndex = 41;
            this.numericUpDownUpdateQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxUpdType
            // 
            this.comboBoxUpdType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUpdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.comboBoxUpdType.FormattingEnabled = true;
            this.comboBoxUpdType.Items.AddRange(new object[] {
            "Insecticides ",
            "Herbicides",
            "Rodenticides",
            "Bactericides",
            "Fungicides",
            "Larvicides"});
            this.comboBoxUpdType.Location = new System.Drawing.Point(303, 127);
            this.comboBoxUpdType.Name = "comboBoxUpdType";
            this.comboBoxUpdType.Size = new System.Drawing.Size(191, 30);
            this.comboBoxUpdType.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(73, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Pesticide Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(73, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Pesticides Type:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PesticidesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 463);
            this.Controls.Add(this.pnlAddPesticides);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUpdatePes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesticidesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesticidesManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.pnlAddPesticides.ResumeLayout(false);
            this.pnlAddPesticides.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPesQauntity)).EndInit();
            this.pnlUpdatePes.ResumeLayout(false);
            this.pnlUpdatePes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton exitPictureBox;
        public System.Windows.Forms.Panel pnlAddPesticides;
        private System.Windows.Forms.TextBox textBoxPesComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPesQauntity;
        private System.Windows.Forms.ComboBox comboBoxPesType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlUpdatePes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdateQ;
        private System.Windows.Forms.ComboBox comboBoxUpdType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.Button btnClearP;
        private System.Windows.Forms.Button btnSaveUpd;
        private System.Windows.Forms.Button btnClearUpd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}