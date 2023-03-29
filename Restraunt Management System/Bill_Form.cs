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
using static System.Windows.Forms.LinkLabel;


namespace Restraunt_Management_System
{
    public partial class Bill_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\source\repos\Restaurant_management_system\Restraunt Management System\Dala.mdf"";Integrated Security=True");
        public Bill_Form()
        {
            InitializeComponent();
            rb_none.Checked = true;
            show_bill();
        }

        public void openAfter_cash_login(object obj)
        {
            Application.Run(new After_cash_login());
        }

        private void button2_Click(object sender, EventArgs e)  //TO DELETE BUTTON EVENT
        {
            con.Open();


            int k; //for checking if query has worked or not

            if (tb_b_id.Text.Equals(""))
            {
                int d_id = Convert.ToInt32(bill_dgv.CurrentCell.Value);

                SqlCommand delfrev = new SqlCommand("DELETE FROM Revenue WHERE Id IN(SELECT Id AS BID FROM Bill WHERE B_id = '"+d_id+"')", con);
                delfrev.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Bill] WHERE B_id = '" + d_id + "'", con);
                k = cmd.ExecuteNonQuery();
                con.Close();
                if (k > 0)
                {
                    show_bill();
                   
                }
                else
                {
                    MessageBox.Show("Data was not deleted successfully");
                }
                clear_text();
            }
            else
            {
                int del_id = Convert.ToInt32(tb_b_id.Text);
                SqlCommand delfrev = new SqlCommand("DELETE FROM Revenue WHERE Id IN(SELECT Id AS BID FROM Bill WHERE B_id = '" + del_id + "')", con);
                delfrev.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Bill] WHERE B_id = '" + del_id + "'", con);
                k = cmd.ExecuteNonQuery();
                con.Close();
                if (k > 0)
                {
                    show_bill();
                   
                }
                else
                {
                    MessageBox.Show("Data was not deleted successfully");
                }
                clear_text();
            }

        }

        public void clear_text()  // CLEARING FUNCTION 
        {
            tb_b_id.Text = "";
            cb_dtype.Text = "";
            cb_dqty.Text = "";
            cb_ftype.Text = "";
            cb_fqty.Text = "";
            tb_search_bill.Text = "";
            rb_none.Checked = true;


            dtp.Value = DateTime.Now;
            dtp.Checked = false;
            tb_date.Text = "";


        }

        private void bt_add_Click(object sender, EventArgs e)  //TO ADD BUTTON EVENT
        {
            con.Open();
            int id,b_id, fqty, dqty;
            int discount, total;
            String ftype, dtype, date;

            id = 0;
            b_id = Convert.ToInt32(tb_b_id.Text);
            ftype = cb_ftype.Text;
            fqty = Convert.ToInt32(cb_fqty.Text);
            dtype = cb_dtype.Text;
            dqty = Convert.ToInt32(cb_dqty.Text);
            total = Convert.ToInt32(cb_ftype.Text.Split("Rs")[1]) * fqty + Convert.ToInt32(cb_dtype.Text.Split("Rs")[1]) * dqty;
            discount = 0;

            if (tb_date.Text.Equals(""))
            {
                date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                date = tb_date.Text;
            }


            int k;//for checking if query has worked or not


            if (rb_member.Checked)
            {
                discount = (10 * total) / 100;
                total = total - discount;
                SqlCommand cmd = new SqlCommand("INSERT INTO [Bill] ([Food type],[Food qty],[Drink type],[Drink qty],[Discount],[Total],[Datetime],[B_id]) VALUES('" + ftype + "','" + fqty + "','" + dtype + "','" + dqty + "','" + discount + "','" + total + "','" + date + "','" + b_id + "')", con);
                k = cmd.ExecuteNonQuery();
                con.Close();
                if(k > 0)
                {
                    
                    show_bill();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT MAX(Id) AS Id FROM Bill",con);
                    con.Close();
                    con.Open();
                    using (SqlDataReader dr = cmd1.ExecuteReader())
                    {

                        if(dr.Read())
                        {
                            id = Convert.ToInt32(dr["Id"]);
                            con.Close();
                            Auto_add_Rev(id, total, date);
                        }
                        
                    }
                    
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("Data was not added successfully");
                }
                clear_text();

            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Bill] ([Food type],[Food qty],[Drink type],[Drink qty],[Discount],[Total],[Datetime],[B_id]) VALUES('" + ftype + "','" + fqty + "','" + dtype + "','" + dqty + "','" + discount + "','" + total + "','" + date + "','" + b_id + "')", con);
                k = cmd.ExecuteNonQuery();
                con.Close();
                if (k > 0)
                {
                    show_bill();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT MAX(Id) AS Id FROM Bill", con);
                    con.Close();
                    con.Open();
                    using (SqlDataReader dr = cmd1.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            id = Convert.ToInt32(dr["Id"]);
                            con.Close();
                            Auto_add_Rev(id, total, date);
                        }
                        
                    }
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("Data was not added successfully");
                }
                clear_text();
            }

        }

        public void Auto_add_Rev(int id, int total, String date)  //TO AUTO ADD REVENUE FUNCTION
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Revenue] VALUES('" + id + "','" + total + "','" + date + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Auto_del_Rev(int del_id)     //TO AUTO DELETE REVENUE FUNCTION
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [Revenue] WHERE Id = '" + del_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void show_bill() //  TO DISPLAY BILL DATA FUNCTION
        {
            con.Open();
            DataTable dta = new DataTable();
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT [B_id],[Datetime],[Food type],[Food qty],[Drink type],[Drink qty],[Discount],[Total] FROM [Bill]", con);
            dtaadp.Fill(dta);
            bill_dgv.DataSource = dta;
            con.Close();
        }

        private void bt_search_bill_Click(object sender, EventArgs e)  //TO SEARCH BILL
        {
           
            if(tb_search_bill.Text.Equals(""))
            {
                MessageBox.Show("Enter Bill value to be searched");
            }
            else
            {
                string bsearch = tb_search_bill.Text;
                if (int.TryParse(bsearch, out int value))
                {
                    con.Open();
                    DataTable dta = new DataTable();
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT [B_id],[Datetime],[Food type],[Food qty],[Drink type],[Drink qty],[Discount],[Total] FROM [Bill] WHERE B_id = '" + bsearch+"'",con);
                    dtaadp.Fill(dta);
                    con.Close();
                    

                    if (dta.Rows.Count>0)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT SUM(Total) FROM Bill WHERE B_id='" + bsearch + "'", con);
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();

                        DataColumn dc = dta.Columns["Total"];
                        dc.ColumnName = "Total (" + total + ")";
                        dta.AcceptChanges();

                        bill_dgv.DataSource = dta;
                    }
                    else
                    { 
                        MessageBox.Show("There are no Bill with Bill no: " + bsearch);
                    }
                }
                else
                {
                    MessageBox.Show("Enter a number from Bill not words");
                }
            }
            
          
        }

        private void bt_upd_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_MouseEnter(object sender, EventArgs e)
        {
            bt_add.BackColor = Color.Green;
            bt_add.ForeColor = Color.White;
            bt_disp.BackColor = Color.LightGray;
            bt_disp.ForeColor = Color.Black;
        }

        private void bt_add_MouseLeave(object sender, EventArgs e)
        {
            bt_add.BackColor = Color.LightGray;
            bt_add.ForeColor = Color.Black;
        }

        private void bt_del_MouseEnter(object sender, EventArgs e)
        {
            bt_del.BackColor = Color.Red;
            bt_del.ForeColor = Color.White;
        }

        private void bt_del_MouseLeave(object sender, EventArgs e)
        {
            bt_del.BackColor = Color.LightGray;
            bt_del.ForeColor = Color.Black;
        }

        private void bt_back_cash_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openAfter_cash_login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            String date = dtp.Value.ToString("yyyy-MM-dd HH:mm:ss");
            tb_date.Text = date;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bill_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_display_Click(object sender, EventArgs e)
        {
            clear_text();
             show_bill();
        }
    }
}
