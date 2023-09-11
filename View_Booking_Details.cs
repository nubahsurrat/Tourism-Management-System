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
    public partial class View_Booking_Details : Form
    {
        public View_Booking_Details()
        {
            InitializeComponent();
        }

        private void View_Booking_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travel_AgencyDataSet2.Transport' table. You can move, or remove it, as needed.
            this.transportTableAdapter.Fill(this.travel_AgencyDataSet2.Transport);
            // TODO: This line of code loads data into the 'travel_AgencyDataSet1.Select_Hotel_and_checkINOUT' table. You can move, or remove it, as needed.
            this.select_Hotel_and_checkINOUTTableAdapter.Fill(this.travel_AgencyDataSet1.Select_Hotel_and_checkINOUT);
            // TODO: This line of code loads data into the 'travel_AgencyDataSet.ViewBookingDetails' table. You can move, or remove it, as needed.
            this.viewBookingDetailsTableAdapter.Fill(this.travel_AgencyDataSet.ViewBookingDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_DashBoard().Show();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;


            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);

            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));


            dataGridView1.Height = height;

            printPreviewDialog1.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int height = dataGridView2.Height;


            bmp = new Bitmap(dataGridView2.Width, dataGridView2.Height);

            dataGridView2.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView2.Width, dataGridView2.Height));


            dataGridView2.Height = height;

            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int height = dataGridView3.Height;


            bmp = new Bitmap(dataGridView3.Width, dataGridView3.Height);

            dataGridView3.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView3.Width, dataGridView3.Height));


            dataGridView3.Height = height;

            printPreviewDialog3.ShowDialog();
        }
    }
}
