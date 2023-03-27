using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restraunt_Management_System
{
    public partial class Revenue_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\Desktop\Restaurant_management_system\Restraunt Management System\Dala.mdf"";Integrated Security=True;Connect Timeout=30");
        public Revenue_Form()
        {
            InitializeComponent();

            //setting to , from  and day_dtp calendars as checked  false
            from_dtp.Value = DateTime.Now;
            from_dtp.Checked = false;
            to_dtp.Value = DateTime.Now;
            to_dtp.Checked = false;
            day_dtp.Value = DateTime.Now;
            day_dtp.Checked = false;

            show_Rev();
        }

        public void openAfter_mngr_login(object obj)
        {
            Application.Run(new After_mngr_login());
        }
        public void show_Rev()
        {
            con.Open();
            

            //resetting everyones value
            
            from_dtp.Value = DateTime.Now;
            from_dtp.Checked = false;
            to_dtp.Value = DateTime.Now;
            to_dtp.Checked = false;
            con.Close();
            day_dtp.Value = DateTime.Now;
            day_dtp.Checked = false;

            lb_total.Text = "None";
            total.Text = "None";
            
            cb_Beg.Text = "";
            cb_End.Text = "";


            con.Open();
            DataTable dta = new DataTable();
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)'FROM [Revenue] GROUP BY date", con);
            dtaadp.Fill(dta);
            dgv_rev.DataSource = dta;

            con.Close();
        }
        private void bt_disp_Click(object sender, EventArgs e)
        {
            show_Rev();
        }

        private void bt_spec_disp_Click(object sender, EventArgs e)
        {
            con.Open();

            String st = (cb_Beg.Text);
            String ed = (cb_End.Text);

            if(cb_Beg.Text.Equals("")&&cb_End.Text.Equals(""))
            {
                String fromdate = from_dtp.Value.ToString("yyyy-MM-dd");
                String todate = to_dtp.Value.ToString("yyyy-MM-dd");
                DataTable dta = new DataTable();
                SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date", con); ;
                dtaadp.Fill(dta);
                dgv_rev.DataSource = dta;
            }
            else if((cb_Beg.Text.Equals("") == false) && (cb_End.Text.Equals("") == true))
            {
                String fromdate = from_dtp.Value.ToString("yyyy-MM-dd");
                String todate = to_dtp.Value.ToString("yyyy-MM-dd");
                DataTable dta = new DataTable();
                SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date HAVING SUM(Amount) >= '"+st+ "'", con); 
                dtaadp.Fill(dta);
                dgv_rev.DataSource = dta;
            }
            else if((cb_End.Text.Equals("") == false) && (cb_Beg.Text.Equals("") == true))
            {
                String fromdate = from_dtp.Value.ToString("yyyy-MM-dd");
                String todate = to_dtp.Value.ToString("yyyy-MM-dd");
                DataTable dta = new DataTable();
                SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date HAVING SUM(Amount) <= '" + ed + "'", con);
                dtaadp.Fill(dta);
                dgv_rev.DataSource = dta;
               
            }
            else
            {
                String fromdate = from_dtp.Value.ToString("yyyy-MM-dd");
                String todate = to_dtp.Value.ToString("yyyy-MM-dd");
                DataTable dta = new DataTable();
                SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)'FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date  HAVING SUM(Amount) BETWEEN '" + st + "' AND '"+ed+ "'", con);
                dtaadp.Fill(dta);
                dgv_rev.DataSource = dta;
               
            }
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            con.Open();
            String daydate = day_dtp.Value.ToString("yyyy-MM-dd");
            

            DataTable dta = new DataTable();
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT * FROM [Revenue] WHERE  date BETWEEN '"+(daydate+" 00:00:00")+"' AND '"+(daydate+" 23:59:59")+"'", con);
            dtaadp.Fill(dta);
            dgv_rev.DataSource = dta;
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) AS [Total(Day)] FROM [Revenue] WHERE date BETWEEN '" + (daydate + " 00:00:00") + "' AND '" + (daydate + " 23:59:59") + "'",con);
            using(SqlDataReader dr = cmd.ExecuteReader())
            {
                if(dr.Read())
                {
                    lb_total.Text = dr["Total(Day)"].ToString();
                    if(lb_total.Text.Equals(""))
                    {
                        lb_total.Text = "None";
                    }
                }
                
            }
            day_dtp.Checked = false;
            con.Close();
        }

        private void bt_get_total_Click(object sender, EventArgs e)
        {
            

            if (from_dtp.Checked && to_dtp.Checked)
            {
                con.Open();

                String fromdate = from_dtp.Value.ToString("yyyy-MM-dd");
                String todate = to_dtp.Value.ToString("yyyy-MM-dd");

                String st = cb_Beg.Text;
                String ed = cb_End.Text;

                if((cb_Beg.Text.Equals("") == true) && (cb_End.Text.Equals("") == true))
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) AS Total FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "'", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            total.Text = dr["Total"].ToString();
                        }
                    }
                }
                else if ((cb_Beg.Text.Equals("") == false) && (cb_End.Text.Equals("") == true))
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date  HAVING SUM(Amount) >= '"+st+"') AS subquery", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            total.Text = dr["Total"].ToString();
                        }
                    }
                }
                else if ((cb_Beg.Text.Equals("") == true) && (cb_End.Text.Equals("") == false))
                {
                    SqlCommand cmd = new SqlCommand(" SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date HAVING SUM(Amount) <= '" + ed + "') AS subquery", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            total.Text = dr["Total"].ToString();
                        }
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date  HAVING SUM(Amount) BETWEEN '" + st+"' AND '" + ed + "')  AS subquery", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            total.Text = dr["Total"].ToString();
                        }
                    }
                }
                con.Close();
            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) AS Total FROM [Revenue]", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        total.Text = dr["Total"].ToString();
                    }
                }

                con.Close();
            }
            

        }

        private void cb_Beg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void bt_back_man_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openAfter_mngr_login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Revenue_Form_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void from_dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_rev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
