﻿using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\source\repos\Restaurant_management_system\Restraunt Management System\Dala.mdf"";Integrated Security=True");
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
        public void show_Rev() //display all data and refreshes everythings
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


            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;


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

        private void bt_spec_disp_Click(object sender, EventArgs e)  //To do filter display
        {
            if(day_dtp.Checked==true)
            {
                day_dtp.Checked=false;
                show_Rev();
                return;
            }

            String st = (cb_Beg.Text);
            String ed = (cb_End.Text);

            String fromdate = from_dtp.Value.ToString("yyyy-MM-dd");
            String todate = to_dtp.Value.ToString("yyyy-MM-dd");

            
            //filter search with range only
            if(((from_dtp.Checked==true)&&(to_dtp.Checked==true)) ||(from_dtp.Checked==true)||(to_dtp.Checked==true)) //validation included display
            {

                //validation
                if (from_dtp.Value > to_dtp.Value)
                {
                    MessageBox.Show("Invalid Date choose valid date");
                    con.Close();
                    return;
                }

                if (to_dtp.Value < from_dtp.Value)
                {
                    MessageBox.Show("Invalid Date choose valid date!");
                    con.Close();
                    return;
                }

                if((cb_Beg.Text != "") &&(cb_End.Text != ""))
                {
                    if (Convert.ToInt32(cb_Beg.Text) > Convert.ToInt32(cb_End.Text))
                    {
                        MessageBox.Show("Invalid Amount range choose valid amount range");
                        con.Close();
                        return;
                    }
                }

                con.Open();

                //if valid code start here
                if (cb_Beg.Text.Equals("") && cb_End.Text.Equals(""))
                {
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date", con); ;
                    dtaadp.Fill(dta);

                    if(dta.Rows.Count==0)
                    {
                        MessageBox.Show("There are no records to display");
                    }
                    dgv_rev.DataSource = dta;
                }
                else if ((cb_Beg.Text.Equals("") == false) && (cb_End.Text.Equals("") == true))
                {
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date HAVING SUM(Amount) >= '" + st + "'", con);
                    dtaadp.Fill(dta);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no records to display");
                    }
                    dgv_rev.DataSource = dta;
                }
                else if ((cb_End.Text.Equals("") == false) && (cb_Beg.Text.Equals("") == true))
                {
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date HAVING SUM(Amount) <= '" + ed + "'", con);
                    dtaadp.Fill(dta);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no records to display");
                    }
                    dgv_rev.DataSource = dta;
                }
                else
                {
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)'FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date  HAVING SUM(Amount) BETWEEN '" + st + "' AND '" + ed + "'", con);
                    dtaadp.Fill(dta);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no records to display");
                    }
                    dgv_rev.DataSource = dta;
                }
                con.Close();
            }
            else if((cb_Beg.Text != "") || (cb_End.Text != "") || ((cb_Beg.Text != "") && (cb_End.Text != "")))
            {
                if ((cb_Beg.Text != "") && (cb_End.Text != ""))
                {
                    if (Convert.ToInt32(cb_Beg.Text) > Convert.ToInt32(cb_End.Text))
                    {
                        MessageBox.Show("Invalid Amount range choose valid amount range");
                        con.Close();
                        return;
                    }
                }

                con.Open();
                if ((cb_Beg.Text.Equals("") == false) && (cb_End.Text.Equals("") == true))
                {
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] GROUP BY date HAVING SUM(Amount) >= '"+st+"' ", con);
                    dtaadp.Fill(dta);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no records to display");
                    }
                    dgv_rev.DataSource = dta;
                }
                else if ((cb_Beg.Text.Equals("") == true) && (cb_End.Text.Equals("") == false))
                {
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] GROUP BY date HAVING SUM(Amount) <= '" + ed + "' ", con);
                    dtaadp.Fill(dta);

                    if(dta.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no records to display");
                    }
                    dgv_rev.DataSource = dta;
                }
                else
                {
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT date,SUM(Amount) AS 'Total(Day)' FROM [Revenue] GROUP BY date HAVING SUM(Amount) BETWEEN '" + st+"' AND  '" + ed + "' ", con);
                    dtaadp.Fill(dta);
                    if (dta.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no records to display");
                    }
                    dgv_rev.DataSource = dta;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("No filters are applied You can press DISPLAY ALL");
                return;
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //to check each transaction on single day 
        {
            label12.Visible = false;
            if (day_dtp.Checked)
            {
                label12.Visible = true;
            }

            day_dtp.Checked = true;
            total.Text = "None";

            con.Open();
            String daydate = day_dtp.Value.ToString("yyyy-MM-dd");


            DataTable dta = new DataTable();
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT * FROM [Revenue] WHERE  date BETWEEN '" + (daydate + " 00:00:00") + "' AND '" + (daydate + " 23:59:59") + "'", con);
            dtaadp.Fill(dta);
            
            dgv_rev.DataSource = dta;
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) AS [Total(Day)] FROM [Revenue] WHERE date BETWEEN '" + (daydate + " 00:00:00") + "' AND '" + (daydate + " 23:59:59") + "'", con);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    lb_total.Text = dr["Total(Day)"].ToString();
                    if (lb_total.Text.Equals(""))
                    {
                        lb_total.Text = "None";       
                    }
                }

            }
           // day_dtp.Checked = false;
            con.Close();
            
        }

        private void bt_get_total_Click(object sender, EventArgs e) // for getting total amount
        {
            if(day_dtp.Checked)
            {
                day_dtp.Checked=false;
               //label12.Visible visible= false;
                show_Rev();
            }

            if(((from_dtp.Checked == true) && (to_dtp.Checked == true)) || (from_dtp.Checked == true) || (to_dtp.Checked == true)) //validation
            {
                if (from_dtp.Value > to_dtp.Value)
                {
                    MessageBox.Show("Invalid Date choose valid date");
                    con.Close();
                    return;
                }

                if (to_dtp.Value < from_dtp.Value)
                {
                    MessageBox.Show("Invalid Date choose valid date!");
                    con.Close();
                    return;
                }

                if ((cb_Beg.Text != "") && (cb_End.Text != ""))
                {
                    if (Convert.ToInt32(cb_Beg.Text) > Convert.ToInt32(cb_End.Text))
                    {
                        MessageBox.Show("Invalid Amount range choose valid amount range");
                        con.Close();
                        return;
                    }
                }


            }

            // filter total without range only
            if((from_dtp.Checked && to_dtp.Checked) || (from_dtp.Checked == true) || (to_dtp.Checked == true))  //Id filter date is selected 
            {
                con.Open();

                String fromdate = from_dtp.Value.ToString("yyyy-MM-dd");
                String todate = to_dtp.Value.ToString("yyyy-MM-dd");

                String st = cb_Beg.Text;
                String ed = cb_End.Text;

                if ((cb_Beg.Text.Equals("") == true) && (cb_End.Text.Equals("") == true))
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) AS Total FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "'", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            total.Text = dr["Total"].ToString();

                            if(total.Text.Equals(""))
                            {
                                total.Text = "None";
                            }
                        }
                    }
                }
                else if ((cb_Beg.Text.Equals("") == false) && (cb_End.Text.Equals("") == true))
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date  HAVING SUM(Amount) >= '" + st + "') AS subquery", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            total.Text = dr["Total"].ToString();
                            if (total.Text.Equals(""))
                            {
                                total.Text = "None";
                            }
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

                            if (total.Text.Equals(""))
                            {
                                total.Text = "None";
                            }
                        }
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] WHERE date BETWEEN '" + fromdate + "' AND '" + todate + "' GROUP BY date  HAVING SUM(Amount) BETWEEN '" + st + "' AND '" + ed + "')  AS subquery", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            total.Text = dr["Total"].ToString();
                            if (total.Text.Equals(""))
                            {
                                total.Text = "None";
                            }
                        }
                    }
                }

                con.Close();

            }
            else if((cb_Beg.Text!="")||(cb_End.Text!="")||((cb_Beg.Text!="")&&(cb_End.Text!="")))
            {
                String st = cb_Beg.Text;
                String ed = cb_End.Text;

                con.Open();
                if((cb_Beg.Text.Equals("")==false)&&(cb_End.Text.Equals("")==true))
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] GROUP BY date HAVING SUM(Amount) >= '" + st + "') AS subquery", con);
                    total.Text = cmd.ExecuteScalar().ToString();
                    if (total.Text.Equals(""))
                    {
                        total.Text = "None";
                    }
                }
                else if((cb_Beg.Text.Equals("") == true) && (cb_End.Text.Equals("") == false))
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] GROUP BY date HAVING SUM(Amount) <= '" + ed + "') AS subquery", con);
                    total.Text = cmd.ExecuteScalar().ToString();
                    if (total.Text.Equals(""))
                    {
                        total.Text = "None";
                    }

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(subquery.subtotal) AS Total FROM (SELECT SUM(Amount) AS subtotal FROM [Revenue] GROUP BY date HAVING SUM(Amount)  BETWEEN '" + st + "'  AND  '" + ed + "') AS subquery", con);
                    total.Text = cmd.ExecuteScalar().ToString();
                    if (total.Text.Equals(""))
                    {
                        total.Text = "None";
                    }
                }
                con.Close();
            }
            else  //all total
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT SUM(Amount) AS Total FROM [Revenue]", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        total.Text = dr["Total"].ToString();
                        if (total.Text.Equals(""))
                        {
                            total.Text = "None";
                        }
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

        private void lb_total_Click(object sender, EventArgs e)
        {

        }

        private void Revenue_Form_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cb_Beg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_End_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_End_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void from_dtp_ValueChanged_1(object sender, EventArgs e)
        {
            label11.Visible = false;
            if(from_dtp.Checked)
            {
                label11.Visible = true;
            }

            if(from_dtp.Value.ToString("dd-MMM-yyyy") == DateTime.Now.ToString("dd-MMM-yyyy"))
            {
                label11.Visible = false;
                from_dtp.Checked = false;
            }            
        }

        private void to_dtp_ValueChanged(object sender, EventArgs e)
        {
            label10.Visible = false;
            if(to_dtp.Checked)
            {
                label10.Visible = true;
            }
            if(to_dtp.Value.ToString("dd-MMM-yyyy") == DateTime.Now.ToString("dd-MMM-yyyy"))
            {
                label10.Visible = false;
                to_dtp.Checked = false;
            }
        }
    }
}