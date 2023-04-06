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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        public void openReservation_Form(object obj)
        {
            Application.Run(new Reservation_Form());
        }
        private void bt_back_resr_form_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openReservation_Form);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
    }
}