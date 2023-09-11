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
    public partial class Select_Hotel : Form
    {
        string Hotel;
        public Select_Hotel()
        {
            InitializeComponent();
        }

        private void Select_Hotel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_DashBoard().Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Hotel = "Single Room";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Hotel = "Double Delux Room";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Hotel = "Family Suit Room";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Select_Hotel_and_checkINOUT(Select_Hotel,Check_in,Check_out)values('" + Hotel+ "', '" +dateTimePicker1.Value.ToString()+ "','" +dateTimePicker2.Value.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hotel Added Successfully!!!");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
