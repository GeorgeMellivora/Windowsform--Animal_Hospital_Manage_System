using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject
{
    public partial class PetHospital : Form
    {
        public PetHospital()
        {
            InitializeComponent();
        }

        private void PetHospital_Load(object sender, EventArgs e)
        {
            SignIn NewSignIn = new SignIn();
            NewSignIn.ShowDialog();

            form_test1 = new Appointment();
            form_test2 = new DiagnoseResult();
            InitialMainArea(form_test1);
            InitialMainArea(form_test2);

            
            lblEmployeeName.Text = GlobalVar.EmployeeNameVar;
            lblEmployeeJobTitile.Text = GlobalVar.EmployeeJobTitleVar;

            if(lblEmployeeJobTitile.Text == "助理")
            {
                btnHumanResourceDataMaintenance.Visible = false;
                btnPetApplianceInformationMaintenance.Visible = false;
                btnPetDataMaintenance.Visible = false;
                btnBreederDataMaintenance.Visible = false;
                linkLabelDiagnose.Visible = false;
            }
            else if(lblEmployeeJobTitile.Text == "醫師")
            {
                btnHumanResourceDataMaintenance.Visible = false;
                linkLabelAppointment.Visible = false;
            }
            else
            {
                MessageBox.Show("老闆好，祝您有美好的一天!");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form form_ActiveMainArea = null;
        private Appointment form_test1  = null;
        private DiagnoseResult form_test2 = null;

        private void OpenFormAtMainArea(Form from_OpenForm)
        {
            form_ActiveMainArea = from_OpenForm;
            panel_MainArea.Tag = from_OpenForm;
           from_OpenForm.BringToFront();
            from_OpenForm.Show();
        }

        private void InitialMainArea(Form form)
        {
            form.TopLevel = false ;
            panel_MainArea.Controls.Add(form);
            form.Dock= DockStyle.Fill;
        }

        private void linkLabelAppointment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormAtMainArea(form_test1);
        }

        private void linkLabelDiagnose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFormAtMainArea(form_test2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPetApplianceOrdersInformance_Click(object sender, EventArgs e)
        {
            PetApplianceOrdersInformation new_Order = new PetApplianceOrdersInformation();
            new_Order.ShowDialog();
        }

        private void btnBreederDataMaintenance_Click(object sender, EventArgs e)
        {
            BreederDataMaintenance new_BreeferData = new BreederDataMaintenance();
            new_BreeferData.ShowDialog();
        }

        private void btnPetDataMaintenance_Click(object sender, EventArgs e)
        {
            PetDataMaintance new_PetData = new PetDataMaintance();
            new_PetData.ShowDialog();
        }

        private void btnPetApplianceInformationMaintenance_Click(object sender, EventArgs e)
        {
            PetApplianceInformationMaintenance new_OrderMainten = new PetApplianceInformationMaintenance();
            new_OrderMainten.ShowDialog();
        }

        private void btnHumanResourceDataMaintenance_Click(object sender, EventArgs e)
        {
            HumanResourceDataMaintenance new_HRData = new HumanResourceDataMaintenance();
            new_HRData.ShowDialog();
        }

        private void btnManagerInformation_Click(object sender, EventArgs e)
        {
            ManagerInformation new_ManagerInformation = new ManagerInformation();
            new_ManagerInformation.ShowDialog();
        }
    }
}
