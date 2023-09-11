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
    public partial class View_Package_Details : Form
    {
        int index;
        public View_Package_Details()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void View_Package_Details_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_DashBoard ad = new Admin_DashBoard();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PackageID.Text=="")
            {
                MessageBox.Show("Enter Package ID to Delete!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from AddTourPackageProduct where PackageID =" + PackageID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tour Package Deleted Successfully");
                    Con.Close();
                } catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = PackageID.Text;
            newdata.Cells[1].Value = AddPlace.Text;
            newdata.Cells[4].Value = StayAmount.Text;
            newdata.Cells[9].Value = NumOfDayscomboBox.SelectedItem;
            newdata.Cells[10].Value = NumOfNightscomboBox.SelectedItem;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PackageID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            AddPlace.Text = dataGridView1.SelectedRows[1].Cells[1].Value.ToString();
            StayAmount.Text = dataGridView1.SelectedRows[2].Cells[2].Value.ToString();
            NumOfDayscomboBox.SelectedItem = dataGridView1.SelectedRows[3].Cells[3].Value.ToString();
            NumOfNightscomboBox.SelectedItem = dataGridView1.SelectedRows[4].Cells[4].Value.ToString();
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
        }
    }
}
