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
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private String FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;
        public FrmClubRegistration()
        {
            InitializeComponent();
        }
    }
}
