using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProject
{
    public partial class PetApplianceOrdersInformation : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchPetID = new List<int>();

        List<int> listCommodityID = new List<int>();
        List<string> listCommodityName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listQuantity = new List<int>();
        List<DateTime> listNextPurchase = new List<DateTime>();
        List<int> listCost = new List<int>();
        List<int> listDiscountedPrice = new List<int>();
        List<string> listDescribe = new List<string>();
        List<string> listCommodityImage = new List<string>();

        //int intDiscountedPrice = Int32.Parse(GlobalVar.DiscountedPriceVar);
        //int intQuantity = 1;
        //int selectedCommodityPrice = 0;

        int intTotalprice = 0;

        public PetApplianceOrdersInformation()
        {
            InitializeComponent();
        }





        private void PetApplianceOrdersInformation_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidProject";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            lblBreederName.Text = "";
            lblBreederAddress.Text = "";


            cboxEmployee.Text = "";
            cboxEmployee.Items.Add("金柏勳");
            cboxEmployee.Items.Add("張武丹");
            cboxEmployee.Items.Add("楊欣潔");

            cboxShip.Text = "";
            cboxShip.Items.Add("自取");
            cboxShip.Items.Add("貨運");

            cboxCommodityName.Items.Add("寵物抗菌噴霧");
            cboxCommodityName.Items.Add("寵物止血粉");
            cboxCommodityName.Items.Add("益生菌");
            cboxCommodityName.Items.Add("高效能活化益生菌");
            cboxCommodityName.Items.Add("鈣粉1");
            cboxCommodityName.Items.Add("鈣粉2");
            cboxCommodityName.Items.Add("綜合維他命");
            cboxCommodityName.Items.Add("除淚痕液");

            //cboxCommoityName1.Items.Add("寵物止血粉");
            //cboxCommoityName1.Items.Add("益生菌");
            //cboxCommoityName1.Items.Add("高效能活化益生菌");
            //cboxCommoityName1.Items.Add("鈣粉1");
            //cboxCommoityName1.Items.Add("鈣粉2");
            //cboxCommoityName1.Items.Add("綜合維他命");
            //cboxCommoityName1.Items.Add("除淚痕液");

            //cboxCommoityName2.Items.Add("寵物止血粉");
            //cboxCommoityName2.Items.Add("益生菌");
            //cboxCommoityName2.Items.Add("高效能活化益生菌");
            //cboxCommoityName2.Items.Add("鈣粉1");
            //cboxCommoityName2.Items.Add("鈣粉2");
            //cboxCommoityName2.Items.Add("綜合維他命");
            //cboxCommoityName2.Items.Add("除淚痕液");

            //cboxCommoityName3.Items.Add("寵物止血粉");
            //cboxCommoityName3.Items.Add("益生菌");
            //cboxCommoityName3.Items.Add("高效能活化益生菌");
            //cboxCommoityName3.Items.Add("鈣粉1");
            //cboxCommoityName3.Items.Add("鈣粉2");
            //cboxCommoityName3.Items.Add("綜合維他命");
            //cboxCommoityName3.Items.Add("除淚痕液");

            //cboxCommoityName4.Items.Add("寵物止血粉");
            //cboxCommoityName4.Items.Add("益生菌");
            //cboxCommoityName4.Items.Add("高效能活化益生菌");
            //cboxCommoityName4.Items.Add("鈣粉1");
            //cboxCommoityName4.Items.Add("鈣粉2");
            //cboxCommoityName4.Items.Add("綜合維他命");
            //cboxCommoityName4.Items.Add("除淚痕液");

            //cboxCommoityName5.Items.Add("寵物止血粉");
            //cboxCommoityName5.Items.Add("益生菌");
            //cboxCommoityName5.Items.Add("高效能活化益生菌");
            //cboxCommoityName5.Items.Add("鈣粉1");
            //cboxCommoityName5.Items.Add("鈣粉2");
            //cboxCommoityName5.Items.Add("綜合維他命");
            //cboxCommoityName5.Items.Add("除淚痕液");

            //cboxCommoityName6.Items.Add("寵物止血粉");
            //cboxCommoityName6.Items.Add("益生菌");
            //cboxCommoityName6.Items.Add("高效能活化益生菌");
            //cboxCommoityName6.Items.Add("鈣粉1");
            //cboxCommoityName6.Items.Add("鈣粉2");
            //cboxCommoityName6.Items.Add("綜合維他命");
            //cboxCommoityName6.Items.Add("除淚痕液");

            cboxSearchMode.Items.Add("日期");
            cboxSearchMode.Items.Add("ID");
            cboxSearchMode.Items.Add("綜合");

            ReadDataBase();
            ShowCommodityTypeImage();

            lblDeleteID.Text = "";

        }





        void ReadDataBase()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from ApplianceData;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            int i = 0;
            while (reader.Read())
            {
                listCommodityID.Add((int)reader["CommodityID"]);
                listCommodityName.Add(reader["CommodityName"].ToString());
                listQuantity.Add((int)reader["Quantity"]);
                listNextPurchase.Add((DateTime)reader["NextPurchase"]);
                listCost.Add((int)reader["Cost"]);
                listPrice.Add((int)reader["Price"]);
                listDiscountedPrice.Add((int)reader["DiscountedPrice"]);
                listDescribe.Add(reader["Describe"].ToString());
                listCommodityImage.Add(reader["CommodityImage"].ToString());


                image_name = reader["CommodityImage"].ToString();
                Image myproductImage = Image.FromFile(image_dir + image_name);
                imageListApplianceData.Images.Add(myproductImage);
                //listViewApplianceData.LargeImageList = imageListApplianceData;
                i += 1;
            }
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();
        }





        private void btnBreederSearch_Click(object sender, EventArgs e)
        {
            if(txtBreederNumber.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from BreederData where BreederNumber = @SearchBreederNumber;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchBreederNumber", txtBreederNumber.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblBreederName.Text = reader["BreederName"].ToString();
                    lblBreederAddress.Text = reader["BreederAddress"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此飼主");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入身分證字號");
            }            
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            if((txtBreederNumber.Text != "") && (cboxEmployee.Text != "") && (cboxShip.Text != ""))
            {
                foreach (ListViewItem lst_item in listViewOrders.Items)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MidProject;Integrated security=True");
                    SqlCommand cmd = new SqlCommand("Insert into OrderData(BreederID,OrderEmployee,PickUpWay,Address,OrderDate,CommodityName,Quantity,Price)Values(@BreederID,@OrderEmployee,@PickUpWay,@Address,@OrderDate,@CommodityName,@Quantity,@Price)", con);
                    cmd.Parameters.AddWithValue("@BreederID", txtBreederNumber.Text);
                    cmd.Parameters.AddWithValue("@OrderEmployee", cboxEmployee.Text);
                    cmd.Parameters.AddWithValue("@PickUpWay", cboxShip.Text);
                    cmd.Parameters.AddWithValue("@Address", txtShipAdress.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value);
                    cmd.Parameters.AddWithValue("@CommodityName", lst_item.SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@Quantity", lst_item.SubItems[1].Text);
                    cmd.Parameters.AddWithValue("@Price", lst_item.SubItems[2].Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("新增訂單成功");

                ClearField();
                RemoveCount();
            }
            else
            {
                MessageBox.Show("請確實填寫所有訂單欄位");
            }
        }




        
        void ClearField()
        {
            txtBreederNumber.Clear();
            txtShipAdress.Clear();
            txtQuantity.Clear();
            //txtQuantity1.Clear();
            //txtQuantity2.Clear();
            //txtQuantity3.Clear();
            //txtQuantity4.Clear();
            //txtQuantity5.Clear();
            //txtQuantity6.Clear();            
            txtOrderSearch.Clear();
            lblBreederName.Text = "";
            lblBreederAddress.Text = "";
            cboxEmployee.Text = "";
            cboxShip.Text = "";
            cboxCommodityName.Text = "";
            //cboxCommoityName1.Text = "";
            //cboxCommoityName2.Text = "";
            //cboxCommoityName3.Text = "";
            //cboxCommoityName4.Text = "";
            //cboxCommoityName5.Text = "";
            //cboxCommoityName6.Text = "";            
            dtpOrderSearch.Text = DateTime.Now.ToLocalTime().ToString();
            dtpOrderDate.Text = DateTime.Now.ToLocalTime().ToString();
            checkboxBreederAddress.Checked = false;
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
                




        void ShowCommodityTypeWord()
        {
            listViewApplianceData.Clear();
            listViewApplianceData.LargeImageList = null;
            listViewApplianceData.SmallImageList = null;
            listViewApplianceData.View = View.Details;
            listViewApplianceData.Columns.Add("序號", 100);
            listViewApplianceData.Columns.Add("品名", 200);
            listViewApplianceData.Columns.Add("數量", 50);
            listViewApplianceData.Columns.Add("下次進貨", 50);
            //listViewApplianceData.Columns.Add("Cost", 80);
            listViewApplianceData.Columns.Add("定價", 80);
            listViewApplianceData.Columns.Add("優惠價", 80);
            listViewApplianceData.Columns.Add("說明", 250);
            //listViewApplianceData.Columns.Add("CommodityImage", 300);
            listViewApplianceData.FullRowSelect = true;
            listViewApplianceData.GridLines = true;

            for (int i = 0; i < listCommodityID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                listViewApplianceData.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listCommodityID[i].ToString();
                item.SubItems.Add(listCommodityName[i]);
                item.SubItems.Add(listQuantity[i].ToString());
                item.SubItems.Add(listNextPurchase[i].ToShortDateString());
                //item.SubItems.Add(listCost[i].ToString());
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listDiscountedPrice[i].ToString());
                item.SubItems.Add(listDescribe[i]);
                //item.SubItems.Add(listCommodityImage[i]);
                item.Tag = listCommodityID[i];

                listViewApplianceData.Items.Add(item);
            }
        }





        private void btnTypeWord_Click(object sender, EventArgs e)
        {
            ShowCommodityTypeWord();
        }





        void ShowCommodityTypeImage()
        {
            listViewApplianceData.Clear();
            listViewApplianceData.View = View.LargeIcon;
            imageListApplianceData.ImageSize = new Size(120, 120);
            listViewApplianceData.LargeImageList = imageListApplianceData;

            for (int i = 0; i < imageListApplianceData.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listCommodityName[i] + " " + listPrice[i] + "元";
                item.Tag = listCommodityID[i];

                listViewApplianceData.Items.Add(item);
            }
        }





        private void btnTypeImage_Click(object sender, EventArgs e)
        {
            ShowCommodityTypeImage();
        }




        

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    txtShipAdress.Text = lblBreederAddress.Text;
        //}

        //private void cboxCommoityName_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(strDBConnectString);
        //    con.Open();
        //    string strSQL = "select * from ApplianceData where CommodityName = @SearchCommodityName;";
        //    SqlCommand cmd = new SqlCommand(strSQL, con);
        //    cmd.Parameters.AddWithValue("@SearchCommodityName", cboxCommodityName.Text);
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    GlobalVar.DiscountedPriceVar = reader["DiscountedPrice"].ToString();

        //    reader.Close();
        //    con.Close();

        //    label5.Text = GlobalVar.DiscountedPriceVar.ToString();

        //    label5.Text = cboxCommodityName.Text.ToString();
        //}





        private void checkboxBreederAddress_Click(object sender, EventArgs e)
        {
            txtShipAdress.Text = lblBreederAddress.Text;
        }

        private void cboxCommoityName_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from ApplianceData where CommodityName = @SearchCommodityName;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCommodityName", cboxCommodityName.Text.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GlobalVar.DiscountedPriceVar = reader["DiscountedPrice"].ToString();
            }
            
            reader.Close();
            con.Close();

            label5.Text = GlobalVar.DiscountedPriceVar.ToString();
            CountPrice();
        }





        void CountPrice()
        {
            int intDiscountedPrice = Int32.Parse(GlobalVar.DiscountedPriceVar);
            int intQuantity = 1;
            int selectedCommodityPrice = 0;
            
            if ((cboxCommodityName.Text != "" ) && (txtQuantity.Text != ""))
            {
                if(Int32.Parse(txtQuantity.Text) > 1)
                {
                    intQuantity= Int32.Parse(txtQuantity.Text);
                    selectedCommodityPrice = intDiscountedPrice * intQuantity;
                }
                else
                {
                    selectedCommodityPrice = intDiscountedPrice * intQuantity;
                }                
            }
            label8.Text = selectedCommodityPrice.ToString();
        }





        private void btnAddLV_Click(object sender, EventArgs e)
        {
            ListViewItem lvAdd = new ListViewItem(cboxCommodityName.Text, 0);
            lvAdd.SubItems.Add(txtQuantity.Text);
            lvAdd.SubItems.Add(label8.Text);
            listViewOrders.Items.Add(lvAdd);
            cboxCommodityName.Text = "";
            txtQuantity.Text = "";

            CountTotalPrice();

            label15.Text = intTotalprice.ToString();
            
        }





        void CountTotalPrice()
        {
            intTotalprice = intTotalprice + Int32.Parse(label8.Text);
        }



        void RemoveCount()
        {
            for (int j = 0; j < listViewOrders.Items.Count; j++)
            {
                listViewOrders.Items.Remove(listViewOrders.Items[j]);
                j--;
            }

            label15.Text = "0";
            intTotalprice = 0;
        }

        private void btnRemoveLV_Click(object sender, EventArgs e)
        {
            RemoveCount();
        }





        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            CountPrice();
        }





        private void btnOrdersSearch_Click(object sender, EventArgs e)
        {
            if(cboxSearchMode.Text != "")
            {
                if(cboxSearchMode.Text == "日期")
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from OrderData where OrderDate = @SearchOrderDate;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchOrderDate", dtpOrderSearch.Value);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvOrderData.DataSource = dt;
                        //lblAppointmentID.Text = "";
                    }
                    else
                    {
                        //lblAppointmentID.Text = "";
                        MessageBox.Show("找不到資料");
                    }
                    reader.Close();
                    con.Close();
                }
                else if(cboxSearchMode.Text == "ID")
                {
                    if(txtOrderSearch.Text != "")
                    {
                        SqlConnection con = new SqlConnection(strDBConnectString);
                        con.Open();
                        string strSQL = "select * from OrderData where BreederID = @SearchBreederID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchBreederID", txtOrderSearch.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvOrderData.DataSource = dt;
                            //lblAppointmentID.Text = "";
                        }
                        else
                        {
                            //lblAppointmentID.Text = "";
                            MessageBox.Show("找不到資料");
                        }
                        reader.Close();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("請輸入飼主身份證號");
                    }
                }
                else
                {
                    if(txtOrderSearch.Text != "")
                    {
                        SqlConnection con = new SqlConnection(strDBConnectString);
                        con.Open();
                        string strSQL = "select * from OrderData where CONVERT(char(8), OrderDate, 112) = @SearchOrderDate and BreederID = @SearchBreederID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchOrderDate", dtpOrderSearch.Value);
                        cmd.Parameters.AddWithValue("@SearchBreederID", txtOrderSearch.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvOrderData.DataSource = dt;
                            //lblAppointmentID.Text = "";
                        }
                        else
                        {
                            //lblAppointmentID.Text = "";
                            MessageBox.Show("找不到資料");
                        }
                        reader.Close();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("所有查詢欄位請填寫完整");
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇搜尋模式");
            }
        }





        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblDeleteID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from OrderData where OrderID = @DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"(已刪除{rows}筆資料)");
                GenerateOrderData();
            }
            else
            {
                MessageBox.Show("請點選訂單資料處欲刪除的資料");
            }
        }





        void GenerateOrderData()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from OrderData";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvOrderData.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }





        private void dgvOrderData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgvOrderData.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from OrderData where OrderID = @SearchOrderID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchOrderID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblDeleteID.Text = reader["OrderID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此筆訂單");

                        ClearField();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }
    }
}
