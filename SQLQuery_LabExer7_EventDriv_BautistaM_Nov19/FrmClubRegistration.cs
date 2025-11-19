using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLQuery_LabExer7_EventDriv_BautistaM_Nov19
{
    public partial class FrmClubRegistration : Form
    {
        //9
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
        private int ID, Age, count;
        private String FirstName, MiddleName, LastName, Gender, Program;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.RegisterStudent(count, Convert.ToInt64(txtStudID.Text),txtFN.Text, txtMN.Text, txtLN.Text, Convert.ToInt32(txtAge.Text), cboxGender.Text, cboxProgram.Text);
            //(int ID,long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (frmUpdateMember.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private long StudentId;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dgvTable.DataSource = clubRegistrationQuery.bindingSource;
        }

        int RegistrationID()
        {
            count++;
            return count;
        }
    }
}
