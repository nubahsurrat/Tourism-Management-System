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
    public partial class Select_Your_Package_Tour : Form
    {
        int index;
        string Fooditem;
        public Select_Your_Package_Tour()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from AddTourPackageProduct";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            Con.Close();
        }

        private void Select_Your_Package_Tour_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            PackageID.Text = row.Cells[0].Value.ToString();
            AddPlace.Text = row.Cells[1].Value.ToString();
            StayAmount.Text = row.Cells[4].Value.ToString();
            NumOfDayscomboBox.SelectedItem = row.Cells[9].Value.ToString();
            NumOfNightscomboBox.SelectedItem = row.Cells[10].Value.ToString();
            TotalCost.Text = row.Cells[11].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User_DashBoard().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ViewBookingDetails values(" + PackageID.Text + ",'" + AddPlace.Text + "','" + NumOfDayscomboBox.Text + "','" + NumOfNightscomboBox.Text + "','" + StayAmount.Text + "', '" + Fooditem + "', '"+TotalCost.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paid Successfully!!!");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Fooditem = "Yes";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Fooditem = "No";
        }
    }
}
