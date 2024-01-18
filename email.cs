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
using System.Net;
using System.Net.Mail;
using System.IO;


namespace ELaundry
{
    public partial class email : Form
    {
        
        private string plan;
        private string validity;
        private decimal cost;
        private string description;

        public email(string plan, string validity,decimal cost,string description)
        {
            InitializeComponent();
            //pictureBox1.Paint += pictureBox1_Paint;
            //pictureBox1.Image = Properties.Resources.pexels_engin_akyurt_6492065__1_;
            this.plan = plan;
            this.validity = validity;
            this.cost = cost;
            this.description = description;
        }

        private void email_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mm = new MailMessage("rangrejroshni11@gmail.com", emailTextBox.Text.Trim());
            mm.Subject = " Confirmation: Successful Subscription to Laundry Service";
            mm.Body = "Dear Customer,\r\n\r\n " +
                      "Thank you for choosing E Laundry for your laundry needs! We're thrilled to confirm that your subscription has been successfully activated.\r\n\r\n" +
                      "Here are the key details of your subscription:\r\n\r\n" +
                      $"Subscription Plan:{plan}\r\n" +
                      $"Validity:{validity}\r\n" +
                      $"Cost: {cost}\r\n" +
                      $"Description: {description}\r\n" +
                      "You can expect our team to start servicing your laundry as per the agreed schedule. We pride ourselves on delivering high-quality service and ensuring your garments are handled with the utmost care.\r\n\r\n" +
                      "If you have any specific preferences or special instructions for your laundry, please don't hesitate to let us know. Our team is dedicated to accommodating your needs and ensuring your complete satisfaction.\r\n\r\n" +
                      "Thank you again for choosing E Laundry. We look forward to providing you with excellent service and making your laundry experience convenient and hassle-free.\r\n\r\n" +
                      "Best Regards,\r\n\r\n" +
                      "E Laundry\r\n" ;

            

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential credential = new NetworkCredential("rangrejroshni11@gmail.com", "xhoz dsbq fnwe lxnp");
            smtp.EnableSsl = true;
            smtp.Credentials = credential;
            smtp.Send(mm);
           // linkLabel1.Text = "Mail has been sent successfully" + emailTextBox.Text;
 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
;