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
    public partial class Appointment : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchPetID = new List<int>();

        public Appointment()
        {
            InitializeComponent();
        }





        private void Appointment_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidProject";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            GenerateAppointMentData();

            cboxDoctor.Items.Add("楊志青");
            cboxDoctor.Items.Add("李承恩");
            cboxDoctor.Items.Add("陳志甫");
            cboxDoctor.Items.Add("黃政仲");

            cboxSearch.Items.Add("日期");
            cboxSearch.Items.Add("身份證號");
            cboxSearch.Items.Add("綜合查詢");
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {            
            if ((txtBreederNumber.Text != "") && (txtPetName.Text != "") && (cboxDoctor.Text != "") && (txtSituation.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into AppointmentData values (@NewBreederNumber, @NewPetName, @NewDoctor, @NewAppointmentDate, @NewSituation, @NewDiagnosticStatus, @NewDiagnosticResult, @NewDiagnosticCharge);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", txtBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewPetName", txtPetName.Text);
                cmd.Parameters.AddWithValue("NewDoctor", cboxDoctor.Text);
                cmd.Parameters.AddWithValue("NewAppointmentDate", dtpAppointmentDate.Value);
                cmd.Parameters.AddWithValue("NewSituation", txtSituation.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticStatus", lblNull.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticResult", lblNull.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticCharge", lblNull.Text);                

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"已新增({rows}筆資料)");
                GenerateAppointMentData();
            }
            else
            {
                ClearField();
                MessageBox.Show("請將欄位完整填寫，缺一不可");
            }

        }





        private void btnModify_Click(object sender, EventArgs e)
        {
            int intAppointmentID = 0;
            Int32.TryParse(lblAppointmentID.Text, out intAppointmentID);

            if ((intAppointmentID > 0) && (txtBreederNumber.Text != "") && (txtPetName.Text != "") && (cboxDoctor.Text != "") && (txtSituation.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update AppointmentData set BreederNumber=@NewBreederNumber, PetName=@NewPetName, Doctor=@NewDoctor, AppointmentDate=@NewAppointmentDate, Situation=@NewSituation, DiagnosticStatus=@NewDiagnosticStatus, DiagnosticResult=@NewDiagnosticResult, DiagnosticCharge=@NewDiagnosticCharge where AppointmentID = @SearchAppointmentID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", txtBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewPetName", txtPetName.Text);
                cmd.Parameters.AddWithValue("NewDoctor", cboxDoctor.Text);
                cmd.Parameters.AddWithValue("NewAppointmentDate", dtpAppointmentDate.Value);
                cmd.Parameters.AddWithValue("NewSituation", txtSituation.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticStatus", lblNull.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticResult", lblNull.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticCharge", lblNull.Text);
                cmd.Parameters.AddWithValue("SearchAppointmentID", intAppointmentID);

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"已修改({rows}筆資料)");
                //Console.WriteLine(dtpAppointmentDate.Value);
                con.Close();

                string strSelectedID = lblAppointmentID.Text.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);
                SqlConnection concc = new SqlConnection(strDBConnectString);
                concc.Open();
                string strSQLcc = "select AppointmentID, BreederNumber, PetName, Doctor, AppointmentDate, Situation from AppointmentData where AppointmentID = @SearchAppointmentID;";
                SqlCommand cmdcc = new SqlCommand(strSQLcc, concc);
                cmdcc.Parameters.AddWithValue("@SearchAppointmentID", intSelectedID);
                SqlDataReader reader = cmdcc.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvAppointmentData.DataSource = dt;
                }
                reader.Close();
                concc.Close();
                lblAppointmentID.Text = "";

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
            Int32.TryParse(lblAppointmentID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "delete from AppointmentData where AppointmentID = @DeleteID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"(已刪除{rows}筆資料)");
                GenerateAppointMentData();
            }
            else
            {
                MessageBox.Show("請雙擊點選右方欲刪除的資料");
            }
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateAppointMentData();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cboxSearch.Text != "")
            {
                if (cboxSearch.Text == "日期")
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select AppointmentID, BreederNumber, PetName, Doctor, AppointmentDate, Situation from AppointmentData where CONVERT(char(8), AppointmentDate, 112) = @SearchAppointmentDate;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchAppointmentDate", dtpSearch.Value);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvAppointmentData.DataSource = dt;
                        lblAppointmentID.Text = "";
                    }
                    else
                    {
                        lblAppointmentID.Text = "";
                        MessageBox.Show("找不到資料");
                    }
                    reader.Close();
                    con.Close();
                }
                if (cboxSearch.Text == "身份證號")
                {
                    if (txtSearch.Text != "")
                    {
                        SqlConnection con = new SqlConnection(strDBConnectString);
                        con.Open();
                        string strSQL = "select AppointmentID, BreederNumber, PetName, Doctor, AppointmentDate, Situation from AppointmentData where BreederNumber = @SearchBreederNumber;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchBreederNumber", txtSearch.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvAppointmentData.DataSource = dt;
                            lblAppointmentID.Text = "";
                        }
                        else
                        {
                            lblAppointmentID.Text = "";
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
                if (cboxSearch.Text == "綜合查詢")
                {
                    if(txtSearch.Text != "")
                    {
                        SqlConnection con = new SqlConnection(strDBConnectString);
                        con.Open();
                        string strSQL = "select AppointmentID, BreederNumber, PetName, Doctor, AppointmentDate, Situation from AppointmentData where CONVERT(char(8), AppointmentDate, 112) = @SearchAppointmentDate and BreederNumber = @SearchBreederNumber;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchAppointmentDate", dtpSearch.Value);
                        cmd.Parameters.AddWithValue("@SearchBreederNumber", txtSearch.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvAppointmentData.DataSource = dt;
                            lblAppointmentID.Text = "";
                        }
                        else
                        {
                            lblAppointmentID.Text = "";
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
                MessageBox.Show("請先選擇查尋模式");
            }
        }





        private void dgvAppointmentData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgvAppointmentData.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select * from AppointmentData where AppointmentID = @SearchAppointmentID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchAppointmentID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblAppointmentID.Text = reader["AppointmentID"].ToString();
                        txtBreederNumber.Text = reader["BreederNumber"].ToString();
                        txtPetName.Text = reader["PetName"].ToString();                        
                        cboxDoctor.Text = reader["Doctor"].ToString();
                        dtpAppointmentDate.Value = Convert.ToDateTime(reader["AppointmentDate"]);
                        txtSituation.Text = reader["Situation"].ToString();
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




        void GenerateAppointMentData()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select AppointmentID, BreederNumber, PetName, Doctor, AppointmentDate, Situation from AppointmentData";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvAppointmentData.DataSource = dt;
            }
            reader.Close();
            con.Close();

            lblAppointmentID.Text = "";
        }





        void ClearField()
        {
            txtBreederNumber.Clear();
            txtPetName.Clear();
            cboxDoctor.Text = "";
            dtpAppointmentDate.Text = DateTime.Now.ToLocalTime().ToString();
            txtSituation.Clear();
            lblAppointmentID.Text = "";
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
