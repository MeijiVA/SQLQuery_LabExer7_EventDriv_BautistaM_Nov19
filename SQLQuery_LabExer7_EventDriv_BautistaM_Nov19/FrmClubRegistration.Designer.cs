namespace SQLQuery_LabExer7_EventDriv_BautistaM_Nov19
{
    partial class FrmClubRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxProgram = new System.Windows.Forms.ComboBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cboxProgram);
            this.panel1.Controls.Add(this.dgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboxGender);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStudID);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 661);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboxProgram
            // 
            this.cboxProgram.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.cboxProgram.FormattingEnabled = true;
            this.cboxProgram.Items.AddRange(new object[] {
            "BS Information Technology",
            "BS Computer Science",
            "BS Multimedia Arts"});
            this.cboxProgram.Location = new System.Drawing.Point(577, 61);
            this.cboxProgram.Name = "cboxProgram";
            this.cboxProgram.Size = new System.Drawing.Size(249, 35);
            this.cboxProgram.TabIndex = 32;
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(47, 300);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTable.Size = new System.Drawing.Size(759, 334);
            this.dgvTable.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(62, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 27);
            this.label7.TabIndex = 30;
            this.label7.Text = "List Of Club Members";
            // 
            // cboxGender
            // 
            this.cboxGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.cboxGender.FormattingEnabled = true;
            this.cboxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboxGender.Location = new System.Drawing.Point(322, 209);
            this.cboxGender.Name = "cboxGender";
            this.cboxGender.Size = new System.Drawing.Size(249, 35);
            this.cboxGender.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(317, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(572, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Program";
            // 
            // txtMN
            // 
            this.txtMN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.txtMN.Location = new System.Drawing.Point(577, 135);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(249, 34);
            this.txtMN.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(572, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "Middle Name:";
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.txtFN.Location = new System.Drawing.Point(322, 135);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(249, 34);
            this.txtFN.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.txtAge.Location = new System.Drawing.Point(67, 209);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(249, 34);
            this.txtAge.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Age:";
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.txtLN.Location = new System.Drawing.Point(67, 135);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(249, 34);
            this.txtLN.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Last Name:";
            // 
            // txtStudID
            // 
            this.txtStudID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.txtStudID.Location = new System.Drawing.Point(67, 61);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(249, 34);
            this.txtStudID.TabIndex = 17;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(62, 31);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(129, 27);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "Student ID";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnRegister.Location = new System.Drawing.Point(914, 31);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(158, 46);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnUpdate.Location = new System.Drawing.Point(914, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 46);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnRefresh.Location = new System.Drawing.Point(914, 300);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 46);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLQuery_LabExer7_EventDriv_BautistaM_Nov19.Properties.Resources.sunset_1373171__480;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClubRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClubRegistration";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxProgram;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
    }
}

