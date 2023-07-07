namespace MidProject
{
    partial class DiagnoseResult
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxSearch = new System.Windows.Forms.ComboBox();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDiagnoseData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.lblNull = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtSituation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBreederName = new System.Windows.Forms.Label();
            this.lblBreederNumber = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.cboxDiagnosticStatus = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxDoctor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiagnosticCharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiagnosticResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnoseData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxSearch);
            this.groupBox1.Controls.Add(this.dtpSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvDiagnoseData);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(698, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 571);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "掛號資料列表";
            // 
            // cboxSearch
            // 
            this.cboxSearch.FormattingEnabled = true;
            this.cboxSearch.Location = new System.Drawing.Point(441, 25);
            this.cboxSearch.Name = "cboxSearch";
            this.cboxSearch.Size = new System.Drawing.Size(109, 27);
            this.cboxSearch.TabIndex = 83;
            // 
            // dtpSearch
            // 
            this.dtpSearch.Location = new System.Drawing.Point(156, 25);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(155, 27);
            this.dtpSearch.TabIndex = 81;
            this.dtpSearch.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(156, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 27);
            this.txtSearch.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "飼主身分證號";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(556, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.TabIndex = 77;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(343, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "查詢模式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(33, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "掛號日期";
            // 
            // dgvDiagnoseData
            // 
            this.dgvDiagnoseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnoseData.Location = new System.Drawing.Point(6, 93);
            this.dgvDiagnoseData.Name = "dgvDiagnoseData";
            this.dgvDiagnoseData.RowHeadersWidth = 51;
            this.dgvDiagnoseData.RowTemplate.Height = 27;
            this.dgvDiagnoseData.Size = new System.Drawing.Size(670, 472);
            this.dgvDiagnoseData.TabIndex = 0;
            this.dgvDiagnoseData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnoseData_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPetName);
            this.groupBox2.Controls.Add(this.lblNull);
            this.groupBox2.Controls.Add(this.dtpAppointmentDate);
            this.groupBox2.Controls.Add(this.txtSituation);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblBreederName);
            this.groupBox2.Controls.Add(this.lblBreederNumber);
            this.groupBox2.Controls.Add(this.lblAppointmentID);
            this.groupBox2.Controls.Add(this.cboxDiagnosticStatus);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboxDoctor);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDiagnosticCharge);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiagnosticResult);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 571);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "編輯診斷資料";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Location = new System.Drawing.Point(171, 73);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(73, 19);
            this.lblPetName.TabIndex = 113;
            this.lblPetName.Text = "PetName";
            // 
            // lblNull
            // 
            this.lblNull.AutoSize = true;
            this.lblNull.Location = new System.Drawing.Point(641, 60);
            this.lblNull.Name = "lblNull";
            this.lblNull.Size = new System.Drawing.Size(18, 19);
            this.lblNull.TabIndex = 112;
            this.lblNull.Text = "0";
            this.lblNull.Visible = false;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpAppointmentDate.Location = new System.Drawing.Point(412, 21);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 27);
            this.dtpAppointmentDate.TabIndex = 111;
            this.dtpAppointmentDate.Visible = false;
            // 
            // txtSituation
            // 
            this.txtSituation.Location = new System.Drawing.Point(175, 123);
            this.txtSituation.Multiline = true;
            this.txtSituation.Name = "txtSituation";
            this.txtSituation.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSituation.Size = new System.Drawing.Size(454, 100);
            this.txtSituation.TabIndex = 110;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(26, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 109;
            this.label16.Text = "狀況描述";
            // 
            // lblBreederName
            // 
            this.lblBreederName.AutoSize = true;
            this.lblBreederName.Location = new System.Drawing.Point(171, 23);
            this.lblBreederName.Name = "lblBreederName";
            this.lblBreederName.Size = new System.Drawing.Size(51, 19);
            this.lblBreederName.TabIndex = 103;
            this.lblBreederName.Text = "Name";
            // 
            // lblBreederNumber
            // 
            this.lblBreederNumber.AutoSize = true;
            this.lblBreederNumber.Location = new System.Drawing.Point(641, 38);
            this.lblBreederNumber.Name = "lblBreederNumber";
            this.lblBreederNumber.Size = new System.Drawing.Size(18, 19);
            this.lblBreederNumber.TabIndex = 102;
            this.lblBreederNumber.Text = "0";
            this.lblBreederNumber.Visible = false;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(641, 17);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(18, 19);
            this.lblAppointmentID.TabIndex = 101;
            this.lblAppointmentID.Text = "0";
            this.lblAppointmentID.Visible = false;
            // 
            // cboxDiagnosticStatus
            // 
            this.cboxDiagnosticStatus.FormattingEnabled = true;
            this.cboxDiagnosticStatus.Location = new System.Drawing.Point(175, 279);
            this.cboxDiagnosticStatus.Name = "cboxDiagnosticStatus";
            this.cboxDiagnosticStatus.Size = new System.Drawing.Size(100, 27);
            this.cboxDiagnosticStatus.TabIndex = 100;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(538, 525);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 97;
            this.btnRefresh.Text = "表格重整";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(357, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "元";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(286, 524);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 94;
            this.btnDelete.Text = "刪除診斷資料";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(34, 524);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(246, 40);
            this.btnModify.TabIndex = 93;
            this.btnModify.Text = "新增/修改診斷資料";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "看診結果";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(26, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 88;
            this.label11.Text = "看診狀態";
            // 
            // cboxDoctor
            // 
            this.cboxDoctor.FormattingEnabled = true;
            this.cboxDoctor.Location = new System.Drawing.Point(175, 229);
            this.cboxDoctor.Name = "cboxDoctor";
            this.cboxDoctor.Size = new System.Drawing.Size(176, 27);
            this.cboxDoctor.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(26, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 83;
            this.label13.Text = "看診醫師";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(36, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 25);
            this.label14.TabIndex = 82;
            this.label14.Text = "寵物名";
            // 
            // txtDiagnosticCharge
            // 
            this.txtDiagnosticCharge.Location = new System.Drawing.Point(175, 491);
            this.txtDiagnosticCharge.Name = "txtDiagnosticCharge";
            this.txtDiagnosticCharge.Size = new System.Drawing.Size(176, 27);
            this.txtDiagnosticCharge.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(46, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 76;
            this.label9.Text = "費用";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(412, 524);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 98;
            this.btnClear.Text = "清空欄位";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(26, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "飼主名稱";
            // 
            // txtDiagnosticResult
            // 
            this.txtDiagnosticResult.Location = new System.Drawing.Point(175, 331);
            this.txtDiagnosticResult.Multiline = true;
            this.txtDiagnosticResult.Name = "txtDiagnosticResult";
            this.txtDiagnosticResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDiagnosticResult.Size = new System.Drawing.Size(454, 128);
            this.txtDiagnosticResult.TabIndex = 23;
            // 
            // DiagnoseResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1400, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnoseResult";
            this.Text = "看診";
            this.Load += new System.EventHandler(this.DiagnoseResult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnoseData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDiagnoseData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboxSearch;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxDiagnosticStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxDoctor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiagnosticCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiagnosticResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBreederNumber;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblBreederName;
        private System.Windows.Forms.TextBox txtSituation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblNull;
        private System.Windows.Forms.Label lblPetName;
    }
}