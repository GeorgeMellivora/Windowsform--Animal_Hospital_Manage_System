namespace MidProject
{
    partial class PetApplianceOrdersInformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewApplianceData = new System.Windows.Forms.ListView();
            this.btnTypeWord = new System.Windows.Forms.Button();
            this.btnTypeImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDeleteID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxSearchMode = new System.Windows.Forms.ComboBox();
            this.btnOrdersSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpOrderSearch = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.txtOrderSearch = new System.Windows.Forms.TextBox();
            this.dgvOrderData = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBreederNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBreederName = new System.Windows.Forms.Label();
            this.btnBreederSearch = new System.Windows.Forms.Button();
            this.cboxCommodityName = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveLV = new System.Windows.Forms.Button();
            this.btnAddLV = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkboxBreederAddress = new System.Windows.Forms.CheckBox();
            this.lblBreederAddress = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cboxShip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShipAdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxEmployee = new System.Windows.Forms.ComboBox();
            this.imageListApplianceData = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewApplianceData);
            this.groupBox1.Controls.Add(this.btnTypeWord);
            this.groupBox1.Controls.Add(this.btnTypeImage);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(711, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 381);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品查詢";
            // 
            // listViewApplianceData
            // 
            this.listViewApplianceData.HideSelection = false;
            this.listViewApplianceData.Location = new System.Drawing.Point(17, 66);
            this.listViewApplianceData.Name = "listViewApplianceData";
            this.listViewApplianceData.Size = new System.Drawing.Size(832, 307);
            this.listViewApplianceData.TabIndex = 152;
            this.listViewApplianceData.UseCompatibleStateImageBehavior = false;
            // 
            // btnTypeWord
            // 
            this.btnTypeWord.Location = new System.Drawing.Point(603, 20);
            this.btnTypeWord.Name = "btnTypeWord";
            this.btnTypeWord.Size = new System.Drawing.Size(120, 40);
            this.btnTypeWord.TabIndex = 147;
            this.btnTypeWord.Text = "文字模式";
            this.btnTypeWord.UseVisualStyleBackColor = true;
            this.btnTypeWord.Click += new System.EventHandler(this.btnTypeWord_Click);
            // 
            // btnTypeImage
            // 
            this.btnTypeImage.Location = new System.Drawing.Point(729, 20);
            this.btnTypeImage.Name = "btnTypeImage";
            this.btnTypeImage.Size = new System.Drawing.Size(120, 40);
            this.btnTypeImage.TabIndex = 146;
            this.btnTypeImage.Text = "圖片模式";
            this.btnTypeImage.UseVisualStyleBackColor = true;
            this.btnTypeImage.Click += new System.EventHandler(this.btnTypeImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDeleteID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboxSearchMode);
            this.groupBox2.Controls.Add(this.btnOrdersSearch);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.dtpOrderSearch);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.txtOrderSearch);
            this.groupBox2.Controls.Add(this.dgvOrderData);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(711, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 327);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訂單資料";
            // 
            // lblDeleteID
            // 
            this.lblDeleteID.AutoSize = true;
            this.lblDeleteID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeleteID.Location = new System.Drawing.Point(131, 297);
            this.lblDeleteID.Name = "lblDeleteID";
            this.lblDeleteID.Size = new System.Drawing.Size(92, 25);
            this.lblDeleteID.TabIndex = 229;
            this.lblDeleteID.Text = "????????";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(12, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 228;
            this.label11.Text = "已選項目ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(670, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 25);
            this.label10.TabIndex = 214;
            this.label10.Text = "模式";
            // 
            // cboxSearchMode
            // 
            this.cboxSearchMode.FormattingEnabled = true;
            this.cboxSearchMode.Location = new System.Drawing.Point(728, 228);
            this.cboxSearchMode.Name = "cboxSearchMode";
            this.cboxSearchMode.Size = new System.Drawing.Size(121, 33);
            this.cboxSearchMode.TabIndex = 213;
            // 
            // btnOrdersSearch
            // 
            this.btnOrdersSearch.Location = new System.Drawing.Point(603, 282);
            this.btnOrdersSearch.Name = "btnOrdersSearch";
            this.btnOrdersSearch.Size = new System.Drawing.Size(120, 40);
            this.btnOrdersSearch.TabIndex = 149;
            this.btnOrdersSearch.Text = "查詢訂單";
            this.btnOrdersSearch.UseVisualStyleBackColor = true;
            this.btnOrdersSearch.Click += new System.EventHandler(this.btnOrdersSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(729, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 148;
            this.btnDelete.Text = "刪除訂單";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dtpOrderSearch
            // 
            this.dtpOrderSearch.CalendarFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpOrderSearch.Location = new System.Drawing.Point(427, 227);
            this.dtpOrderSearch.Name = "dtpOrderSearch";
            this.dtpOrderSearch.Size = new System.Drawing.Size(204, 34);
            this.dtpOrderSearch.TabIndex = 146;
            this.dtpOrderSearch.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label28.Location = new System.Drawing.Point(329, 234);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 25);
            this.label28.TabIndex = 145;
            this.label28.Text = "訂購日期";
            // 
            // txtOrderSearch
            // 
            this.txtOrderSearch.Location = new System.Drawing.Point(150, 227);
            this.txtOrderSearch.Name = "txtOrderSearch";
            this.txtOrderSearch.Size = new System.Drawing.Size(137, 34);
            this.txtOrderSearch.TabIndex = 144;
            // 
            // dgvOrderData
            // 
            this.dgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderData.Location = new System.Drawing.Point(17, 33);
            this.dgvOrderData.Name = "dgvOrderData";
            this.dgvOrderData.RowHeadersWidth = 51;
            this.dgvOrderData.RowTemplate.Height = 27;
            this.dgvOrderData.Size = new System.Drawing.Size(832, 188);
            this.dgvOrderData.TabIndex = 0;
            this.dgvOrderData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderData_CellContentDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 147;
            this.label9.Text = "飼主身分證號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "訂單處理人員";
            // 
            // txtBreederNumber
            // 
            this.txtBreederNumber.Location = new System.Drawing.Point(181, 29);
            this.txtBreederNumber.Name = "txtBreederNumber";
            this.txtBreederNumber.Size = new System.Drawing.Size(176, 34);
            this.txtBreederNumber.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "飼主身分證號";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(50, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 81;
            this.label6.Text = "商品名";
            // 
            // lblBreederName
            // 
            this.lblBreederName.AutoSize = true;
            this.lblBreederName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBreederName.Location = new System.Drawing.Point(363, 29);
            this.lblBreederName.Name = "lblBreederName";
            this.lblBreederName.Size = new System.Drawing.Size(92, 25);
            this.lblBreederName.TabIndex = 101;
            this.lblBreederName.Text = "飼主姓名";
            // 
            // btnBreederSearch
            // 
            this.btnBreederSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBreederSearch.Location = new System.Drawing.Point(553, 21);
            this.btnBreederSearch.Name = "btnBreederSearch";
            this.btnBreederSearch.Size = new System.Drawing.Size(120, 40);
            this.btnBreederSearch.TabIndex = 102;
            this.btnBreederSearch.Text = "查詢";
            this.btnBreederSearch.UseVisualStyleBackColor = true;
            this.btnBreederSearch.Click += new System.EventHandler(this.btnBreederSearch_Click);
            // 
            // cboxCommodityName
            // 
            this.cboxCommodityName.FormattingEnabled = true;
            this.cboxCommodityName.Location = new System.Drawing.Point(181, 329);
            this.cboxCommodityName.Name = "cboxCommodityName";
            this.cboxCommodityName.Size = new System.Drawing.Size(176, 33);
            this.cboxCommodityName.TabIndex = 105;
            this.cboxCommodityName.SelectedValueChanged += new System.EventHandler(this.cboxCommoityName_SelectedValueChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(421, 329);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(55, 34);
            this.txtQuantity.TabIndex = 118;
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(363, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 25);
            this.label12.TabIndex = 126;
            this.label12.Text = "數量";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 674);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 165;
            this.btnAdd.Text = "新增訂單";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(544, 674);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 168;
            this.btnClear.Text = "清空欄位";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnRemoveLV);
            this.groupBox3.Controls.Add(this.btnAddLV);
            this.groupBox3.Controls.Add(this.listViewOrders);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.checkboxBreederAddress);
            this.groupBox3.Controls.Add(this.lblBreederAddress);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.dtpOrderDate);
            this.groupBox3.Controls.Add(this.cboxShip);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtShipAdress);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.cboxCommodityName);
            this.groupBox3.Controls.Add(this.btnBreederSearch);
            this.groupBox3.Controls.Add(this.lblBreederName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBreederNumber);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cboxEmployee);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 725);
            this.groupBox3.TabIndex = 137;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "編輯訂單資料";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(487, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 227;
            this.label8.Text = "小總價";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(575, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 226;
            this.label5.Text = "單價";
            this.label5.Visible = false;
            // 
            // btnRemoveLV
            // 
            this.btnRemoveLV.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveLV.Location = new System.Drawing.Point(570, 375);
            this.btnRemoveLV.Name = "btnRemoveLV";
            this.btnRemoveLV.Size = new System.Drawing.Size(120, 40);
            this.btnRemoveLV.TabIndex = 225;
            this.btnRemoveLV.Text = "清除小計";
            this.btnRemoveLV.UseVisualStyleBackColor = true;
            this.btnRemoveLV.Click += new System.EventHandler(this.btnRemoveLV_Click);
            // 
            // btnAddLV
            // 
            this.btnAddLV.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddLV.Location = new System.Drawing.Point(570, 329);
            this.btnAddLV.Name = "btnAddLV";
            this.btnAddLV.Size = new System.Drawing.Size(120, 40);
            this.btnAddLV.TabIndex = 223;
            this.btnAddLV.Text = "加入小計";
            this.btnAddLV.UseVisualStyleBackColor = true;
            this.btnAddLV.Click += new System.EventHandler(this.btnAddLV_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(55, 381);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(492, 250);
            this.listViewOrders.TabIndex = 222;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "品名";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "數量";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "價格";
            this.columnHeader3.Width = 90;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(176, 634);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 25);
            this.label15.TabIndex = 221;
            this.label15.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(50, 634);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 25);
            this.label14.TabIndex = 220;
            this.label14.Text = "總金額";
            // 
            // checkboxBreederAddress
            // 
            this.checkboxBreederAddress.AutoSize = true;
            this.checkboxBreederAddress.Location = new System.Drawing.Point(181, 220);
            this.checkboxBreederAddress.Name = "checkboxBreederAddress";
            this.checkboxBreederAddress.Size = new System.Drawing.Size(134, 29);
            this.checkboxBreederAddress.TabIndex = 219;
            this.checkboxBreederAddress.Text = "同飼主住址";
            this.checkboxBreederAddress.UseVisualStyleBackColor = true;
            this.checkboxBreederAddress.Click += new System.EventHandler(this.checkboxBreederAddress_Click);
            // 
            // lblBreederAddress
            // 
            this.lblBreederAddress.AutoSize = true;
            this.lblBreederAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBreederAddress.Location = new System.Drawing.Point(307, 221);
            this.lblBreederAddress.Name = "lblBreederAddress";
            this.lblBreederAddress.Size = new System.Drawing.Size(52, 25);
            this.lblBreederAddress.TabIndex = 218;
            this.lblBreederAddress.Text = "住址";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(292, 674);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 215;
            this.btnRefresh.Text = "表格重整";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(181, 279);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 34);
            this.dtpOrderDate.TabIndex = 214;
            // 
            // cboxShip
            // 
            this.cboxShip.FormattingEnabled = true;
            this.cboxShip.Location = new System.Drawing.Point(181, 128);
            this.cboxShip.Name = "cboxShip";
            this.cboxShip.Size = new System.Drawing.Size(121, 33);
            this.cboxShip.TabIndex = 212;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 207;
            this.label3.Text = "取貨方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(40, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 204;
            this.label4.Text = "收件地址";
            // 
            // txtShipAdress
            // 
            this.txtShipAdress.Location = new System.Drawing.Point(181, 179);
            this.txtShipAdress.Name = "txtShipAdress";
            this.txtShipAdress.Size = new System.Drawing.Size(400, 34);
            this.txtShipAdress.TabIndex = 203;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(40, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 80;
            this.label7.Text = "購買日期";
            // 
            // cboxEmployee
            // 
            this.cboxEmployee.FormattingEnabled = true;
            this.cboxEmployee.Location = new System.Drawing.Point(181, 79);
            this.cboxEmployee.Name = "cboxEmployee";
            this.cboxEmployee.Size = new System.Drawing.Size(176, 33);
            this.cboxEmployee.TabIndex = 213;
            // 
            // imageListApplianceData
            // 
            this.imageListApplianceData.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListApplianceData.ImageSize = new System.Drawing.Size(256, 256);
            this.imageListApplianceData.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PetApplianceOrdersInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1578, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "PetApplianceOrdersInformation";
            this.Text = "寵物用品訂單資訊";
            this.Load += new System.EventHandler(this.PetApplianceOrdersInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrderData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBreederNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBreederName;
        private System.Windows.Forms.Button btnBreederSearch;
        private System.Windows.Forms.ComboBox cboxCommodityName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShipAdress;
        private System.Windows.Forms.Button btnTypeWord;
        private System.Windows.Forms.Button btnTypeImage;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtOrderSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewApplianceData;
        private System.Windows.Forms.ComboBox cboxShip;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxEmployee;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblBreederAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkboxBreederAddress;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Button btnAddLV;
        private System.Windows.Forms.Button btnRemoveLV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageListApplianceData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxSearchMode;
        private System.Windows.Forms.Button btnOrdersSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpOrderSearch;
        private System.Windows.Forms.Label lblDeleteID;
        private System.Windows.Forms.Label label11;
    }
}