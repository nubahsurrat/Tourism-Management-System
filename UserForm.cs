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

namespace Travel_Agency_Project
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Password")
                Pass.Text = null;
            Pass.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
                Pass.Text = "Password";
            Pass.ForeColor = Color.DarkGray;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new UserRegistration().Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        string Conn = ("Data Source= DESKTOP-JUD9HDI;");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True");
            string query = "Select * from UserRegTable where UserName = '"+User.Text.Trim()+"' and UserPass = '"+Pass.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                User_DashBoard ad = new User_DashBoard();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Your User Name and Password.!!!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
