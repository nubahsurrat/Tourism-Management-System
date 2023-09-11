using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency_Project
{
    public partial class Admin_DashBoard : Form
    {
        public Admin_DashBoard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_FeedBack().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewUserDetails().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddTourPackage().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Booking_Details().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Package_Details().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
