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
    public partial class After_cash_login : Form
    {

        public After_cash_login()
        {
            InitializeComponent();
        }

        public void openLogin_Page(object obj)
        {
            Application.Run(new Login_Page());
        }

        public void openBill_Form(object obj)
        {
            Application.Run(new Bill_Form());
        }

        public void openReservation_Form(object obj)
        {
            Application.Run(new Reservation_Form());
        }
        private void bt_back_login_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openLogin_Page);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openBill_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void After_cash_login_Load(object sender, EventArgs e)
        {

        }

        private void bt_resv_form_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openReservation_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
    }
}
