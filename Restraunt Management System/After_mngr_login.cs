using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restraunt_Management_System
{
    public partial class After_mngr_login : Form
    {
        
        public After_mngr_login()
        {
            InitializeComponent();
        }

        public void openLogin_Page(object obj)
        {
            Application.Run(new Login_Page());
        }

        public void openRevenue_Form(object obj)
        {
            Application.Run(new Revenue_Form());
        }

        private void bt_back_login_Click(object sender, EventArgs e)
        {
            
            Thread th = new Thread(openLogin_Page);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
            

        }

        private void bt_bill_form_Click(object sender, EventArgs e)
        {
            
            Thread th = new Thread(openRevenue_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
            
        }
    }
}
