using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restraunt_Management_System
{
    public partial class Reservation_Form : Form
    {
        public Reservation_Form()
        {
            InitializeComponent();
        }

        public void openAfter_cash_loginrv(object obj)
        {
            Application.Run(new After_cash_login());
        }



        private void bt_back_cash_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openAfter_cash_loginrv);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Form_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
