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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SQLQuery_LabExer7_EventDriv_BautistaM_Nov19
{
    public partial class FrmUpdateMember : Form
    {
        ClubUpdateQuery clubUpdateQuery = new ClubUpdateQuery();

        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;
        public BindingSource bindingSource;
        private string connectionString;


        public FrmUpdateMember()
        {
            InitializeComponent();
            //6.a
            connectionString = "Data Source=LAB-A-PC00;Initial Catalog=ClubDB_BautistaM2;User ID=bautista.m;Password=12345;TrustServerCertificate=True";
            //6.b
            sqlConnect = new SqlConnection(connectionString);
            //6.c
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            clubUpdateQuery.GetStudentID(cboxStudentID);
        }

        private void cboxStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program
            sqlCommand = new SqlCommand($"SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentID = {cboxStudentID}", sqlConnect);
            sqlConnect.Open();
            using (var reader = sqlCommand.ExecuteReader())
            {
                txtFN.Text = reader[0].ToString();
                txtMN.Text = reader[1].ToString();
                txtLN.Text = reader[2].ToString();
                txtAge.Text = reader[3].ToString();
                cboxGender.Text = reader[4].ToString();
                cboxProgram.Text = reader[5].ToString();
            }

            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UpdateStudent(Convert.ToInt64(cboxStudentID.Text), txtFN.Text, txtMN.Text, txtLN.Text, Convert.ToInt32(txtAge.Text), cboxGender.Text, cboxProgram.Text);
            this.Close();
        }

        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {

            sqlCommand = new SqlCommand($"UPDATE ClubMembers SET ID = @ID, StudentID = @StudentID,FirstName = @FirstName, MiddleName = @MiddleName,LastName =  @LastName,Age = @Age, Gender = @Gender,Program =  @Program) WHERE StudentID = {cboxStudentID}", sqlConnect);
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            return true;
        }
    }
}
