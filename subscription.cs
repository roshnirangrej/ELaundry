using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ELaundry
{
    public partial class subscription : Form
    {
        public subscription()
        {
            InitializeComponent();
        }

        private void subscription_Load(object sender, EventArgs e)
        {

        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenEmailForm("Silver","15 days",999m, "Get laundry benefits worth 1,100 for a period of 15 days.");
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            OpenEmailForm("Gold", "30 days", 2999m, "Get laundry benefits worth 3,300 for a period of 30 days.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenEmailForm("Platinum", "60 days", 4999m, "Get laundry benefits worth 5,500 for a period of 60 days.");
        }
        private void OpenEmailForm(string plan, string validity,decimal cost,string description)
        {
            email emailconfirmation = new email(plan,validity,cost,description);
            emailconfirmation.Show();
        }

        private void label46_Click(object sender, EventArgs e)
        {

        }
    }
}
