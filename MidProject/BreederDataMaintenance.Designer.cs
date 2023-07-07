namespace MidProject
{
    partial class BreederDataMaintenance
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBreederID = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpBreederBirth = new System.Windows.Forms.DateTimePicker();
            this.txtBreederPhone = new System.Windows.Forms.TextBox();
            this.txtBreederAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBreederNumber = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBreederName = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRemind = new System.Windows.Forms.Label();
            this.dgvBreederData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBreederID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreederData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.lblBreederID);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.dtpBreederBirth);
            this.groupBox3.Controls.Add(this.txtBreederPhone);
            this.groupBox3.Controls.Add(this.txtBreederAddress);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnModify);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtBreederNumber);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtBreederName);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 725);
            this.groupBox3.TabIndex = 173;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "編輯飼主資料";
            // 
            // lblBreederID
            // 
            this.lblBreederID.AutoSize = true;
            this.lblBreederID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBreederID.ForeColor = System.Drawing.Color.Black;
            this.lblBreederID.Location = new System.Drawing.Point(668, 14);
            this.lblBreederID.Name = "lblBreederID";
            this.lblBreederID.Size = new System.Drawing.Size(24, 25);
            this.lblBreederID.TabIndex = 190;
            this.lblBreederID.Text = "0";
            this.lblBreederID.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(544, 674);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 189;
            this.btnRefresh.Text = "表格重整";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpBreederBirth
            // 
            this.dtpBreederBirth.CalendarFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpBreederBirth.Location = new System.Drawing.Point(181, 129);
            this.dtpBreederBirth.Name = "dtpBreederBirth";
            this.dtpBreederBirth.Size = new System.Drawing.Size(204, 34);
            this.dtpBreederBirth.TabIndex = 175;
            this.dtpBreederBirth.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtBreederPhone
            // 
            this.txtBreederPhone.Location = new System.Drawing.Point(181, 229);
            this.txtBreederPhone.Name = "txtBreederPhone";
            this.txtBreederPhone.Size = new System.Drawing.Size(204, 34);
            this.txtBreederPhone.TabIndex = 174;
            // 
            // txtBreederAddress
            // 
            this.txtBreederAddress.Location = new System.Drawing.Point(181, 179);
            this.txtBreederAddress.Name = "txtBreederAddress";
            this.txtBreederAddress.Size = new System.Drawing.Size(400, 34);
            this.txtBreederAddress.TabIndex = 173;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(40, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 170;
            this.label7.Text = "飼主住址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(20, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 171;
            this.label8.Text = "飼主聯絡電話";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(418, 674);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 168;
            this.btnClear.Text = "清空欄位";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 674);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 167;
            this.btnDelete.Text = "刪除資料";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(166, 674);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(120, 40);
            this.btnModify.TabIndex = 166;
            this.btnModify.Text = "修改資料";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 674);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 165;
            this.btnAdd.Text = "新增資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 69;
            this.label10.Text = "飼主身分證號";
            // 
            // txtBreederNumber
            // 
            this.txtBreederNumber.Location = new System.Drawing.Point(181, 29);
            this.txtBreederNumber.Name = "txtBreederNumber";
            this.txtBreederNumber.Size = new System.Drawing.Size(176, 34);
            this.txtBreederNumber.TabIndex = 70;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.Location = new System.Drawing.Point(40, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 25);
            this.label24.TabIndex = 72;
            this.label24.Text = "飼主姓名";
            // 
            // txtBreederName
            // 
            this.txtBreederName.Location = new System.Drawing.Point(181, 79);
            this.txtBreederName.Name = "txtBreederName";
            this.txtBreederName.Size = new System.Drawing.Size(176, 34);
            this.txtBreederName.TabIndex = 75;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label28.Location = new System.Drawing.Point(40, 129);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 25);
            this.label28.TabIndex = 73;
            this.label28.Text = "飼主生日";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRemind);
            this.groupBox1.Controls.Add(this.dgvBreederData);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtBreederID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(711, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 725);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飼主資料查詢";
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRemind.ForeColor = System.Drawing.Color.Red;
            this.lblRemind.Location = new System.Drawing.Point(293, 688);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(332, 25);
            this.lblRemind.TabIndex = 187;
            this.lblRemind.Text = "請於此處輸入欲查詢飼主身分證字號";
            // 
            // dgvBreederData
            // 
            this.dgvBreederData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreederData.Location = new System.Drawing.Point(17, 33);
            this.dgvBreederData.Name = "dgvBreederData";
            this.dgvBreederData.RowHeadersWidth = 51;
            this.dgvBreederData.RowTemplate.Height = 27;
            this.dgvBreederData.Size = new System.Drawing.Size(832, 635);
            this.dgvBreederData.TabIndex = 0;
            this.dgvBreederData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(729, 674);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.TabIndex = 138;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBreederID
            // 
            this.txtBreederID.Location = new System.Drawing.Point(150, 685);
            this.txtBreederID.Name = "txtBreederID";
            this.txtBreederID.Size = new System.Drawing.Size(137, 34);
            this.txtBreederID.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 139;
            this.label1.Text = "飼主身分證號";
            // 
            // BreederDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1578, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "BreederDataMaintenance";
            this.Text = "飼主資料維護";
            this.Load += new System.EventHandler(this.BreederDataMaintenance_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreederData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBreederPhone;
        private System.Windows.Forms.TextBox txtBreederAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBreederNumber;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBreederName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtpBreederBirth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBreederData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBreederID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.Label lblBreederID;
    }
}