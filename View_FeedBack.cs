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
    public partial class View_FeedBack : Form
    {
        public View_FeedBack()
        {
            InitializeComponent();
        }

        private void View_FeedBack_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travel_AgencyDataSet3.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.travel_AgencyDataSet3.Feedback);

        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;


            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);

            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));


            dataGridView1.Height = height;

            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_DashBoard().Show();
        }
    }
}
