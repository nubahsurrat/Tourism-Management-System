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
    public partial class User_DashBoard : Form
    {
        public User_DashBoard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Select_Your_Package_Tour().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Select_Transport().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Select_Hotel().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserForm().Show();
        }

        private void User_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Give_Feedback().Show();
        }
    }
}
