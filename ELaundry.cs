using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELaundry
{
    public partial class ELaundry : Form
    {
        public ELaundry()
        {
            InitializeComponent();
            logoimage.Paint += logoimage_Paint;
            logoimage.Image = Properties.Resources.Screenshot_2023_11_12_091128;
        }

        private void ELaundry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void services_Click(object sender, EventArgs e)
        {

        }

        private void services_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void HomepageText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pickUps_Click(object sender, EventArgs e)
        {
            pickUp pickLaundry = new pickUp();
            pickLaundry.Show();
        }

        private void Subscription_Click(object sender, EventArgs e)
        {
            subscription sub = new subscription();
            sub.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoimage_Click(object sender, EventArgs e)
        {
            
        }
        private void logoimage_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, logoimage.Width - 1, logoimage.Height - 1);
                Region region = new Region(path);
                logoimage.Region = region;
            }
        }
        private void rewards_Click(object sender, EventArgs e)
        {
            about_us about = new about_us();
            about.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
