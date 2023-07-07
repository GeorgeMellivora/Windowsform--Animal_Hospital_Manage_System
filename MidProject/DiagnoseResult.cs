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
    public partial class DiagnoseResult : Form
    {

        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchPetID = new List<int>();

        public DiagnoseResult()
        {
            InitializeComponent();
        }





        private void DiagnoseResult_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidProject";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();

            GenerateDiagnoseData();

            cboxDoctor.Items.Add("楊志青");
            cboxDoctor.Items.Add("李承恩");
            cboxDoctor.Items.Add("陳志甫");
            cboxDoctor.Items.Add("黃政仲");

            cboxDiagnosticStatus.Items.Add("完成");
            cboxDiagnosticStatus.Items.Add("未完成");

            cboxSearch.Items.Add("日期");
            cboxSearch.Items.Add("身份證號");
            cboxSearch.Items.Add("綜合查詢");

        }

        void GenerateDiagnoseData()
        {
            SqlConnection con = new SqlConnection(strDBConnectString);
            con.Open();
            string strSQL = "select AppointmentData.AppointmentID, AppointmentData.BreederNumber, BreederData.BreederName, AppointmentData.PetName, AppointmentData.Situation, AppointmentData.Doctor, AppointmentData.DiagnosticStatus, AppointmentData.DiagnosticResult, AppointmentData.DiagnosticCharge from AppointmentData inner join BreederData on AppointmentData.BreederNumber=BreederData.BreederNumber;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvDiagnoseData.DataSource = dt;
            }
            reader.Close();
            con.Close();

            lblAppointmentID.Text = "";
            lblBreederName.Text = "";
            lblPetName.Text = "";
        }





        private void btnModify_Click(object sender, EventArgs e)
        {
            int intAppointmentID = 0;
            Int32.TryParse(lblAppointmentID.Text, out intAppointmentID);

            if ((intAppointmentID > 0) && (lblBreederName.Text != "") && (lblPetName.Text != "") && (cboxDoctor.Text != "") && (txtSituation.Text != "") && (cboxDiagnosticStatus.Text != "") && (txtDiagnosticCharge.Text != "") && (txtDiagnosticResult.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update AppointmentData set BreederNumber=@NewBreederNumber, PetName=@NewPetName, Doctor=@NewDoctor, AppointmentDate=@NewAppointmentDate, Situation=@NewSituation, DiagnosticStatus=@NewDiagnosticStatus, DiagnosticResult=@NewDiagnosticResult, DiagnosticCharge=@NewDiagnosticCharge where AppointmentID = @SearchAppointmentID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", lblBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewPetName", lblPetName.Text);
                cmd.Parameters.AddWithValue("NewDoctor", cboxDoctor.Text);
                cmd.Parameters.AddWithValue("NewAppointmentDate", dtpAppointmentDate.Value);
                cmd.Parameters.AddWithValue("NewSituation", txtSituation.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticStatus", cboxDiagnosticStatus.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticResult", txtDiagnosticResult.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticCharge", txtDiagnosticCharge.Text);
                cmd.Parameters.AddWithValue("SearchAppointmentID", intAppointmentID);

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"已刪除({rows}筆診斷資料)");
                //Console.WriteLine(dtpAppointmentDate.Value);
                con.Close();

                string strSelectedID = lblAppointmentID.Text.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);
                SqlConnection concc = new SqlConnection(strDBConnectString);
                concc.Open();
                string strSQLcc = "select AppointmentData.AppointmentID, AppointmentData.BreederNumber, BreederData.BreederName, AppointmentData.PetName, AppointmentData.Situation, AppointmentData.Doctor, AppointmentData.DiagnosticStatus, AppointmentData.DiagnosticResult, AppointmentData.DiagnosticCharge from AppointmentData inner join BreederData on AppointmentData.BreederNumber=BreederData.BreederNumber where AppointmentID = @SearchAppointmentID;";
                SqlCommand cmdcc = new SqlCommand(strSQLcc, concc);
                cmdcc.Parameters.AddWithValue("@SearchAppointmentID", intSelectedID);
                SqlDataReader reader = cmdcc.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvDiagnoseData.DataSource = dt;
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
            int intDeleteID = 0;
            Int32.TryParse(lblAppointmentID.Text, out intDeleteID);

            if ((intDeleteID > 0) && (lblBreederName.Text != "") && (lblPetName.Text != "") && (cboxDoctor.Text != "") && (txtSituation.Text != "") && (cboxDiagnosticStatus.Text != "") && (txtDiagnosticCharge.Text != "") && (txtDiagnosticResult.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "update AppointmentData set BreederNumber=@NewBreederNumber, PetName=@NewPetName, Doctor=@NewDoctor, AppointmentDate=@NewAppointmentDate, Situation=@NewSituation, DiagnosticStatus=@NewDiagnosticStatus, DiagnosticResult=@NewDiagnosticResult, DiagnosticCharge=@NewDiagnosticCharge where AppointmentID = @SearchAppointmentID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewBreederNumber", lblBreederNumber.Text);
                cmd.Parameters.AddWithValue("NewPetName", lblPetName.Text);
                cmd.Parameters.AddWithValue("NewDoctor", cboxDoctor.Text);
                cmd.Parameters.AddWithValue("NewAppointmentDate", dtpAppointmentDate.Value);
                cmd.Parameters.AddWithValue("NewSituation", txtSituation.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticStatus", lblNull.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticResult", lblNull.Text);
                cmd.Parameters.AddWithValue("NewDiagnosticCharge", lblNull.Text);
                cmd.Parameters.AddWithValue("SearchAppointmentID", intDeleteID);

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"已刪除({rows}筆診斷資料)");
                //Console.WriteLine(dtpAppointmentDate.Value);
                con.Close();

                string strSelectedID = lblAppointmentID.Text.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);
                SqlConnection concc = new SqlConnection(strDBConnectString);
                concc.Open();
                string strSQLcc = "select AppointmentData.AppointmentID, AppointmentData.BreederNumber, BreederData.BreederName, AppointmentData.PetName, AppointmentData.Situation, AppointmentData.Doctor, AppointmentData.DiagnosticStatus, AppointmentData.DiagnosticResult, AppointmentData.DiagnosticCharge from AppointmentData inner join BreederData on AppointmentData.BreederNumber=BreederData.BreederNumber where AppointmentID = @SearchAppointmentID;";
                SqlCommand cmdcc = new SqlCommand(strSQLcc, concc);
                cmdcc.Parameters.AddWithValue("@SearchAppointmentID", intSelectedID);
                SqlDataReader reader = cmdcc.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvDiagnoseData.DataSource = dt;
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





        void ClearField()
        {
            lblBreederName.Text = "";
            lblPetName.Text = "";
            cboxDoctor.Text = "";
            cboxDiagnosticStatus.Text = "";
            txtDiagnosticResult.Text = "";
            txtDiagnosticCharge.Text = "";
            dtpSearch.Text = DateTime.Now.ToLocalTime().ToString();
            txtSearch.Clear();
            cboxSearch.Text = "";

            lblAppointmentID.Text = "";
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateDiagnoseData();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboxSearch.Text != "")
            {
                if (cboxSearch.Text == "日期")
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select AppointmentData.AppointmentID, AppointmentData.BreederNumber, BreederData.BreederName, AppointmentData.PetName, AppointmentData.Situation, AppointmentData.Doctor, AppointmentData.AppointmentDate, AppointmentData.DiagnosticStatus, AppointmentData.DiagnosticResult, AppointmentData.DiagnosticCharge from AppointmentData inner join BreederData on AppointmentData.BreederNumber=BreederData.BreederNumber where CONVERT(char(8), AppointmentDate, 112) = @SearchAppointmentDate;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchAppointmentDate", dtpSearch.Value);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvDiagnoseData.DataSource = dt;
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
                        string strSQL = "select AppointmentData.AppointmentID, AppointmentData.BreederNumber, BreederData.BreederName, AppointmentData.PetName, AppointmentData.Situation, AppointmentData.Doctor, AppointmentData.AppointmentDate, AppointmentData.DiagnosticStatus, AppointmentData.DiagnosticResult, AppointmentData.DiagnosticCharge from AppointmentData inner join BreederData on AppointmentData.BreederNumber=BreederData.BreederNumber  where AppointmentData.BreederNumber = @SearchBreederNumber;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchBreederNumber", txtSearch.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvDiagnoseData.DataSource = dt;
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
                    if (txtSearch.Text != "")
                    {
                        SqlConnection con = new SqlConnection(strDBConnectString);
                        con.Open();
                        string strSQL = "select AppointmentData.AppointmentID, AppointmentData.BreederNumber, BreederData.BreederName, AppointmentData.PetName, AppointmentData.Situation, AppointmentData.Doctor, AppointmentData.AppointmentDate, AppointmentData.DiagnosticStatus, AppointmentData.DiagnosticResult, AppointmentData.DiagnosticCharge from AppointmentData inner join BreederData on AppointmentData.BreederNumber=BreederData.BreederNumber  where CONVERT(char(8), AppointmentDate, 112) = @SearchAppointmentDate and AppointmentData.BreederNumber = @SearchBreederNumber;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchAppointmentDate", dtpSearch.Value);
                        cmd.Parameters.AddWithValue("@SearchBreederNumber", txtSearch.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvDiagnoseData.DataSource = dt;
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





        private void dgvDiagnoseData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgvDiagnoseData.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strDBConnectString);
                    con.Open();
                    string strSQL = "select AppointmentData.AppointmentID, AppointmentData.BreederNumber, BreederData.BreederName, AppointmentData.PetName, AppointmentData.Situation,  AppointmentData.Doctor, AppointmentData.AppointmentDate, AppointmentData.DiagnosticStatus, AppointmentData.DiagnosticResult, AppointmentData.DiagnosticCharge from AppointmentData inner join BreederData on AppointmentData.BreederNumber=BreederData.BreederNumber where AppointmentID = @SearchAppointmentID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchAppointmentID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblAppointmentID.Text = reader["AppointmentID"].ToString();
                        lblBreederName.Text = reader["BreederName"].ToString();
                        lblPetName.Text = reader["PetName"].ToString();
                        txtSituation.Text = reader["Situation"].ToString();
                        cboxDoctor.Text = reader["Doctor"].ToString();
                        cboxDiagnosticStatus.Text = reader["DiagnosticStatus"].ToString();
                        txtDiagnosticResult.Text = reader["DiagnosticResult"].ToString();
                        txtDiagnosticCharge.Text = reader["DiagnosticCharge"].ToString();
                        lblBreederNumber.Text = reader["BreederNumber"].ToString();
                        dtpAppointmentDate.Value = Convert.ToDateTime(reader["AppointmentDate"]);
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
    }
}
