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
    public partial class AddTourPackage : Form
    {
        public string conString = "Data Source=DESKTOP-JUD9HDI;Initial Catalog=Travel_Agency;Integrated Security=True";
        public AddTourPackage()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (PackageID.Text == "" || AddPlace.Text == "" || NumOfAdults.Text == "" || NumOfChild.Text == "" || StayAmount.Text == "" || FoodAmount.Text == "" || BusAmount.Text == "" || TrainAmount.Text == "" || AirlinesAmount.Text == "" || NumOfDayscomboBox.Text == "" || NumOfNightscomboBox.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if(con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into AddTourPackageProduct(PackageID, AddPlace, NumOfAdult, NumOfChild, StayAmount, FoodAmount, BusAmount, TrainAmount, AirlinesAmount, NumOfDays, NumOfNights) values('" + PackageID.Text + "','" + AddPlace.Text + "','" + NumOfAdults.Text + "','" + NumOfChild.Text + "','" + StayAmount.Text + "','" + FoodAmount.Text + "','" + BusAmount.Text + "','" + TrainAmount.Text + "','" + AirlinesAmount.Text + "','" + NumOfDayscomboBox.Text + "','" + NumOfNightscomboBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted!!!!");
                }
            }
        }
        private void AddTourPackage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_DashBoard ad = new Admin_DashBoard();
            ad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PackageID.Text = "";
            AddPlace.Text = "";
            NumOfAdults.Text = "";
            NumOfChild.Text = "";
            StayAmount.Text = "";
            FoodAmount.Text = "";
            BusAmount.Text = "";
            TrainAmount.Text = "";
            AirlinesAmount.Text = "";
            NumOfDayscomboBox.Text = "";
            NumOfNightscomboBox.Text = "";
        }
    }
}
