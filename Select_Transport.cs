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
   
    public partial class Select_Transport : Form
    {
        string Transport;
        public Select_Transport()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_DashBoard().Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Airplane";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Bus";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Transport = "Train";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Transport(Transport)values('" + Transport + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transport Added Successfully!!!");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
