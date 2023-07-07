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

namespace MidProject
{
    public partial class PetDataMaintance : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchPetID = new List<int>();

        public PetDataMaintance()
        {
            InitializeComponent();
        }





        private void PetDataMaintance_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱(@--字串忽略特殊符號)
            scsb.InitialCatalog = "MidProject"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strDBConnectString = scsb.ToString();

            cboxPetSex.Items.Add("M");
            cboxPetSex.Items.Add("F");

            GeneratePetData();

            lblRemind.Text = "";
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtBreederNumber.Text != "") && (txtPetName.Text != "") && (txtPetSort.Text != "") && (cboxPetSex.Text != "") && (txtPetWeight.Text != "") && (txtPetFeature.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into PetData values (@NewBreederNumber, @NewPetName, @NewPetBirth, @NewPetSort, @NewPetSex, @NewPetWeight, @NewPetFeature);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", txtBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewPetName", txtPetName.Text);
                cmd.Parameters.AddWithValue("NewPetBirth", dtpPetBirth.Value);
                cmd.Parameters.AddWithValue("NewPetSort", txtPetSort.Text);
                cmd.Parameters.AddWithValue("NewPetSex", cboxPetSex.Text);
                int intPetWeight = 0;
                Int32.TryParse(txtPetWeight.Text, out intPetWeight);
                cmd.Parameters.AddWithValue("NewPetWeight", intPetWeight);
                cmd.Parameters.AddWithValue("NewPetFeature", txtPetFeature.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"已新增({rows}筆資料)");
                GeneratePetData();
            }
            else
            {
                ClearField();
                MessageBox.Show("請將欄位完整填寫，缺一不可");
            }
        }





        private void btnModify_Click(object sender, EventArgs e)
        {
            int intPetID = 0;
            Int32.TryParse(lblPetID.Text, out intPetID);

            if ((txtBreederNumber.Text != "") && (txtPetName.Text != "") && (txtPetSort.Text != "") && (cboxPetSex.Text != "") && (txtPetWeight.Text != "") && (txtPetFeature.Text != ""))
            {                
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update PetData set BreederNumber=@NewBreederNumber, PetName=@NewPetName, PetBirth=@NewPetBirth, PetSort=@NewPetSort, PetSex=@NewPetSex, PetWeight=@NewPetWeight, PetFeature=@NewPetFeature where PetID = @SearchPetID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", txtBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewPetName", txtPetName.Text);
                cmd.Parameters.AddWithValue("NewPetBirth", dtpPetBirth.Value);
                cmd.Parameters.AddWithValue("NewPetSort", txtPetSort.Text);
                cmd.Parameters.AddWithValue("NewPetSex", cboxPetSex.Text);
                int intPetWeight = 0;
                Int32.TryParse(txtPetWeight.Text, out intPetWeight);
                cmd.Parameters.AddWithValue("NewPetWeight", intPetWeight);
                cmd.Parameters.AddWithValue("NewPetFeature", txtPetFeature.Text);
                cmd.Parameters.AddWithValue("SearchPetID", intPetID);

                int rows = cmd.ExecuteNonQuery();                
                MessageBox.Show($"已修改({rows}筆資料)");                
                con.Close();

                string strSelectedID = lblPetID.Text.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);
                SqlConnection concc = new SqlConnection(strDBConnectString);
                concc.Open();
                string strSQLcc = "select * from PetData where PetID = @SearchPetID;";
                SqlCommand cmdcc = new SqlCommand(strSQLcc, concc);
                cmdcc.Parameters.AddWithValue("@SearchPetID", intSelectedID);
                SqlDataReader reader = cmdcc.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvPetData.DataSource = dt;
                }
                reader.Close();
                concc.Close();

            }
            else
            {
                ClearField();
                MessageBox.Show("請將欄位完整填寫，缺一不可");
            }
        }
        




        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblPetID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from PetData where PetID = @DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"(已刪除{rows}筆資料)");
                GeneratePetData();
            }
            else
            {
                MessageBox.Show("請點選右方欲刪除的資料");
            }
        }





        void ClearField()
        {
            txtBreederNumber.Clear();
            txtPetName.Clear();
            dtpPetBirth.Value = new DateTime(1990, 1, 1, 0, 0, 0);
            txtPetSort.Clear();
            cboxPetSex.Text = "";
            txtPetWeight.Clear();
            txtPetFeature.Clear();           
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBreederID.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from PetData where BreederNumber like @SearchBreederNumber;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchBreederNumber", "%" + txtBreederID.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvPetData.DataSource = dt;
                    lblRemind.Text = "";
                }
                else
                {
                    lblRemind.Text = "";
                    MessageBox.Show("找不到資料");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入飼主身分證字號");
                lblRemind.Text = "請於此處輸入欲查詢飼主身分證字號";
            }
        }





        void GeneratePetData()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from PetData";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvPetData.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }





        private void dgvPetData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }





        private void dgvPetData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgvPetData.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from PetData where PetID = @SearchPetID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchPetID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblPetID.Text = reader["PetID"].ToString();
                        txtBreederNumber.Text = reader["BreederNumber"].ToString();
                        txtPetName.Text = reader["PetName"].ToString();
                        dtpPetBirth.Value = Convert.ToDateTime(reader["PetBirth"]);
                        txtPetSort.Text = reader["PetSort"].ToString();
                        cboxPetSex.Text = reader["PetSex"].ToString();
                        txtPetWeight.Text = reader["PetWeight"].ToString();
                        txtPetFeature.Text = reader["PetFeature"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此毛孩");

                        ClearField();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GeneratePetData();
        }
    }
}
