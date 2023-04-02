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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void buy_all_sugar_Click(object sender, EventArgs e)
        {
            sugar_bar.Value = 100;
        }

        private void buy_all_eggs_Click(object sender, EventArgs e)
        {
            eggs_bar.Value = 100;
        }

        private void buy_all_potato_Click(object sender, EventArgs e)
        {
            potato_bar.Value = 100;
        }

        private void buy_all_tomato_Click(object sender, EventArgs e)
        {
            tomato_bar.Value = 100;
        }

        private void buy_all_oil_Click(object sender, EventArgs e)
        {
            oil_bar.Value = 100;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buy_selected_sugar_Click(object sender, EventArgs e)
        {
            if (sugar_bar.Value + (Convert.ToInt32(sugar_per.Text)) <= 100)
            {
                sugar_bar.Value = sugar_bar.Value + Convert.ToInt32(sugar_per.Text);
            }
        }
        private void buy_selected_eggs_Click(object sender, EventArgs e)
        {
            if (eggs_bar.Value + (Convert.ToInt32(eggs_per.Text)) <= 100)
            {
                eggs_bar.Value = eggs_bar.Value + Convert.ToInt32(eggs_per.Text);
            }
        }

        private void buy_selected_potato_Click(object sender, EventArgs e)
        {
            if (potato_bar.Value + (Convert.ToInt32(potato_per.Text)) <= 100)
            {
                potato_bar.Value = potato_bar.Value + Convert.ToInt32(potato_per.Text);
            }
        }

        private void buy_selected_totato_Click(object sender, EventArgs e)
        {
            if (tomato_bar.Value + (Convert.ToInt32(tomato_per.Text)) <= 100)
            {
                tomato_bar.Value = tomato_bar.Value + Convert.ToInt32(tomato_per.Text);
            }
        }

        private void buy_selected_oil_Click(object sender, EventArgs e)
        {
            if (oil_bar.Value + (Convert.ToInt32(oil_per.Text)) <= 100)
            {
                oil_bar.Value = oil_bar.Value + Convert.ToInt32(oil_per.Text);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
