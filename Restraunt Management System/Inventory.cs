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
    public partial class Inventory : Form
    {
        //bryan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\source\repos\Restaurant_management_system\Restraunt Management System\Dala.mdf"";Integrated Security=True");

        //bryan 2
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rodri\Desktop\nata\Restraunt Management System\Dala.mdf"";Integrated Security=True");

        //cedwin
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Programming\web programming\restaurant management system\Restraunt Management System\Dala.mdf"";Integrated Security=True;Connect Timeout=30");

        public Inventory()
        {
            InitializeComponent();


            //sugar retrieve
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT item_value FROM [Items] WHERE item_name='sugar'", con);
            sugar_bar.Value = Convert.ToInt32(cmd1.ExecuteScalar());
            con.Close();

            //eggs retrieve
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT item_value FROM [Items] WHERE item_name='eggs'", con);
            eggs_bar.Value = Convert.ToInt32(cmd2.ExecuteScalar());
            con.Close();

            //potato retrieve
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT item_value FROM [Items] WHERE item_name='potato'", con);
            potato_bar.Value = Convert.ToInt32(cmd3.ExecuteScalar());
            con.Close();

            //tomato retrieve
            con.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT item_value FROM [Items] WHERE item_name='tomato'", con);
            tomato_bar.Value = Convert.ToInt32(cmd4.ExecuteScalar());
            con.Close();

            //oil retrieve
            con.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT item_value FROM [Items] WHERE item_name='oil'", con);
            oil_bar.Value = Convert.ToInt32(cmd5.ExecuteScalar());
            con.Close();
        }

        public void openAfter_mngr_login(object obj)
        {
            Application.Run(new After_mngr_login());
        }

        private void buy_all_sugar_Click(object sender, EventArgs e)
        {
            sugar_bar.Value = 100;

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + sugar_bar.Value + "' WHERE item_name= 'sugar' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buy_all_eggs_Click(object sender, EventArgs e)
        {
            eggs_bar.Value = 100;

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + eggs_bar.Value + "' WHERE item_name= 'eggs' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buy_all_potato_Click(object sender, EventArgs e)
        {
            potato_bar.Value = 100;

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + potato_bar.Value + "' WHERE item_name= 'potato' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buy_all_tomato_Click(object sender, EventArgs e)
        {
            tomato_bar.Value = 100;

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + tomato_bar.Value + "' WHERE item_name= 'tomato' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buy_all_oil_Click(object sender, EventArgs e)
        {
            oil_bar.Value = 100;

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + oil_bar.Value + "' WHERE item_name= 'oil' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buy_selected_sugar_Click(object sender, EventArgs e)
        {
            if(sugar_per.Text==""||Convert.ToInt32(sugar_per.Text)==0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (sugar_bar.Value + (Convert.ToInt32(sugar_per.Text)) <= 100)
            {
                sugar_bar.Value = sugar_bar.Value + Convert.ToInt32(sugar_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + sugar_bar.Value + "' WHERE item_name= 'sugar' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
 
        }
        private void buy_selected_eggs_Click(object sender, EventArgs e)
        {
            if (eggs_per.Text == "" || Convert.ToInt32(eggs_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (eggs_bar.Value + (Convert.ToInt32(eggs_per.Text)) <= 100)
            {
                eggs_bar.Value = eggs_bar.Value + Convert.ToInt32(eggs_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + eggs_bar.Value + "' WHERE item_name= 'eggs' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void buy_selected_potato_Click(object sender, EventArgs e)
        {
            if (potato_per.Text == "" || Convert.ToInt32(potato_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (potato_bar.Value + (Convert.ToInt32(potato_per.Text)) <= 100)
            {
                potato_bar.Value = potato_bar.Value + Convert.ToInt32(potato_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + potato_bar.Value + "' WHERE item_name= 'potato' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void buy_selected_totato_Click(object sender, EventArgs e)
        {
            if (tomato_per.Text == "" || Convert.ToInt32(tomato_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (tomato_bar.Value + (Convert.ToInt32(tomato_per.Text)) <= 100)
            {
                tomato_bar.Value = tomato_bar.Value + Convert.ToInt32(tomato_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + tomato_bar.Value + "' WHERE item_name= 'tomato' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void buy_selected_oil_Click(object sender, EventArgs e)
        {
            if (oil_per.Text == "" || Convert.ToInt32(oil_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (oil_bar.Value + (Convert.ToInt32(oil_per.Text)) <= 100)
            {
                oil_bar.Value = oil_bar.Value + Convert.ToInt32(oil_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + oil_bar.Value + "' WHERE item_name= 'oil' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void use_selected_sugar_Click(object sender, EventArgs e)
        {
            if (sugar_per.Text == "" || Convert.ToInt32(sugar_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (Convert.ToInt32(sugar_per.Text) <= sugar_bar.Value)
            {
                sugar_bar.Value = sugar_bar.Value - Convert.ToInt32(sugar_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + sugar_bar.Value + "' WHERE item_name= 'sugar' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void use_selected_eggs_Click(object sender, EventArgs e)
        {
            if (eggs_per.Text == "" || Convert.ToInt32(eggs_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (Convert.ToInt32(eggs_per.Text) <= eggs_bar.Value)
            {
                eggs_bar.Value = eggs_bar.Value - Convert.ToInt32(eggs_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + eggs_bar.Value + "' WHERE item_name= 'eggs' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void use_selected_potato_Click(object sender, EventArgs e)
        {
            if (potato_per.Text == "" || Convert.ToInt32(potato_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (Convert.ToInt32(potato_per.Text) <= potato_bar.Value)
            {
                potato_bar.Value = potato_bar.Value - Convert.ToInt32(potato_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + potato_bar.Value + "' WHERE item_name= 'potato' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void use_selected_tomato_Click(object sender, EventArgs e)
        {
            if (tomato_per.Text == "" || Convert.ToInt32(tomato_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (Convert.ToInt32(tomato_per.Text) <= tomato_bar.Value)
            {
                tomato_bar.Value = tomato_bar.Value - Convert.ToInt32(tomato_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + tomato_bar.Value + "' WHERE item_name= 'tomato' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void use_selected_oil_Click(object sender, EventArgs e)
        {
            if (oil_per.Text == "" || Convert.ToInt32(oil_per.Text) == 0)
            {
                MessageBox.Show("percentage cant be empty or 0");
                return;
            }

            if (Convert.ToInt32(oil_per.Text) <= oil_bar.Value)
            {
                oil_bar.Value = oil_bar.Value - Convert.ToInt32(oil_per.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [Items] SET item_value = '" + oil_bar.Value + "' WHERE item_name= 'oil' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void bt_back_man_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openAfter_mngr_login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }



        private void sugar_per_TextChanged(object sender, EventArgs e)
        {
            if(sugar_per.Text.Length > 2)
            {
                sugar_per.Text = sugar_per.Text.Substring(0, 2);
                sugar_per.SelectionStart = sugar_per.Text.Length;
                sugar_per.SelectionLength = 0;
            }
        }

        private void eggs_per_TextChanged(object sender, EventArgs e)
        {
            if(eggs_per.Text.Length >2)
            {
                eggs_per.Text = eggs_per.Text.Substring(0, 2);
                eggs_per.SelectionStart = eggs_per.Text.Length;
                eggs_per.SelectionLength = 0;
            }
        }

        private void potato_per_TextChanged(object sender, EventArgs e)
        {
            if(potato_per.Text.Length >2)
            {
                potato_per.Text = potato_per.Text.Substring(0, 2);
                potato_per.SelectionStart = potato_per.Text.Length;
                potato_per.SelectionLength  = 0;
            }
        }

        private void tomato_per_TextChanged(object sender, EventArgs e)
        {
            if(tomato_per.Text.Length >2)
            {
                tomato_per.Text = tomato_per.Text.Substring(0, 2);
                tomato_per.SelectionStart = tomato_per.Text.Length;
                tomato_per.SelectionLength = 0;
            }
        }

        private void oil_per_TextChanged(object sender, EventArgs e)
        {
            if(oil_per.Text.Length >2)
            {
                oil_per.Text = oil_per.Text.Substring(0, 2);
                oil_per.SelectionStart = oil_per.Text.Length;
                oil_per.SelectionLength = 0;
            }
        }

        private void sugar_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            
        }

        private void eggs_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void potato_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tomato_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void oil_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
