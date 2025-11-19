using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLQuery_LabExer7_EventDriv_BautistaM_Nov19
{
    internal class ClubUpdateQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;
        public BindingSource bindingSource;
        private string connectionString;


        public ClubUpdateQuery()
        {
            //6.a
            connectionString = "Data Source=LAB-A-PC00;Initial Catalog=ClubDB_BautistaM2;User ID=bautista.m;Password=12345;TrustServerCertificate=True";
            //6.b
            sqlConnect = new SqlConnection(connectionString);
            //6.c
        }
        public void GetStudentID(ComboBox cbox)
        {
            sqlCommand = new SqlCommand("SELECT StudentID FROM ClubMembers", sqlConnect);
            sqlConnect.Open();
            using (var reader = sqlCommand.ExecuteReader())
            {
                int i = 0;
                while (reader.Read())
                {
                    cbox.Items.Add(reader[i].ToString());
                    i++;
                }
            }

            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }


    }
}
