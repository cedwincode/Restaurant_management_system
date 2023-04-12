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
    public partial class Bill_Form : Form
    {
        //bryan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\source\repos\Restaurant_management_system\Restraunt Management System\Dala.mdf"";Integrated Security=True");

        //bryan 2
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\Desktop\nata\Restraunt Management System\Dala.mdf"";Integrated Security=True");

        //cedwin
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programming\web programming\restaurant management system\Restraunt Management System\Dala.mdf"";Integrated Security=True;Connect Timeout=30");
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
            if ((tb_b_id.Text == "") && bill_dgv.CurrentCell.Selected == false)
            {
                MessageBox.Show("Entered a Bill id or select Bill id from table and try again!!");
                return;
            }

            int k; //for checking if query has worked or not

            if (tb_b_id.Text.Equals(""))
            {
                int srow = bill_dgv.CurrentCell.RowIndex;
                int d_id = Convert.ToInt32(bill_dgv.Rows[srow].Cells[0].Value);

                

                DialogResult result = MessageBox.Show("Are you sure want to delete Bill with Id: "+d_id+"", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result != DialogResult.OK)
                {
                    return;
                }

                con.Open();
                SqlCommand delfrev = new SqlCommand("DELETE FROM Revenue WHERE Id IN(SELECT Id AS BID FROM Bill WHERE B_id = '" + d_id + "')", con);
                delfrev.ExecuteNonQuery();
                con.Close();


                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Bill] WHERE B_id = '" + d_id + "'", con);
                k = cmd.ExecuteNonQuery();
                con.Close();
                if (k > 0)
                {
                    MessageBox.Show("Deleted Bill with Id: " + d_id);
                    show_bill();

                }
                else
                {
                    MessageBox.Show("There was no bill with Bill no:" + d_id);
                }
                clear_text();
            }
            else
            {
                con.Open();
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
                    MessageBox.Show("Deleted Bill with Id: " + del_id);
                    show_bill();

                }
                else
                {
                    MessageBox.Show("There was no bill with Bill no:" + del_id);
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

            if (tb_b_id.Text == "")
            {
                MessageBox.Show("You have not entered Bill id");
                return;
            }

            if (((cb_ftype.Text == "") && (cb_fqty.Text == "")) && ((cb_dtype.Text == "") && (cb_dqty.Text == "")))
            {
                MessageBox.Show("Atleast 1 Drink or 1 Food Item must be there!!");
                return;
            }

            if (((cb_ftype.Text != "") && (cb_fqty.Text == "")) || ((cb_ftype.Text == "") && (cb_fqty.Text != "")))
            {
                MessageBox.Show("Both Food Type and Food quantity  must have value");
                return;
            }

            if (((cb_dtype.Text != "") && (cb_dqty.Text == "")) || ((cb_dtype.Text == "") && (cb_dqty.Text != "")))
            {
                MessageBox.Show("Both Drink Type and Drink quantity  must have value");
                return;
            }

            //validation below ************FTYPE****************
            if ((cb_ftype.Text != "") && (cb_fqty.Text != ""))
            {
                String fitem = cb_ftype.Text;
                if (fitem.Contains(" Rs") == false)
                {
                    MessageBox.Show("String does not have Rs or space infront of Rs or Try e.g [pudding Rs23]");
                    return;
                }

                String fname = fitem.Split(" Rs")[0];
                String fprice = fitem.Split(" Rs")[1];

                if ((fname != "") && (fprice != "") && (fname.Substring(0, 1) != " "))
                {
                    if (int.TryParse(fprice, out int value))
                    {
                        if ((fprice == "0") || fprice.Substring(0,1).Equals("-"))
                        {
                            MessageBox.Show("price cant be 0, negative number or Try e.g [pudding Rs23]");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("After Rs was not a number or Try e.g [pudding Rs23]");
                        return;
                    }
                    if (fprice.Substring(0, 1) == " ")
                    {
                        MessageBox.Show("String is not correct!! or after Rs there is a space. Try e.g [pudding Rs23] ");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("String format is not correct!! or starting space is there. Try  (e.g [pudding Rs23])");
                    return;
                }

            }
            //validation above ************FTYPE****************


            //validation below ************DTYPE****************
            if ((cb_dtype.Text != "") && (cb_dqty.Text != ""))
            {
                String ditem = cb_dtype.Text;

                if (ditem.Contains(" Rs") == false)
                {
                    MessageBox.Show("String does not have Rs or space infront of Rs or Try e.g [Soda Rs23] ");
                    return;
                }

                String dname = ditem.Split(" Rs")[0];
                String dprice = ditem.Split(" Rs")[1];

                if ((dname != "") && (dprice != "") && (dname.Substring(0, 1) != " "))
                {
                    if (int.TryParse(dprice, out int value))
                    {
                        if ((dprice == "0") || dprice.Substring(0,1).Equals("-"))
                        {
                            MessageBox.Show("price can't be 0, negative number or Try e.g [Soda Rs23] ");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("After Rs was not a number or Try e.g [Soda Rs23] ");
                        return;
                    }

                    if (dprice.Substring(0, 1) == " ")
                    {
                        MessageBox.Show("String is not correct!! or after Rs there is a space. Try e.g [Soda Rs23] ");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("String format is not correct!! or starting space is there. Try  (e.g [Soda Rs23])");
                    return;
                }
            }
            //validation above ************DTYPE****************

            int id, b_id, fqty, foodprice, drinkprice, dqty;
            int discount, total;
            String ftype, dtype, date;

            id = 0; // To store Primary key of the revenue table before automatic add to bill
            b_id = Convert.ToInt32(tb_b_id.Text);


            //Stroring data in the variables
            if (((cb_ftype.Text != "") && (cb_fqty.Text != "")) && ((cb_dtype.Text == "") && (cb_dqty.Text == "")))
            {
                dtype = "null";
                drinkprice = 0;
                dqty = 0;

                ftype = cb_ftype.Text;
                foodprice = Convert.ToInt32(cb_ftype.Text.Split(" Rs")[1]);

                if (Convert.ToInt32(cb_fqty.Text) == 0)
                {
                    MessageBox.Show("Food quantity can't be 0");
                    return;
                }
                fqty = Convert.ToInt32(cb_fqty.Text);
            }
            else if (((cb_dtype.Text != "") && (cb_dqty.Text != "")) && ((cb_ftype.Text == "") && (cb_fqty.Text == "")))
            {
                ftype = "null";
                foodprice = 0;
                fqty = 0;

                dtype = cb_dtype.Text;
                drinkprice = Convert.ToInt32(cb_dtype.Text.Split(" Rs")[1]);

                if (Convert.ToInt32(cb_dqty.Text) == 0)
                {
                    MessageBox.Show("Drink quantity can't be 0");
                    return;
                }
                dqty = Convert.ToInt32(cb_dqty.Text);
            }
            else
            {
                ftype = cb_ftype.Text;
                foodprice = Convert.ToInt32(cb_ftype.Text.Split(" Rs")[1]);
                if (Convert.ToInt32(cb_fqty.Text) == 0)
                {
                    MessageBox.Show("Food quantity can't be 0");
                    return;
                }
                fqty = Convert.ToInt32(cb_fqty.Text);


                dtype = cb_dtype.Text;
                if (Convert.ToInt32(cb_dqty.Text) == 0)
                {
                    MessageBox.Show("Drink quantity can't be 0");
                    return;
                }
                drinkprice = Convert.ToInt32(cb_dtype.Text.Split(" Rs")[1]);
                dqty = Convert.ToInt32(cb_dqty.Text);

            }


            total = foodprice * fqty + drinkprice * dqty;  //calculating total
            discount = 0;

            if (tb_date.Text.Equals(""))
            {
                date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                date = tb_date.Text;
            }
 

            //CHECKING IF ADDING ITEM TO A PREVIOUS BILL
            con.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT COUNT(B_id) FROM [Bill] WHERE B_id = '" + b_id + "'",con);
            int m = Convert.ToInt32(cmd4.ExecuteScalar());
            con.Close();
            if(m >= 1)
            {
                con.Open();
                SqlCommand cmd5 = new SqlCommand("SELECT TOP 1 Datetime FROM [Bill] WHERE B_id = '" + b_id + "'",con);
                String alrdate = cmd5.ExecuteScalar().ToString();
                con.Close();

                DateTime today = new DateTime();
                today = Convert.ToDateTime(alrdate);
                String todaydate = today.Date.ToString("yyyy-MM-dd");

                DateTime dat = DateTime.Now;
                if(dat.Date.ToString("yyyy-MM-dd").Equals(todaydate)==false)
                {
                    MessageBox.Show("You cannot enter item to a bill with previous date");
                    return;
                }
            }


            //Checking membership if next is none
            if(rb_none.Checked)
            {
                con.Open();
                SqlCommand cmd7 = new SqlCommand("SELECT COUNT(B_id) FROM [Bill] WHERE B_id = '" + b_id + "'",con);
                int n = Convert.ToInt32(cmd7.ExecuteScalar());
                con.Close();

                if(n >= 1)
                {
                    con.Open();
                    SqlCommand cmd6 = new SqlCommand("SELECT TOP 1 Discount FROM [Bill] Where B_id = '" + b_id + "' ", con);
                    int chdiscout = Convert.ToInt32(cmd6.ExecuteScalar());
                    con.Close();
                    if (chdiscout != 0)
                    {
                        MessageBox.Show("Invalid First you did Memeber and now None do member");
                        return;
                    }
                }
            }
            else  //Checking none if next is memebership
            {
                con.Open();
                SqlCommand cmd7 = new SqlCommand("SELECT COUNT(B_id) FROM [Bill] WHERE B_id = '" + b_id + "'", con);
                int n = Convert.ToInt32(cmd7.ExecuteScalar());
                con.Close();

                if (n >= 1)
                {
                    con.Open();
                    SqlCommand cmd6 = new SqlCommand("SELECT TOP 1 Discount FROM [Bill] Where B_id = '" + b_id + "' ", con);
                    int chdiscout = Convert.ToInt32(cmd6.ExecuteScalar());
                    con.Close();
                    if (chdiscout == 0)
                    {
                        MessageBox.Show("Invalid First you did None and now Member do none");
                        return;
                    }
                }
            }
            

            //FINALLY IF EVERYTHING IS CORRECT STORING DATA
            con.Open();
            int k;//for checking if query has worked or not


            if (rb_member.Checked)
            {
                discount = (10 * total) / 100;
                total = total - discount;
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
            SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT [B_id],[Datetime],[Food type],[Food qty],[Drink type],[Drink qty],[Discount],[Total] FROM [Bill] ORDER BY B_id DESC", con);
            dtaadp.Fill(dta);
            bill_dgv.DataSource = dta;

            con.Close();
        }

        private void bt_search_bill_Click(object sender, EventArgs e)  //TO SEARCH BILL
        {

            if (tb_search_bill.Text.Equals(""))
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
                    SqlDataAdapter dtaadp = new SqlDataAdapter("SELECT [B_id],[Datetime],[Food type],[Food qty],[Drink type],[Drink qty],[Discount],[Total] FROM [Bill] WHERE B_id = '" + bsearch + "'", con);
                    dtaadp.Fill(dta);
                    con.Close();


                    if (dta.Rows.Count > 0)
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

        private void bt_add_MouseEnter(object sender, EventArgs e)
        {
            bt_add.BackColor = Color.Green;
            bt_add.ForeColor = Color.White;
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
        private void bt_display_MouseEnter(object sender, EventArgs e)
        {
            bt_display.BackColor = Color.DodgerBlue;
            bt_display.ForeColor = Color.White;
        }

        private void bt_display_MouseLeave(object sender, EventArgs e)
        {
            bt_display.BackColor = Color.LightGray;
            bt_display.ForeColor = Color.Black;
        }

        private void bt_disp_MouseEnter(object sender, EventArgs e)
        {
            bt_disp.BackColor = Color.Tomato;
            bt_disp.ForeColor = Color.White;
        }

        private void bt_disp_MouseLeave(object sender, EventArgs e)
        {
            bt_disp.BackColor = Color.LightGray;
            bt_disp.ForeColor = Color.Black;
        }

        private void bt_back_cash_Click(object sender, EventArgs e) //TO GO BACK AT CASHIER HOMEPAGE
        {
            Thread th = new Thread(openAfter_cash_login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            String date = dtp.Value.ToString("yyyy-MM-dd HH:mm:ss");
            tb_date.Text = date;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_display_Click(object sender, EventArgs e)  //TO DISPLAY DATA
        {

            clear_text();
            show_bill();
        }

        private void tb_b_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_fqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_ftype.Text.Equals(""))
            {

                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void cb_dqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_dtype.Text.Equals(""))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void bill_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in bill_dgv.Rows)
            {
                for (int i = 0; i < bill_dgv.ColumnCount; i++)
                {
                    if (row.Cells[i].Value != null)
                    {
                        row.Cells[i].Style.BackColor = Color.LightGreen;
                        row.Cells[i].Style.ForeColor = Color.Black;

                    }
                }
            }
        }

        private void tb_b_id_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_b_id.Text.Length > 9)
            {
                tb_b_id.Text = tb_b_id.Text.Substring(0, 9);
                tb_b_id.SelectionStart = tb_b_id.Text.Length;
                tb_b_id.SelectionLength = 0;
            }
        }

        private void cb_fqty_TextChanged(object sender, EventArgs e)
        {
            if (cb_fqty.Text.Length > 3)
            {
                cb_fqty.Text = cb_fqty.Text.Substring(0, 3);
                cb_fqty.SelectionStart = cb_fqty.Text.Length;
                cb_fqty.SelectionLength = 0;
            }
        }

        private void cb_dqty_TextChanged(object sender, EventArgs e)
        {
            if (cb_dqty.Text.Length > 3)
            {
                cb_dqty.Text = cb_dqty.Text.Substring(0, 3);
                cb_dqty.SelectionStart = cb_dqty.Text.Length;
                cb_dqty.SelectionLength = 0;
            }
        }

        private void tb_search_bill_TextChanged(object sender, EventArgs e)
        {
            if (tb_search_bill.Text.Length > 9)
            {
                tb_search_bill.Text = tb_search_bill.Text.Substring(0, 9);
                tb_search_bill.SelectionStart = tb_search_bill.Text.Length;
                tb_search_bill.SelectionLength = 0;
            }
        }

        private void cb_ftype_TextChanged(object sender, EventArgs e)
        {
            if (cb_ftype.Text.Length > 30)
            {
                cb_ftype.Text = cb_ftype.Text.Substring(0, 30);
                cb_ftype.SelectionStart = cb_ftype.Text.Length;
                cb_ftype.SelectionLength = 0;
            }
        }

        private void cb_dtype_TextChanged(object sender, EventArgs e)
        {
            if (cb_dtype.Text.Length > 30)
            {
                cb_dtype.Text = cb_dtype.Text.Substring(0, 30);
                cb_dtype.SelectionStart = cb_dtype.Text.Length;
                cb_dtype.SelectionLength = 0;
            }
        }
    }
}
