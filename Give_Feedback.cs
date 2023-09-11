using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency_Project
{
    public partial class Give_Feedback : Form
    {
        string satisfied_level;
        public Give_Feedback()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            satisfied_level = "Very Satisfied";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            satisfied_level = "Satisfied";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            satisfied_level = "Neutral";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            satisfied_level = "Unsatisfied";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            satisfied_level = "Very Unsatisfied";
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Feedback(Satisfied_level, Improvement)values('" + satisfied_level + "', '" + textBox1.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanks For Your Feedback!!!");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_DashBoard().Show();
        }
    }
}
