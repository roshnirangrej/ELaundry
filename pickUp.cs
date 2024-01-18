using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELaundry
{
    public partial class pickUp : Form
    {

        private decimal price;
        public pickUp()
        {
            InitializeComponent();
        }

        private decimal CalculatePrice(string service, int quantity)
        {

            decimal Wash = 50.0m;
            decimal Iron = 70.0m;
            decimal Dry = 30.0m;
            decimal DryCleaning = 300.0m;
            decimal Strach = 100.0m;
            decimal Colouring = 200.0m;
            decimal SofaWash = 2000.0m;
            decimal CarpetWash = 2500.0m;



            switch (service)
            {
                case "Normal Wash":
                    price = Wash * quantity;
                    break;
                case "Iron":
                    price = Iron * quantity;
                    break;
                case "Drying":
                    price = Dry * quantity;
                    break;
                case "Strach":
                    price = Strach * quantity;
                    break;
                case "Dry cleaning":
                    price = DryCleaning * quantity;
                    break;
                case "Colouring":
                    price = Colouring * quantity;
                    break;
                case "Sofa Wash":
                    price = SofaWash * quantity;
                    break;
                case "Carpet Wash":
                    price = CarpetWash * quantity;
                    break;

            }
            return price;
        }
        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string input = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {

                MessageBox.Show("Quantity field can't be empty.");
                textBox1.Focus();
                return;
            }

            if (!Regex.IsMatch(input, @"^\d*$"))
            {
                MessageBox.Show("Please enter a valid quantity (numeric value only).");
                textBox4.Focus();
                return;
            }
        }

        private void pickUp_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox6.Text) ||
        string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                richTextBox1.Clear();
                richTextBox1.Text += "***********************************************\n";
                richTextBox1.Text += "**********         Your Total         *********\n";
                richTextBox1.Text += "***********************************************\n\n";
                richTextBox1.Text += "Date : " + DateTime.Now + "\n\n";



                richTextBox1.Text += "selected Service :" + comboBox1.Text + "\n\n";
                richTextBox1.Text += "Quantity :" + textBox4.Text + "\n\n";

                decimal price = CalculatePrice(comboBox1.Text, Convert.ToInt32(textBox4.Text));
                richTextBox1.Text += "Price: " + price.ToString("C") + "\n\n";


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Bitmap bitmap = Properties.Resources.Screenshot_2023_11_13_090909;
            Image image = bitmap;
            Rectangle destRect = new Rectangle(100, 80, 150, 100);
            e.Graphics.DrawImage(image, destRect);
            e.Graphics.DrawString("E Laundry Services", new Font("Times new roman", 20, FontStyle.Bold), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString("Receipt generated at : " + DateTime.Now, new Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, new Point(150, 250));
            e.Graphics.DrawString("Name : " + textBox1.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 300));
            e.Graphics.DrawString("Contact Number :" + textBox2.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 350));
            e.Graphics.DrawString("selected Service :" + comboBox1.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 400));
            e.Graphics.DrawString("Quantity :" + textBox4.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 450));
            e.Graphics.DrawString("Additional Requirement :" + textBox5.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 500));
            e.Graphics.DrawString("Address :" + textBox6.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 550));
            e.Graphics.DrawString("Pick-Up Date :" + dateTimePicker1.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 600));
            e.Graphics.DrawString("Time :" + comboBox2.Text, new Font("Times new roman", 14, FontStyle.Regular), Brushes.Black, new Point(150, 650));
            e.Graphics.DrawString("Price :" + price.ToString("C"), new Font("Times new roman", 16, FontStyle.Bold), Brushes.Black, new Point(150, 750));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {

                MessageBox.Show("Please enter a valid name.");
                textBox1.Focus();
                return;
            }

            if (!Regex.IsMatch(name, "^(\\b[A-Za-z]*\\b(\\s+\\b[A-Za-z]*\\b)*(\\.[A-Za-z])?)$"))
            {

                MessageBox.Show("Please enter a valid name without numbers or special characters.");
                textBox1.Focus();
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {

                MessageBox.Show("Contact number cannot be empty.");
                textBox2.Focus();

                return;
            }
            
            
            
            if (Regex.IsMatch(phoneNumber, "^(\\d{11})$"))
            {
                if (!Regex.IsMatch(phoneNumber, "^\\d*$"))
                {
                    MessageBox.Show("numeric value only)");
                  
                }
                else
                {
                    MessageBox.Show("Only enter 10 digits");
                  
                }
                textBox2.Focus();
                return;

            }



        }
       

    }
}
