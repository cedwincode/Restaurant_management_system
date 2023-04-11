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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Restraunt_Management_System
{
    public partial class Reservation : Form
    {
        //bryan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\source\repos\Restaurant_management_system\Restraunt Management System\Dala.mdf"";Integrated Security=True");
        
        //bryan 2
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\Desktop\nata\Restraunt Management System\Dala.mdf"";Integrated Security=True");

        //cedwin
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programming\web programming\restaurant management system\Restraunt Management System\Dala.mdf"";Integrated Security=True;Connect Timeout=30");
        public Reservation()
        {
            InitializeComponent();
            show_res();
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

        public void show_res()  //SHOW TODAY AND FUTURE RESERVATION
        {
            dtp.Value = DateTime.Now;
            tb_r_id.Text = "";

            DateTime todaytime = DateTime.Now;
            TimeSpan timenow = todaytime.TimeOfDay;
            String actime = timenow.ToString(@"hh\:mm\:ss");

            String today = DateTime.Now.Date.ToString("yyyy-MM-dd");
            con.Open();
            DataTable dta = new DataTable();
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT  res_id AS ID, rname AS Name,pno AS 'Mobile no',tableno AS 'Tabel no',seatno AS 'Seat no',rdate AS 'Date',rtime AS 'Time'  FROM [Reserv] WHERE rdate >  '"+today+"' OR (rdate = '"+today+"' AND  rtime > '"+actime+"') ", con);
            dtaadp.Fill(dta);
            if(dta.Rows.Count==0)
            {
                MessageBox.Show("There are no reservation");
            }
            Res_dgv.DataSource = dta;
            con.Close();
        }
        private void bt_show_all_Click(object sender, EventArgs e) //SHOWS ALL RESERVATYION
        {
            con.Open();
            DataTable dta = new DataTable();
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT  res_id AS ID, rname AS Name,pno AS 'Mobile no',tableno AS 'Tabel no',seatno AS 'Seat no',rdate AS 'Date',rtime AS 'Time'  FROM [Reserv]", con);
            dtaadp.Fill(dta);

            if (dta.Rows.Count == 0)
            {
                MessageBox.Show("There are no reservation");
            }

            Res_dgv.DataSource = dta;
            con.Close();

            tb_r_id.Text = "";
            dtp.Value = DateTime.Now;
        }

        private void bt_ch_reserv_Click(object sender, EventArgs e)
        {
            String spec_day = dtp.Value.ToString("yyyy-MM-dd");
            con.Open();
            DataTable dta = new DataTable();
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT  res_id AS ID, rname AS Name,pno AS 'Mobile no',tableno AS 'Tabel no',seatno AS 'Seat no',rdate AS 'Date',rtime AS 'Time'  FROM [Reserv] WHERE rdate = '" + spec_day + "'", con);
            dtaadp.Fill(dta);
            if(dta.Rows.Count==0)
            {
                MessageBox.Show("There are no reservation on this date");
            }
            Res_dgv.DataSource = dta;
            con.Close();
        
        }

        private void bt_cancel_Click(object sender, EventArgs e)  //TO CANCEL RESERVATION
        {
            String tdydate = DateTime.Now.Date.ToString("yyyy-MM-dd");  //storing date of today
            DateTime today = DateTime.Now;
            TimeSpan timenow = today.TimeOfDay;
            String actime = timenow.ToString(@"hh\:mm\:ss");  //storing the time of today
            

            if(tb_r_id.Text == "") //Selecting and deleting
            {
                int rowid = Res_dgv.CurrentCell.RowIndex;
                int delid =  Convert.ToInt32(Res_dgv.Rows[rowid].Cells[0].Value);


                DialogResult result = MessageBox.Show("Are you sure you want to canceL reservation with Id: " + delid + "", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result != DialogResult.OK)
                {
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Reserv] WHERE (res_id = '"+delid+"' AND rdate = '"+tdydate+"' AND rtime > '"+actime+ "')  OR (res_id = '"+delid+"' AND rdate >'"+tdydate+"')", con);
                int k = cmd.ExecuteNonQuery();
                con.Close();
                if(k> 0)
                {
                    MessageBox.Show("Cancelled reservation with Id :" + delid);
                    show_res();
                    return;

                }
                else
                {
                    MessageBox.Show("There was no reservation with Id: "+delid+ " or invalid date or time");
                    return;
                }

            }
            else //Entering manually
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Reserv] WHERE (res_id = '" +tb_r_id.Text + "' AND rdate = '"+tdydate+"' AND rtime > '"+actime+ "') OR (res_id = '" +tb_r_id.Text + "' AND rdate > '"+tdydate+"') ", con);
                int k = cmd.ExecuteNonQuery();
                con.Close();
                if (k > 0)
                {
                    MessageBox.Show("Cancelled reservation with Id:" + tb_r_id.Text);
                    show_res();
                    return;

                }
                else
                {
                    MessageBox.Show("There was no reservation with Id: " + tb_r_id.Text+ " or invalid date or time");
                    return;
                }
            }
        }

        private void bt_res_Click(object sender, EventArgs e)
        {
            show_res();
        }

        private void dtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void tb_r_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if(tb_r_id.Text.Length ==0 && e.KeyChar==' ')
            {
                e.Handled = true;
            }
            */

            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_r_id_TextChanged(object sender, EventArgs e)
        {
            if(tb_r_id.Text.Length > 9)
            {
                tb_r_id.Text = tb_r_id.Text.Substring(0, 9);
                tb_r_id.SelectionStart = tb_r_id.Text.Length;
                tb_r_id.SelectionLength = 0;
            }
        }

        private void bt_cancel_MouseEnter(object sender, EventArgs e)
        {
            bt_cancel.FlatAppearance.BorderColor = Color.White;
            bt_cancel.ForeColor = Color.White;
            bt_cancel.BackColor = Color.Red;
        }

        private void bt_cancel_MouseLeave(object sender, EventArgs e)
        {
            bt_cancel.FlatAppearance.BorderColor = Color.Maroon;
            bt_cancel.ForeColor = Color.Black;
            bt_cancel.BackColor = Color.DarkRed;
        }

        private void bt_ch_reserv_MouseEnter(object sender, EventArgs e)
        {
            bt_ch_reserv.FlatAppearance.BorderColor = Color.White;
            bt_ch_reserv.BackColor = Color.LimeGreen;
            bt_ch_reserv.ForeColor = Color.Black;
        }

        private void bt_ch_reserv_MouseLeave(object sender, EventArgs e)
        {
            bt_ch_reserv.FlatAppearance.BorderColor = Color.Black;
            bt_ch_reserv.BackColor = Color.LightGray;
            bt_ch_reserv.ForeColor = Color.Black;
        }

        private void bt_show_all_MouseEnter(object sender, EventArgs e)
        {
            bt_show_all.FlatAppearance.BorderColor = Color.White;
            bt_show_all.BackColor = Color.LimeGreen;
            bt_show_all.ForeColor = Color.Black;
        }

        private void bt_show_all_MouseLeave(object sender, EventArgs e)
        {
            bt_show_all.FlatAppearance.BorderColor = Color.Black;
            bt_show_all.BackColor = Color.LightGray;
            bt_show_all.ForeColor = Color.Black;
        }

        private void bt_res_MouseEnter(object sender, EventArgs e)
        {
            bt_res.FlatAppearance.BorderColor = Color.White;
            bt_res.BackColor = Color.LimeGreen;
            bt_res.ForeColor = Color.Black;
        }

        private void bt_res_MouseLeave(object sender, EventArgs e)
        {
            bt_res.FlatAppearance.BorderColor = Color.Black;
            bt_res.BackColor = Color.LightGray;
            bt_res.ForeColor = Color.Black;
        }

        private void Res_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in Res_dgv.Rows)
            {
                for (int i = 0; i < Res_dgv.ColumnCount; i++)
                {
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.LightGreen;
                        row.Cells[i].Style.ForeColor = Color.Black;

                    }
                }
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
 