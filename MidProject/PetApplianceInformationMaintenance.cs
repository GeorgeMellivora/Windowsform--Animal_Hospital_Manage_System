using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject
{
    public partial class PetApplianceInformationMaintenance : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDBConnectString = "";
        List<int> listCommodityID = new List<int>();
        List<string> listCommodityName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listQuantity = new List<int>();
        List<DateTime> listNextPurchase = new List<DateTime>();
        List<int> listCost = new List<int>();
        List<int> listDiscountedPrice = new List<int>();
        List<string> listDescribe = new List<string>();
        List<string> listCommodityImage = new List<string>();

        public int CommodityID = 0;
        //string strDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool ModifiedImage = false;
        

        



        public PetApplianceInformationMaintenance()
        {
            InitializeComponent();
        }





        private void PetApplianceInformationMaintenance_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidProject";
            scsb.IntegratedSecurity = true;
            strMyDBConnectString = scsb.ToString();

            ReadDataBase();

            ShowCommodityTypeImage();

            //lbl5.Text = ModeSelect.ToString();
        }





        void ReadDataBase()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectString);
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





        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtCommodityName.Text != "") && (txtQuantity.Text != "") && (txtCost.Text != "") && (txtPrice.Text != "") && (txtDiscountedPrice.Text != "") && (txtDescribe.Text != "") && (pboxCommodityImage.Image != null))
            {
                if (ModifiedImage == true)
                {
                    pboxCommodityImage.Image.Save(image_dir + image_name);                    
                    ModifiedImage = false;
                }
                SqlConnection con = new SqlConnection(strMyDBConnectString);
                con.Open();
                string strSQL = "Insert into ApplianceData values(@NewCommodityName, @NewQuantity, @NewNextPurchase, @NewCost, @NewPrice, @NewDiscountedPrice, @NewDescribe, @NewCommodityImage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //cmd.Parameters.AddWithValue("@SearchCommodityID", lblCommodityID);
                cmd.Parameters.AddWithValue("@NewCommodityName", txtCommodityName.Text);
                cmd.Parameters.AddWithValue("@NewQuantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@NewNextPurchase", dtpNextPurchase.Value);
                int intCost = 0;
                Int32.TryParse(txtCost.Text, out intCost);
                cmd.Parameters.AddWithValue("@NewCost", txtCost.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", txtPrice.Text);
                int intDiscountedPrice = 0;
                Int32.TryParse(txtDiscountedPrice.Text, out intDiscountedPrice);
                cmd.Parameters.AddWithValue("@NewDiscountedPrice", txtDiscountedPrice.Text);
                cmd.Parameters.AddWithValue("@NewDescribe", txtDescribe.Text);
                cmd.Parameters.AddWithValue("@NewCommodityImage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料儲存成功，影響{rows}筆資料");
                ListViewRefresh();
                TableClear();
            }
            else
            {
                MessageBox.Show("請確實填寫所有欄位");
            }
        }





        private void btnModify_Click(object sender, EventArgs e)
        {
            int intCommodityID = 0;
            Int32.TryParse(lblCommodityID.Text, out intCommodityID);

            if ((intCommodityID>0) && (txtCommodityName.Text != "") && (txtQuantity.Text != "") && (txtCost.Text != "") && (txtPrice.Text != "") && (txtDiscountedPrice.Text != "") && (txtDescribe.Text != "") && (pboxCommodityImage.Image != null))
            {
                if (ModifiedImage == true)
                {
                    pboxCommodityImage.Image.Save(image_dir + image_name);
                    ModifiedImage = false;
                }

                SqlConnection con = new SqlConnection(strMyDBConnectString);
                con.Open();
                string strSQL = "update ApplianceData set CommodityName=@NewCommodityName, Quantity=@NewQuantity, NextPurchase=@NewNextPurchase, Cost=@NewCost, Price=@NewPrice,  DiscountedPrice=@NewDiscountedPrice, Describe=@NewDescribe, CommodityImage = @NewCommodityImage where CommodityID=@SearchCommodityID;";
                //CommodityImage = @NewCommodityImage
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchCommodityID", intCommodityID);
                cmd.Parameters.AddWithValue("@NewCommodityName", txtCommodityName.Text);
                int intQuantity = 0;
                Int32.TryParse(txtCost.Text, out intQuantity);
                cmd.Parameters.AddWithValue("@NewQuantity",txtQuantity.Text);                
                cmd.Parameters.AddWithValue("@NewNextPurchase", dtpNextPurchase.Value);
                int intCost = 0;
                Int32.TryParse(txtCost.Text, out intCost);
                cmd.Parameters.AddWithValue("@NewCost",txtCost.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice",txtPrice.Text);
                int intDiscountedPrice = 0;
                Int32.TryParse(txtDiscountedPrice.Text, out intDiscountedPrice);
                cmd.Parameters.AddWithValue("@NewDiscountedPrice",txtDiscountedPrice.Text);
                cmd.Parameters.AddWithValue("@NewDescribe",txtDescribe.Text);
                //lblCommodityImage.Text = "";
                cmd.Parameters.AddWithValue("@NewCommodityImage", image_name);

                //string strSQL1 = "Insert into ApplianceData values(@NewCommodityImage) where CommodityID=@SearchCommodityID;";
                //SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                //cmd.Parameters.AddWithValue("@NewCommodityImage", image_name);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料儲存成功，已修改{rows}筆資料");
                ListViewRefresh();
                TableClear();
            }
            else
            {
                MessageBox.Show("所有欄位皆須填寫");
            }
        }





        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblCommodityID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strMyDBConnectString);
                con.Open();
                string strSQL = "delete from ApplianceData where CommodityID = @DeleteCommodityID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteCommodityID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"(已刪除{rows}筆資料)");
                ListViewRefresh();
                TableClear();

            }
            else
            {
                MessageBox.Show("請双擊點選右方欲刪除的資料");
            }
        }





        void TableClear()
        {
            txtCommodityName.Clear();
            txtQuantity.Clear();
            dtpNextPurchase.Text = DateTime.Now.ToLocalTime().ToString();
            txtCost.Clear();
            txtPrice.Clear();
            txtDiscountedPrice.Clear();
            txtDescribe.Clear();
            pboxCommodityImage.Image = null;
            lblCommodityID.Text = "";
            lblCommodityImage.Text = "";
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            TableClear();

        }





        void ListViewRefresh()
        {
            listCommodityID.Clear();
            listCommodityName.Clear();
            listQuantity.Clear();
            listNextPurchase.Clear();
            listCost.Clear();
            listPrice.Clear();
            listDiscountedPrice.Clear();
            listDescribe.Clear();
            imageListApplianceData.Images.Clear();

            ReadDataBase();

            if (listViewApplianceData.View == View.Details)
            {
                ShowCommodityTypeWord();
            }
            else
            {
                ShowCommodityTypeImage();
            }
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListViewRefresh();
        }





        void ShowCommodityTypeWord()
        {
            listViewApplianceData.Clear();
            listViewApplianceData.LargeImageList = null;
            listViewApplianceData.SmallImageList = null;
            listViewApplianceData.View = View.Details;
            listViewApplianceData.Columns.Add("CommodityID", 100);
            listViewApplianceData.Columns.Add("CommodityName", 200);
            listViewApplianceData.Columns.Add("Quantity", 50);
            listViewApplianceData.Columns.Add("NextPurchase", 50);
            listViewApplianceData.Columns.Add("Cost", 80);
            listViewApplianceData.Columns.Add("Price", 80);
            listViewApplianceData.Columns.Add("DiscountedPrice", 80);
            listViewApplianceData.Columns.Add("Describe", 250);
            listViewApplianceData.Columns.Add("CommodityImage",300);
            listViewApplianceData.FullRowSelect = true;
            listViewApplianceData.GridLines = true;

            for (int i = 0; i < listCommodityID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                listViewApplianceData.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listCommodityID[i].ToString();
                item.SubItems.Add(listCommodityName[i]);                
                item.SubItems.Add(listQuantity[i].ToString());
                item.SubItems.Add(listNextPurchase[i].ToString());
                item.SubItems.Add(listCost[i].ToString());
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listDiscountedPrice[i].ToString());
                item.SubItems.Add(listDescribe[i]);
                item.SubItems.Add(listCommodityImage[i]);
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





        private void btnCommoditySearch_Click(object sender, EventArgs e)
        {            
            //if((txtCommoditySearch1.Text != "") && (txtCommoditySearch2.Text == ""))
            //{
            //    SqlConnection con = new SqlConnection(strMyDBConnectString);
            //    con.Open();
            //    string strSQL = "select * from ApplianceData where CommodityName=@SearchCommodityName;";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);

            //    cmd.Parameters.AddWithValue("@NewCommodityName", txtCommoditySearch1.Text);

            //    SqlDataReader reader = cmd.ExecuteReader();                

            //    string image_dir = @"images\";
            //    string image_name = "";
            //    int i = 0;
            //    while (reader.Read())
            //    {
            //        listCommodityID.Add((int)reader["CommodityID"]);
            //        listCommodityName.Add(reader["CommodityName"].ToString());
            //        listQuantity.Add((int)reader["Quantity"]);
            //        listNextPurchase.Add((DateTime)reader["NextPurchase"]);
            //        listCost.Add((int)reader["Cost"]);
            //        listPrice.Add((int)reader["Price"]);
            //        listDiscountedPrice.Add((int)reader["DiscountedPrice"]);
            //        listDescribe.Add(reader["Describe"].ToString());
            //        listCommodityImage.Add(reader["CommodityImage"].ToString());

                    
            //        image_name = reader["CommodityImage"].ToString();
            //        Image myproductImage = Image.FromFile(image_dir + image_name);
            //        imageListApplianceData.Images.Add(myproductImage);
            //        //listViewApplianceData.LargeImageList = imageListApplianceData;
            //        i += 1;
            //    }
            //    Console.WriteLine($"讀取{i}筆資料");
            //    reader.Close();
            //    con.Close();
            //}
            //else if((txtCommoditySearch1.Text == "") & (txtCommoditySearch2.Text != ""))
            //{
            //    SqlConnection con = new SqlConnection(strMyDBConnectString);
            //    con.Open();
            //    string strSQL = "select * from ApplianceData where CommodityID=@SearchCommodityID;";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);

            //    int intCommodityID = 0;
            //    Int32.TryParse(lblCommodityID.Text, out intCommodityID);
            //    cmd.Parameters.AddWithValue("@SearchCommodityID", intCommodityID);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    string image_dir = @"images\";
            //    string image_name = "";
            //    int i = 0;
            //    while (reader.Read())
            //    {
            //        listCommodityID.Add((int)reader["CommodityID"]);
            //        listCommodityName.Add(reader["CommodityName"].ToString());
            //        listQuantity.Add((int)reader["Quantity"]);
            //        listNextPurchase.Add((DateTime)reader["NextPurchase"]);
            //        listCost.Add((int)reader["Cost"]);
            //        listPrice.Add((int)reader["Price"]);
            //        listDiscountedPrice.Add((int)reader["DiscountedPrice"]);
            //        listDescribe.Add(reader["Describe"].ToString());
            //        listCommodityImage.Add(reader["CommodityImage"].ToString());


            //        image_name = reader["CommodityImage"].ToString();
            //        Image myproductImage = Image.FromFile(image_dir + image_name);
            //        imageListApplianceData.Images.Add(myproductImage);
            //        //listViewApplianceData.LargeImageList = imageListApplianceData;
            //        i += 1;
            //    }
            //    Console.WriteLine($"讀取{i}筆資料");
            //    reader.Close();
            //    con.Close();
            //}
            //else if((txtCommoditySearch1.Text != "") & (txtCommoditySearch2.Text != ""))
            //{
            //    SqlConnection con = new SqlConnection(strMyDBConnectString);
            //    con.Open();
            //    string strSQL = "select * from ApplianceData where CommodityID=@SearchCommodityID && CommodityName=@SearchCommodityName;";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);

            //    int intCommodityID = 0;
            //    Int32.TryParse(lblCommodityID.Text, out intCommodityID);
            //    cmd.Parameters.AddWithValue("@SearchCommodityID", intCommodityID);
            //    cmd.Parameters.AddWithValue("@SearchCommodityName", txtCommoditySearch1.Text);

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    string image_dir = @"images\";
            //    string image_name = "";
            //    int i = 0;
            //    while (reader.Read())
            //    {
            //        listCommodityID.Add((int)reader["CommodityID"]);
            //        listCommodityName.Add(reader["CommodityName"].ToString());
            //        listQuantity.Add((int)reader["Quantity"]);
            //        listNextPurchase.Add((DateTime)reader["NextPurchase"]);
            //        listCost.Add((int)reader["Cost"]);
            //        listPrice.Add((int)reader["Price"]);
            //        listDiscountedPrice.Add((int)reader["DiscountedPrice"]);
            //        listDescribe.Add(reader["Describe"].ToString());
            //        listCommodityImage.Add(reader["CommodityImage"].ToString());


            //        image_name = reader["CommodityImage"].ToString();
            //        Image myproductImage = Image.FromFile(image_dir + image_name);
            //        imageListApplianceData.Images.Add(myproductImage);
            //        //listViewApplianceData.LargeImageList = imageListApplianceData;
            //        i += 1;
            //    }
            //    Console.WriteLine($"讀取{i}筆資料");
            //    reader.Close();
            //    con.Close();
            //}
            //else
            //{
            //    MessageBox.Show("請輸入商品名稱或商品代碼");
            //}
        }





        private void listViewApplianceData_ItemActivate(object sender, EventArgs e)
        {
            CommodityID = (int)listViewApplianceData.SelectedItems[0].Tag;
            ShowCommodityData();
        }





        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog AddImage = new OpenFileDialog();
            AddImage.Filter = "檔案類型(*.jpg, *.jpeg, *.png)|*.jpeg; *.jpg; *.png";
            DialogResult DR = AddImage.ShowDialog();
            if (DR == DialogResult.OK)
            {
                pboxCommodityImage.Image = Image.FromFile(AddImage.FileName);
                string fileExtension = System.IO.Path.GetExtension(AddImage.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExtension;
                ModifiedImage = true;
                Console.WriteLine(image_name);
            }
        }





        void ShowCommodityData()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectString);
            con.Open();
            string strSQL = "select * from ApplianceData where CommodityID = @SearchCommodityID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCommodityID", CommodityID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                lblCommodityID.Text = reader["CommodityID"].ToString();
                txtCommodityName.Text = reader["CommodityName"].ToString();
                txtQuantity.Text = reader["Quantity"].ToString();
                dtpNextPurchase.Value = Convert.ToDateTime(reader["NextPurchase"]);
                txtCost.Text = reader["Cost"].ToString();
                txtPrice.Text = reader["Price"].ToString();
                txtDiscountedPrice.Text = reader["DiscountedPrice"].ToString();
                txtDescribe.Text = reader["Describe"].ToString();
                image_name = reader["CommodityImage"].ToString();
                //lblCommodityImage.Text = reader["CommodityImage"].ToString();
                pboxCommodityImage.Image = Image.FromFile(image_dir + image_name);
                lblCommodityImage.Text = reader["CommodityImage"].ToString();
                i += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"查詢{i}筆資料");
        }
    }
}
