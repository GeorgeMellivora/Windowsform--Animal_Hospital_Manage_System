namespace MidProject
{
    partial class PetHospital
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_MainArea = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManagerInformation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPetApplianceOrdersInformance = new System.Windows.Forms.Button();
            this.btnPetDataMaintenance = new System.Windows.Forms.Button();
            this.btnBreederDataMaintenance = new System.Windows.Forms.Button();
            this.btnHumanResourceDataMaintenance = new System.Windows.Forms.Button();
            this.btnPetApplianceInformationMaintenance = new System.Windows.Forms.Button();
            this.lbl動物醫院系統 = new System.Windows.Forms.Label();
            this.linkLabelAppointment = new System.Windows.Forms.LinkLabel();
            this.linkLabelDiagnose = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeJobTitile = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MainArea
            // 
            this.panel_MainArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_MainArea.AutoScroll = true;
            this.panel_MainArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_MainArea.Location = new System.Drawing.Point(178, 150);
            this.panel_MainArea.Name = "panel_MainArea";
            this.panel_MainArea.Size = new System.Drawing.Size(1400, 595);
            this.panel_MainArea.TabIndex = 0;
            this.panel_MainArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnManagerInformation);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnPetApplianceOrdersInformance);
            this.panel2.Controls.Add(this.btnPetDataMaintenance);
            this.panel2.Controls.Add(this.btnBreederDataMaintenance);
            this.panel2.Controls.Add(this.btnHumanResourceDataMaintenance);
            this.panel2.Controls.Add(this.btnPetApplianceInformationMaintenance);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 730);
            this.panel2.TabIndex = 1;
            // 
            // btnManagerInformation
            // 
            this.btnManagerInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManagerInformation.Location = new System.Drawing.Point(3, 371);
            this.btnManagerInformation.Name = "btnManagerInformation";
            this.btnManagerInformation.Size = new System.Drawing.Size(154, 47);
            this.btnManagerInformation.TabIndex = 7;
            this.btnManagerInformation.Text = "管理資訊";
            this.btnManagerInformation.UseVisualStyleBackColor = false;
            this.btnManagerInformation.Visible = false;
            this.btnManagerInformation.Click += new System.EventHandler(this.btnManagerInformation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(3, 678);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "結束";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPetApplianceOrdersInformance
            // 
            this.btnPetApplianceOrdersInformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPetApplianceOrdersInformance.Location = new System.Drawing.Point(3, 11);
            this.btnPetApplianceOrdersInformance.Name = "btnPetApplianceOrdersInformance";
            this.btnPetApplianceOrdersInformance.Size = new System.Drawing.Size(154, 47);
            this.btnPetApplianceOrdersInformance.TabIndex = 4;
            this.btnPetApplianceOrdersInformance.Text = "寵物用品訂單資訊";
            this.btnPetApplianceOrdersInformance.UseVisualStyleBackColor = false;
            this.btnPetApplianceOrdersInformance.Click += new System.EventHandler(this.btnPetApplianceOrdersInformance_Click);
            // 
            // btnPetDataMaintenance
            // 
            this.btnPetDataMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPetDataMaintenance.ForeColor = System.Drawing.Color.Black;
            this.btnPetDataMaintenance.Location = new System.Drawing.Point(3, 155);
            this.btnPetDataMaintenance.Name = "btnPetDataMaintenance";
            this.btnPetDataMaintenance.Size = new System.Drawing.Size(154, 47);
            this.btnPetDataMaintenance.TabIndex = 2;
            this.btnPetDataMaintenance.Text = "寵物資料維護";
            this.btnPetDataMaintenance.UseVisualStyleBackColor = false;
            this.btnPetDataMaintenance.Click += new System.EventHandler(this.btnPetDataMaintenance_Click);
            // 
            // btnBreederDataMaintenance
            // 
            this.btnBreederDataMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBreederDataMaintenance.ForeColor = System.Drawing.Color.Black;
            this.btnBreederDataMaintenance.Location = new System.Drawing.Point(3, 83);
            this.btnBreederDataMaintenance.Name = "btnBreederDataMaintenance";
            this.btnBreederDataMaintenance.Size = new System.Drawing.Size(154, 47);
            this.btnBreederDataMaintenance.TabIndex = 1;
            this.btnBreederDataMaintenance.Text = "飼主資料維護";
            this.btnBreederDataMaintenance.UseVisualStyleBackColor = false;
            this.btnBreederDataMaintenance.Click += new System.EventHandler(this.btnBreederDataMaintenance_Click);
            // 
            // btnHumanResourceDataMaintenance
            // 
            this.btnHumanResourceDataMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHumanResourceDataMaintenance.ForeColor = System.Drawing.Color.Black;
            this.btnHumanResourceDataMaintenance.Location = new System.Drawing.Point(3, 299);
            this.btnHumanResourceDataMaintenance.Name = "btnHumanResourceDataMaintenance";
            this.btnHumanResourceDataMaintenance.Size = new System.Drawing.Size(154, 47);
            this.btnHumanResourceDataMaintenance.TabIndex = 0;
            this.btnHumanResourceDataMaintenance.Text = "人事資料維護";
            this.btnHumanResourceDataMaintenance.UseVisualStyleBackColor = false;
            this.btnHumanResourceDataMaintenance.Click += new System.EventHandler(this.btnHumanResourceDataMaintenance_Click);
            // 
            // btnPetApplianceInformationMaintenance
            // 
            this.btnPetApplianceInformationMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPetApplianceInformationMaintenance.ForeColor = System.Drawing.Color.Black;
            this.btnPetApplianceInformationMaintenance.Location = new System.Drawing.Point(3, 227);
            this.btnPetApplianceInformationMaintenance.Name = "btnPetApplianceInformationMaintenance";
            this.btnPetApplianceInformationMaintenance.Size = new System.Drawing.Size(154, 47);
            this.btnPetApplianceInformationMaintenance.TabIndex = 6;
            this.btnPetApplianceInformationMaintenance.Text = "寵物商品資訊維護";
            this.btnPetApplianceInformationMaintenance.UseVisualStyleBackColor = false;
            this.btnPetApplianceInformationMaintenance.Click += new System.EventHandler(this.btnPetApplianceInformationMaintenance_Click);
            // 
            // lbl動物醫院系統
            // 
            this.lbl動物醫院系統.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl動物醫院系統.AutoSize = true;
            this.lbl動物醫院系統.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl動物醫院系統.Location = new System.Drawing.Point(650, 15);
            this.lbl動物醫院系統.Name = "lbl動物醫院系統";
            this.lbl動物醫院系統.Size = new System.Drawing.Size(282, 55);
            this.lbl動物醫院系統.TabIndex = 2;
            this.lbl動物醫院系統.Text = "毛孩動物醫院";
            // 
            // linkLabelAppointment
            // 
            this.linkLabelAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelAppointment.AutoSize = true;
            this.linkLabelAppointment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelAppointment.Location = new System.Drawing.Point(655, 95);
            this.linkLabelAppointment.Name = "linkLabelAppointment";
            this.linkLabelAppointment.Size = new System.Drawing.Size(52, 25);
            this.linkLabelAppointment.TabIndex = 3;
            this.linkLabelAppointment.TabStop = true;
            this.linkLabelAppointment.Text = "掛號";
            this.linkLabelAppointment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAppointment_LinkClicked);
            // 
            // linkLabelDiagnose
            // 
            this.linkLabelDiagnose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelDiagnose.AutoSize = true;
            this.linkLabelDiagnose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelDiagnose.Location = new System.Drawing.Point(880, 95);
            this.linkLabelDiagnose.Name = "linkLabelDiagnose";
            this.linkLabelDiagnose.Size = new System.Drawing.Size(52, 25);
            this.linkLabelDiagnose.TabIndex = 4;
            this.linkLabelDiagnose.TabStop = true;
            this.linkLabelDiagnose.Text = "診斷";
            this.linkLabelDiagnose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDiagnose_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "您好";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmployeeName.Location = new System.Drawing.Point(231, 16);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(72, 25);
            this.lblEmployeeName.TabIndex = 6;
            this.lblEmployeeName.Text = "中姓名";
            // 
            // lblEmployeeJobTitile
            // 
            this.lblEmployeeJobTitile.AutoSize = true;
            this.lblEmployeeJobTitile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmployeeJobTitile.Location = new System.Drawing.Point(309, 16);
            this.lblEmployeeJobTitile.Name = "lblEmployeeJobTitile";
            this.lblEmployeeJobTitile.Size = new System.Drawing.Size(206, 25);
            this.lblEmployeeJobTitile.TabIndex = 7;
            this.lblEmployeeJobTitile.Text = "lblEmployeeJobTitile";
            // 
            // PetHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.lblEmployeeJobTitile);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelDiagnose);
            this.Controls.Add(this.linkLabelAppointment);
            this.Controls.Add(this.lbl動物醫院系統);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_MainArea);
            this.MinimizeBox = false;
            this.Name = "PetHospital";
            this.Load += new System.EventHandler(this.PetHospital_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_MainArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHumanResourceDataMaintenance;
        private System.Windows.Forms.Label lbl動物醫院系統;
        private System.Windows.Forms.Button btnPetDataMaintenance;
        private System.Windows.Forms.Button btnBreederDataMaintenance;
        private System.Windows.Forms.Button btnPetApplianceOrdersInformance;
        private System.Windows.Forms.LinkLabel linkLabelAppointment;
        private System.Windows.Forms.LinkLabel linkLabelDiagnose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManagerInformation;
        private System.Windows.Forms.Button btnPetApplianceInformationMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeJobTitile;
    }
}

