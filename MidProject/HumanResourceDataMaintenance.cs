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
    public partial class HumanResourceDataMaintenance : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchHRID = new List<int>();

        public HumanResourceDataMaintenance()
        {
            InitializeComponent();
        }

        private void HumanResourceDataMaintenance_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱(@--字串忽略特殊符號)
            scsb.InitialCatalog = "MidProject"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strDBConnectString = scsb.ToString();

            cboxJobTitle.Items.Add("醫師");
            cboxJobTitle.Items.Add("助理");

            GenerateHRData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((cboxJobTitle.Text != "") && (txtEployeeName.Text != "") && (txtIDCardnumber.Text != "") && (txtEmployeePhone.Text != "") && (txtEmployeeSalary.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into HRData values (@NewEmployeeName, @NewJobTitle, @NewIDCardNumber, @NewEmployeeBirth, @NewEmployeePhone, @NewEmployeeSalary);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewEmployeeName", txtEployeeName.Text);
                cmd.Parameters.AddWithValue("NewJobTitle", cboxJobTitle.Text);
                cmd.Parameters.AddWithValue("NewIDCardNumber", txtIDCardnumber.Text);
                cmd.Parameters.AddWithValue("NewEmployeeBirth", dtpEmployeeBirth.Value);
                cmd.Parameters.AddWithValue("NewEmployeePhone", txtEmployeePhone.Text);
                int intEmployeeSalary = 0;
                Int32.TryParse(txtEmployeeSalary.Text, out intEmployeeSalary);
                cmd.Parameters.AddWithValue("NewEmployeeSalary", intEmployeeSalary);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"已新增({rows}筆資料)");
                GenerateHRData();
            }
            else
            {
                MessageBox.Show("請將欄位完整填寫，缺一不可");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int intHRID = 0;
            Int32.TryParse(lblHRID.Text, out intHRID);

            if ( (intHRID > 0) && (cboxJobTitle.Text != "") && (txtEployeeName.Text != "" )&& (txtIDCardnumber.Text != "") && (txtEmployeePhone.Text != "") && (txtEmployeeSalary.Text != ""))
            {
                int idxRow = dgvHRData.CurrentRow.Index;
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update HRData set EmployeeName=@NewEmployeeName, JobTitle=@NewJobTitle, IDCardNumber=@NewIDCardNumber, EmployeeBirth=@NewEmployeeBirth, EmployeePhone=@NewEmployeePhone, EmployeeSalary=@NewEmployeeSalary where HRID = @SearchHRID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewEmployeeName", txtEployeeName.Text);
                cmd.Parameters.AddWithValue("NewJobTitle", cboxJobTitle.Text);
                cmd.Parameters.AddWithValue("NewIDCardNumber", txtIDCardnumber.Text);
                cmd.Parameters.AddWithValue("NewEmployeeBirth", dtpEmployeeBirth.Value);
                cmd.Parameters.AddWithValue("NewEmployeePhone", txtEmployeePhone.Text);
                int intEmployeeSalary = 0;
                Int32.TryParse(txtEmployeeSalary.Text,out intEmployeeSalary);
                cmd.Parameters.AddWithValue("NewEmployeeSalary", intEmployeeSalary);
                cmd.Parameters.AddWithValue("SearchHRID",intHRID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"已修改({rows}筆資料)");                
                GenerateHRData();
                dgvHRData.CurrentCell = dgvHRData.Rows[idxRow].Cells[0];
            }
            else
            {
                MessageBox.Show("請將欄位完整填寫，缺一不可");
            }
        }

            private void btnDelete_Click(object sender, EventArgs e)
            {
            int intID = 0;
            Int32.TryParse(lblHRID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from HRData where HRID = @DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"(已刪除{rows}筆資料)");
                GenerateHRData();
            }
            else
            {
                MessageBox.Show("請點選右方欲刪除的資料");
            }
        }
        

            private void btnClear_Click(object sender, EventArgs e)
            {
                ClearField();
            }

            void GenerateHRData()
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from HRData";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvHRData.DataSource = dt;
                }
                reader.Close();
                con.Close();
            }

            private void dgvHRData_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    string strSelectedID = dgvHRData.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int intSelectedID = 0;
                    bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                    if (isID == true)
                    {
                        SqlConnection con = new SqlConnection(strDBConnectString);
                        con.Open();
                        string strSQL = "select * from HRData where HRID = @SearchHRID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchHRID", intSelectedID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read() == true)
                        {
                            lblHRID.Text = reader["HRID"].ToString();
                            cboxJobTitle.Text = reader["JobTitle"].ToString();
                            txtEployeeName.Text = reader["EmployeeName"].ToString();
                            txtIDCardnumber.Text = reader["IDCardNumber"].ToString();
                            dtpEmployeeBirth.Value = Convert.ToDateTime(reader["EmployeeBirth"]);
                            txtEmployeePhone.Text = reader["EmployeePhone"].ToString();
                            txtEmployeeSalary.Text = reader["EmployeeSalary"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("查無此人");

                            ClearField();
                        }
                        reader.Close();
                        con.Close();
                    }
                }
            }

        void ClearField()
        {
            cboxJobTitle.Text = "";
            txtEployeeName.Clear();
            txtIDCardnumber.Clear();
            dtpEmployeeBirth.Value = new DateTime(1990, 1, 1, 0, 0, 0);
            txtEmployeePhone.Clear();
            txtEmployeeSalary.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    }
