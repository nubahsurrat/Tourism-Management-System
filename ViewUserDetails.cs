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

    public partial class ViewUserDetails : Form
    {
        int index;
        public ViewUserDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_DashBoard ad = new Admin_DashBoard();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "")
            {
                MessageBox.Show("Enter User ID to Delete!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from UserRegTable where UserID =" + UserID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Registration Deleted Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from UserRegTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            Con.Close();
        }

        private void ViewUserDetails_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            UserID.Text = row.Cells[0].Value.ToString();
            UserName.Text = row.Cells[1].Value.ToString();
            UserMoNum.Text = row.Cells[3].Value.ToString();
            UserEmailID.Text = row.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = UserID.Text;
            newdata.Cells[1].Value = UserName.Text;
            newdata.Cells[3].Value = UserMoNum.Text;
            newdata.Cells[4].Value = UserEmailID.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            UserName.Text = dataGridView1.SelectedRows[1].Cells[0].Value.ToString();
            UserMoNum.Text = dataGridView1.SelectedRows[3].Cells[0].Value.ToString();
            UserEmailID.Text = dataGridView1.SelectedRows[4].Cells[0].Value.ToString();
        }
    }
}
