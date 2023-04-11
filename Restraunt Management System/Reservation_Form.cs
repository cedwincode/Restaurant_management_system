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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restraunt_Management_System
{
    public partial class Reservation_Form : Form
    {
        //bryan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\source\repos\Restaurant_management_system\Restraunt Management System\Dala.mdf"";Integrated Security=True");

        //bryan 2
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\Desktop\nata\Restraunt Management System\Dala.mdf"";Integrated Security=True");

        //cedwin
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programming\web programming\restaurant management system\Restraunt Management System\Dala.mdf"";Integrated Security=True;Connect Timeout=30");

        public Reservation_Form()
        {
            InitializeComponent();
        }

        public void openReservation(object obj)
        {
            Application.Run(new Reservation());
        }
        public void openAfter_cash_loginrv(object obj)
        {
            Application.Run(new After_cash_login());
        }


        public void clear()  //clear function
        {
            tb_name.Text = "";
            tb_pno.Text = "";
            tb_tno.Text = "";
            cb_nseat.Text = "";
            dtp.Value = DateTime.Now;
            cb_hr.Text = "";
            cb_min.Text = "";
            cbt.Text = "";
        }


        private void bt_back_cash_Click(object sender, EventArgs e)  //clear all text
        {
            Thread th = new Thread(openAfter_cash_loginrv);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)  //Adds reservation
        {
            String rname, rdate, rtime;
            int hr;
            int  tno, sno;
            long pno;
            
            
            //Reservation name validation below
            if(tb_name.Text == "")
            {
                MessageBox.Show("Invalid! name cant be empty");
                return;
            }

            //Reservation phone number validation below
            if(tb_pno.Text == "")
            {
                MessageBox.Show("Phone number can't be empty");
                return;
            }
            if (tb_pno.Text.Length != 10)
            {
                MessageBox.Show("Invalid Phone no! must have 10 digit");
                return;
            }

            
            if((Convert.ToInt32(tb_pno.Text.Substring(0,1)) != 9) && (Convert.ToInt32(tb_pno.Text.Substring(0, 1)) != 8) && (Convert.ToInt32(tb_pno.Text.Substring(0, 1)) != 7) && (Convert.ToInt32(tb_pno.Text.Substring(0, 1)) != 6))
            {
                MessageBox.Show("Invalid phone number start with 9,8,7 or 6");
                return;
            }

            //Reservation table number validation below
            if(tb_tno.Text =="")
            {
                MessageBox.Show("Table number can't be empty");
                return;
            }

            if (Convert.ToInt32(tb_tno.Text) > 50)
            {
                MessageBox.Show("Tables are only upto 50 choose valid table");
                return;
            }

            //Reservation Seat number validation below
            if(cb_nseat.Text ==  "")
            {
                MessageBox.Show("Seat numbers can't be empty");
                return;
            }

            //Reservation cbt  validation below
            if((cb_hr.Text =="") || (cb_min.Text == "")  || (cbt.Text == ""))
            {
                MessageBox.Show("All 3 Hour, Mins and PM or AM are mandatory to enter");
                return;
            }

            //Reservation date validation below
            //AM AND PM time conversion

            String retrievecb_hr = cb_hr.Text;
            if (cbt.Text == "PM")
            {
                hr = 12;
                if (cb_hr.Text == "12")
                {
                    rtime = "12" + ":" + cb_min.Text + ":" + "00";  
                }
                else
                {
                    hr = hr + Convert.ToInt32(cb_hr.Text);
                    rtime = hr.ToString() + ":" + cb_min.Text + ":" + "00";

                    cb_hr.Text = hr.ToString();
                }
            }
            else
            {
                if (cb_hr.Text == "12")
                {
                    rtime = "00" + ":" + cb_min.Text + ":" + "00";
                    cb_hr.Text = "00";
                }
                else
                {
                    rtime = cb_hr.Text + ":" + cb_min.Text + ":" + "00";
                }
            }
            
            //Validation for to check if reservation time is not before today time
            TimeOnly  timecheck = new TimeOnly(Convert.ToInt32(cb_hr.Text),Convert.ToInt32(cb_min.Text),0);  // storing user reservation time

            if(dtp.Value.Date < DateTime.Now.Date)
            {
                cb_hr.Text = retrievecb_hr;
                MessageBox.Show("Reservation can't be done on a previous date");
                return;
            }

            if((dtp.Value.Date == DateTime.Now.Date) && (timecheck.ToTimeSpan() <= DateTime.Now.TimeOfDay))
            {
                cb_hr.Text = retrievecb_hr;
                MessageBox.Show("Invalid Time! Give future time");
                return;
            }

            //if validation are passed finally storing

            rname = tb_name.Text;
            pno =  Convert.ToInt64(tb_pno.Text);
            tno = Convert.ToInt32(tb_tno.Text);
            sno = Convert.ToInt32(cb_nseat.Text);
            rdate = dtp.Value.ToString("yyyy-MM-dd");



            // checking if Already a reservation is there
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM [Reserv] WHERE rdate ='" + rdate + "'  AND rtime = '" + rtime + "' AND tableno = '"+tno+"'", con);
            int k = Convert.ToInt32(cmd1.ExecuteScalar());
            if(k==1)
            {
                con.Close();
                MessageBox.Show("There is already a reservation on this date and time and table number");
                return;
            }
            con.Close();


            //Data being inserted
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Reserv] (rname,pno,tableno,seatno,rdate,rtime) VALUES('"+rname+"','"+pno+"','"+tno+"','"+sno+"','"+rdate+"','"+rtime+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            clear();
            MessageBox.Show("Reservation did Successfuly");
        }


        private void bt_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                
                int spaceCount = tb_name.Text.Count(c => c == ' ');

                if (spaceCount >= 2)
                {
                    e.Handled = true;
                }
            }

            if ((tb_name.Text.Length == 0 && e.KeyChar == ' ') ||(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {  
                if (tb_name.Text.Length >25)
                {
                    tb_name.Text = tb_name.Text.Substring(0, 25);
                    tb_name.SelectionStart = tb_name.Text.Length;
                    tb_name.SelectionLength = 0;
                }
                
            }
        }

        private void tb_pno_TextChanged(object sender, EventArgs e)
        {
            if (tb_pno.Text.Length > 10)
            {
                tb_pno.Text = tb_pno.Text.Substring(0, 10);
                tb_pno.SelectionStart = tb_pno.Text.Length;
                tb_pno.SelectionLength = 0;
            }
        }

        private void tb_pno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_tno_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((tb_tno.Text.Length == 0 && e.KeyChar== '0')||(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cb_nseat_KeyPress(object sender, KeyPressEventArgs e)
        { 
                e.Handled = true;
        }

        private void cb_hr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_tno_TextChanged(object sender, EventArgs e)
        {
            if(tb_tno.Text.Length >2)
            {
                tb_tno.Text = tb_tno.Text.Substring(0, 2);
                tb_tno.SelectionStart = tb_tno.Text.Length;
                tb_tno.SelectionLength = 0;
            }
        }

        private void dtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderColor = Color.Green;
            button1.BackColor = Color.LightGreen;
            button1.ForeColor = Color.Black;
        }

 

        private void bt_clear_MouseEnter(object sender, EventArgs e)
        {
            bt_clear.FlatAppearance.BorderColor = Color.WhiteSmoke;
            bt_clear.BackColor = Color.Red;
            bt_clear.ForeColor = Color.White;
        }

        private void bt_clear_MouseLeave(object sender, EventArgs e)
        {
            bt_clear.FlatAppearance.BorderColor = Color.Maroon;
            bt_clear.BackColor = Color.DarkRed;
            bt_clear.ForeColor = Color.Black;
        }

        private void bt_show_resev_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openReservation);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void bt_show_resev_MouseEnter(object sender, EventArgs e)
        {
            bt_show_resev.FlatAppearance.BorderColor = Color.Black;
            bt_show_resev.BackColor = Color.Lime;
            bt_show_resev.ForeColor = Color.Black;
        }

        private void bt_show_resev_MouseLeave(object sender, EventArgs e)
        {
            bt_show_resev.FlatAppearance.BorderColor = Color.WhiteSmoke;
            bt_show_resev.BackColor = Color.Black;
            bt_show_resev.ForeColor = Color.Lime;
        }
    }
}
