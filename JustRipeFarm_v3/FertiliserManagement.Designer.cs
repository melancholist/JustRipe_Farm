namespace JustRipeFarm_v3
{
    partial class FertiliserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FertiliserManagement));
            this.exitPictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAddFertiliser = new System.Windows.Forms.Panel();
            this.btnSaveF = new System.Windows.Forms.Button();
            this.btnClearF = new System.Windows.Forms.Button();
            this.textBoxFerComp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFerQauntity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFerType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUpdateFer = new System.Windows.Forms.Panel();
            this.btnSaveFerUp = new System.Windows.Forms.Button();
            this.btnClearFerU = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownUpdateQ = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUpdateFer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlAddFertiliser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFerQauntity)).BeginInit();
            this.pnlUpdateFer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQ)).BeginInit();
            this.SuspendLayout();
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.ImageActive = null;
            this.exitPictureBox.Location = new System.Drawing.Point(541, 11);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(31, 29);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 35;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Zoom = 30;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fertiliser";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 51);
            this.panel1.TabIndex = 37;
            // 
            // pnlAddFertiliser
            // 
            this.pnlAddFertiliser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(209)))), ((int)(((byte)(182)))));
            this.pnlAddFertiliser.Controls.Add(this.btnSaveF);
            this.pnlAddFertiliser.Controls.Add(this.btnClearF);
            this.pnlAddFertiliser.Controls.Add(this.textBoxFerComp);
            this.pnlAddFertiliser.Controls.Add(this.label5);
            this.pnlAddFertiliser.Controls.Add(this.numericUpDownFerQauntity);
            this.pnlAddFertiliser.Controls.Add(this.comboBoxFerType);
            this.pnlAddFertiliser.Controls.Add(this.label4);
            this.pnlAddFertiliser.Controls.Add(this.label3);
            this.pnlAddFertiliser.Controls.Add(this.label2);
            this.pnlAddFertiliser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddFertiliser.Location = new System.Drawing.Point(0, 0);
            this.pnlAddFertiliser.Name = "pnlAddFertiliser";
            this.pnlAddFertiliser.Size = new System.Drawing.Size(584, 510);
            this.pnlAddFertiliser.TabIndex = 38;
            // 
            // btnSaveF
            // 
            this.btnSaveF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnSaveF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSaveF.ForeColor = System.Drawing.Color.White;
            this.btnSaveF.Location = new System.Drawing.Point(350, 393);
            this.btnSaveF.Name = "btnSaveF";
            this.btnSaveF.Size = new System.Drawing.Size(113, 43);
            this.btnSaveF.TabIndex = 61;
            this.btnSaveF.Text = "Save";
            this.btnSaveF.UseVisualStyleBackColor = false;
            this.btnSaveF.Click += new System.EventHandler(this.btnSaveF_Click);
            // 
            // btnClearF
            // 
            this.btnClearF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClearF.ForeColor = System.Drawing.Color.Black;
            this.btnClearF.Location = new System.Drawing.Point(122, 393);
            this.btnClearF.Name = "btnClearF";
            this.btnClearF.Size = new System.Drawing.Size(113, 43);
            this.btnClearF.TabIndex = 60;
            this.btnClearF.Text = "Clear All";
            this.btnClearF.UseVisualStyleBackColor = false;
            this.btnClearF.Click += new System.EventHandler(this.btnClearF_Click);
            // 
            // textBoxFerComp
            // 
            this.textBoxFerComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFerComp.Location = new System.Drawing.Point(304, 267);
            this.textBoxFerComp.Name = "textBoxFerComp";
            this.textBoxFerComp.Size = new System.Drawing.Size(191, 28);
            this.textBoxFerComp.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(439, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "kg";
            // 
            // numericUpDownFerQauntity
            // 
            this.numericUpDownFerQauntity.DecimalPlaces = 2;
            this.numericUpDownFerQauntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFerQauntity.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownFerQauntity.Location = new System.Drawing.Point(304, 205);
            this.numericUpDownFerQauntity.Name = "numericUpDownFerQauntity";
            this.numericUpDownFerQauntity.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownFerQauntity.TabIndex = 41;
            this.numericUpDownFerQauntity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxFerType
            // 
            this.comboBoxFerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFerType.FormattingEnabled = true;
            this.comboBoxFerType.Items.AddRange(new object[] {
            "Urea",
            "Sodium Nitrate",
            "Ammonium Sulphate",
            "Ammonium Nitrate",
            "Ammonium Chloride",
            "Animal Manure",
            "Rock Phosphate",
            "Basic Slag",
            "Bone-Meal",
            "Sulphate of Potash"});
            this.comboBoxFerType.Location = new System.Drawing.Point(304, 142);
            this.comboBoxFerType.Name = "comboBoxFerType";
            this.comboBoxFerType.Size = new System.Drawing.Size(191, 30);
            this.comboBoxFerType.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(89, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Fertiliser Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fertiliser Company:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fertiliser Type:";
            // 
            // pnlUpdateFer
            // 
            this.pnlUpdateFer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(209)))), ((int)(((byte)(182)))));
            this.pnlUpdateFer.Controls.Add(this.btnSaveFerUp);
            this.pnlUpdateFer.Controls.Add(this.btnClearFerU);
            this.pnlUpdateFer.Controls.Add(this.label6);
            this.pnlUpdateFer.Controls.Add(this.numericUpDownUpdateQ);
            this.pnlUpdateFer.Controls.Add(this.comboBoxUpdateFer);
            this.pnlUpdateFer.Controls.Add(this.label7);
            this.pnlUpdateFer.Controls.Add(this.label8);
            this.pnlUpdateFer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateFer.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateFer.Name = "pnlUpdateFer";
            this.pnlUpdateFer.Size = new System.Drawing.Size(584, 510);
            this.pnlUpdateFer.TabIndex = 44;
            // 
            // btnSaveFerUp
            // 
            this.btnSaveFerUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnSaveFerUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFerUp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSaveFerUp.ForeColor = System.Drawing.Color.White;
            this.btnSaveFerUp.Location = new System.Drawing.Point(341, 393);
            this.btnSaveFerUp.Name = "btnSaveFerUp";
            this.btnSaveFerUp.Size = new System.Drawing.Size(113, 43);
            this.btnSaveFerUp.TabIndex = 61;
            this.btnSaveFerUp.Text = "Update";
            this.btnSaveFerUp.UseVisualStyleBackColor = false;
            this.btnSaveFerUp.Click += new System.EventHandler(this.btnSaveFerUp_Click);
            // 
            // btnClearFerU
            // 
            this.btnClearFerU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClearFerU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFerU.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClearFerU.ForeColor = System.Drawing.Color.Black;
            this.btnClearFerU.Location = new System.Drawing.Point(130, 393);
            this.btnClearFerU.Name = "btnClearFerU";
            this.btnClearFerU.Size = new System.Drawing.Size(113, 43);
            this.btnClearFerU.TabIndex = 60;
            this.btnClearFerU.Text = "Clear All";
            this.btnClearFerU.UseVisualStyleBackColor = false;
            this.btnClearFerU.Click += new System.EventHandler(this.btnClearFerU_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(437, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "kg";
            // 
            // numericUpDownUpdateQ
            // 
            this.numericUpDownUpdateQ.DecimalPlaces = 2;
            this.numericUpDownUpdateQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownUpdateQ.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownUpdateQ.Location = new System.Drawing.Point(301, 236);
            this.numericUpDownUpdateQ.Name = "numericUpDownUpdateQ";
            this.numericUpDownUpdateQ.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownUpdateQ.TabIndex = 46;
            this.numericUpDownUpdateQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxUpdateFer
            // 
            this.comboBoxUpdateFer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUpdateFer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUpdateFer.FormattingEnabled = true;
            this.comboBoxUpdateFer.Items.AddRange(new object[] {
            "Urea",
            "Sodium Nitrate",
            "Ammonium Sulphate",
            "Ammonium Nitrate",
            "Ammonium Chloride",
            "Animal Manure",
            "Rock Phosphate",
            "Basic Slag",
            "Bone-Meal",
            "Sulphate of Potash"});
            this.comboBoxUpdateFer.Location = new System.Drawing.Point(301, 142);
            this.comboBoxUpdateFer.Name = "comboBoxUpdateFer";
            this.comboBoxUpdateFer.Size = new System.Drawing.Size(191, 30);
            this.comboBoxUpdateFer.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(93, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Fertiliser Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(93, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Fertiliser Type:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FertiliserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(584, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUpdateFer);
            this.Controls.Add(this.pnlAddFertiliser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FertiliserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewFertiliser";
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAddFertiliser.ResumeLayout(false);
            this.pnlAddFertiliser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFerQauntity)).EndInit();
            this.pnlUpdateFer.ResumeLayout(false);
            this.pnlUpdateFer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton exitPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlAddFertiliser;
        private System.Windows.Forms.TextBox textBoxFerComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownFerQauntity;
        private System.Windows.Forms.ComboBox comboBoxFerType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlUpdateFer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdateQ;
        private System.Windows.Forms.ComboBox comboBoxUpdateFer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnSaveF;
        private System.Windows.Forms.Button btnClearF;
        private System.Windows.Forms.Button btnSaveFerUp;
        private System.Windows.Forms.Button btnClearFerU;
    }
}