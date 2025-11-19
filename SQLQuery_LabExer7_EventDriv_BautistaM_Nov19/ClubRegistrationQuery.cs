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

        ClubRegistrationQuery()
        {
            //6.a
            connectionString = "Data Source=LAB-A-PC00;Initial Catalog=ClubDB_BautistaM;User ID=bautista.m;Password=12345;TrustServerCertificate=True";
            //6.b
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
            
        }
    }
}
+
