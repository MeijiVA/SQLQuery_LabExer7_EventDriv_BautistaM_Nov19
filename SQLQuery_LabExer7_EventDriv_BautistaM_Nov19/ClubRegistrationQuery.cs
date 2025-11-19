using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLQuery_LabExer7_EventDriv_BautistaM_Nov19
{
    internal class ClubRegistrationQuery
    {
        /*"Data Source=LAB-A-PC00;Initial Catalog=ClubDB_BautistaM;User ID=bautista.m;Password=12345;TrustServerCertificate=True"*/
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName,
            _MiddleName, 
            _LastName,
            _Gender,
            _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            //6.a
            connectionString = "Data Source=LAB-A-PC00;Initial Catalog=ClubDB_BautistaM2;User ID=bautista.m;Password=12345;TrustServerCertificate=True";
            //6.b
            sqlConnect = new SqlConnection(connectionString);
            //6.c
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            //7.a
            String ViewClubMembers = "SELECT StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
           //7.b
            sqlAdapter = new SqlDataAdapter(ViewClubMembers,sqlConnect);
            //7.c
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            return true;
        }

        public bool RegisterStudent(int ID,long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, " +
                "@Gender, @Program)",sqlConnect);
            sqlCommand.Parameters.Add("@ID",SqlDbType.Int).Value = ID;
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
