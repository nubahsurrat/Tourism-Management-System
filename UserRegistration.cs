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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
                textBox7.Text = "User ID";
            textBox7.ForeColor = Color.DarkGray;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "User ID")
                textBox7.Text = null;
            textBox7.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "User Name";
            textBox1.ForeColor = Color.DarkGray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
                textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                textBox6.Text = "User Password";
            textBox6.ForeColor = Color.DarkGray;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "User Password")
                textBox6.Text = null;
            textBox6.ForeColor = Color.Black;
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
                textBox8.Text = "User Mobile Number";
            textBox8.ForeColor = Color.DarkGray;
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "User Mobile Number")
                textBox8.Text = null;
            textBox8.ForeColor = Color.Black;
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
                textBox9.Text = "User Email ID";
            textBox9.ForeColor = Color.DarkGray;
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "User Email ID")
                textBox9.Text = null;
            textBox9.ForeColor = Color.Black;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox1.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserRegTable values(" + textBox7.Text + ",'" + textBox1.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Registration Successfully!!!");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
