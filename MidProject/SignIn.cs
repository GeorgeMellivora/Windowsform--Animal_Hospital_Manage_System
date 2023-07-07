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
    public partial class SignIn : Form
    {
        bool SignCertified = false;

        SqlConnectionStringBuilder scsb;
        string strDBConnectString = "";
        List<int> SearchPetID = new List<int>();

        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidProject";
            scsb.IntegratedSecurity = true;
            strDBConnectString = scsb.ToString();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if((txtID.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "select * from SignData where ID = @SearchID and Password = @SearchPassword";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", txtID.Text);
                cmd.Parameters.AddWithValue("@SearchPassword", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    GlobalVar.EmployeeIDCardNumberVar = reader["IDCardNumber"].ToString();
                    SignCertified = true;
                    MessageBox.Show("登入成功");
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤，請確認");
                }
                
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }
            //Close();

            SqlConnection con1 = new SqlConnection(strDBConnectString);
            con1.Open();
            string strSQL1 = "select * from HRData where IDCardNumber = @SearchIDCardNumber";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            cmd1.Parameters.AddWithValue("@SearchIDCardNumber", GlobalVar.EmployeeIDCardNumberVar);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                GlobalVar.EmployeeNameVar = reader1["EmployeeName"].ToString();
                GlobalVar.EmployeeJobTitleVar = reader1["JobTitle"].ToString();                
            }
            reader1.Close();
            con1.Close();

            Close();
        }
        
        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(SignCertified)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
