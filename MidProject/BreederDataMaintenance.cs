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
    public partial class BreederDataMaintenance : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchPetID = new List<int>();

        public BreederDataMaintenance()
        {
            InitializeComponent();
        }





        private void BreederDataMaintenance_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidProject";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            lblRemind.Text = "";

            GenerateBreederData();
        }
        




        void GenerateBreederData()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select * from BreederData";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvBreederData.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtBreederNumber.Text != "") && (txtBreederName.Text != "") && (txtBreederAddress.Text != "") && (txtBreederPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into BreederData values (@NewBreederNumber, @NewBreederName, @NewBreederBirth, @NewBreederAddress, @NewBreederPhone);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", txtBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewBreederName", txtBreederName.Text);
                cmd.Parameters.AddWithValue("NewBreederBirth", dtpBreederBirth.Value);
                cmd.Parameters.AddWithValue("NewBreederAddress", txtBreederAddress.Text);
                cmd.Parameters.AddWithValue("NewBreederPhone", txtBreederPhone.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"已新增({rows}筆資料)");
                GenerateBreederData();
            }
            else
            {
                ClearField();
                MessageBox.Show("請將欄位完整填寫，缺一不可");
            }
        }





        private void btnModify_Click(object sender, EventArgs e)
        {
            int intBreederID = 0;
            Int32.TryParse(lblBreederID.Text, out intBreederID);

            if ((intBreederID>0) &&(txtBreederNumber.Text != "") && (txtBreederName.Text != "") && (txtBreederAddress.Text != "") && (txtBreederPhone.Text != ""))
            {              
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update BreederData set BreederNumber=@NewBreederNumber, BreederName=@NewBreederName, BreederBirth=@NewBreederBirth, BreederAddress=@NewBreederAddress, BreederPhone=@NewBreederPhone where BreederID = @SearchBreederID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", txtBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewBreederName", txtBreederName.Text);
                cmd.Parameters.AddWithValue("NewBreederBirth", dtpBreederBirth.Value);
                cmd.Parameters.AddWithValue("NewBreederAddress", txtBreederAddress.Text);
                cmd.Parameters.AddWithValue("NewBreederPhone", txtBreederPhone.Text);                
                cmd.Parameters.AddWithValue("SearchBreederID", intBreederID);

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"已修改({rows}筆資料)");
                con.Close();

                string strSelectedID = lblBreederID.Text.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);
                SqlConnection concc = new SqlConnection(strDBConnectString);
                concc.Open();
                string strSQLcc = "select * from BreederData where BreederID = @SearchBreederID;";
                SqlCommand cmdcc = new SqlCommand(strSQLcc, concc);
                cmdcc.Parameters.AddWithValue("@SearchBreederID", intSelectedID);
                SqlDataReader reader = cmdcc.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvBreederData.DataSource = dt;
                }
                reader.Close();
                concc.Close();
                lblBreederID.Text = "";

            }
            else
            {
                ClearField();
                MessageBox.Show("請將欄位完整填寫，缺一不可\nP.S.資料請先從右方選取後再修改");
            }
        }





        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblBreederID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from BreederData where BreederID = @DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"(已刪除{rows}筆資料)");
                GenerateBreederData();
                lblBreederID.Text = "";
            }
            else
            {
                MessageBox.Show("請雙擊點選右方欲刪除的資料");
            }
        }





        void ClearField()
        {
            txtBreederNumber.Clear();
            txtBreederName.Clear();
            dtpBreederBirth.Value = new DateTime(1990, 1, 1, 0, 0, 0);
            txtBreederAddress.Clear();
            txtBreederPhone.Clear();
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
            lblBreederID.Text = "";
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBreederID.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from BreederData where BreederNumber like @SearchBreederNumber;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchBreederNumber", "%" + txtBreederID.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvBreederData.DataSource = dt;
                    lblRemind.Text = "";
                    lblBreederID.Text = "";
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





        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgvBreederData.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from BreederData where BreederID = @SearchBreederID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchBreederID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblBreederID.Text = reader["BreederID"].ToString();
                        txtBreederNumber.Text = reader["BreederNumber"].ToString();
                        txtBreederName.Text = reader["BreederName"].ToString();
                        dtpBreederBirth.Value = Convert.ToDateTime(reader["BreederBirth"]);
                        txtBreederAddress.Text = reader["BreederAddress"].ToString();
                        txtBreederPhone.Text = reader["BreederPhone"].ToString();                     
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
            GenerateBreederData();
            lblBreederID.Text = "";
        }
    }
}
