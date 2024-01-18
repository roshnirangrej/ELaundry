using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ELaundry
{
    public class services
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
    public partial class Services : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "YoOcIWZwX7T6yTzIzVKstlRjtdOZvxQq6utmpDpB",
            BasePath = "https://elaundry-426d3-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public Services()
        {
            InitializeComponent();
            pictureBox1.Paint += logoimage_Paint;
            pictureBox1.Image = Properties.Resources.Screenshot_2023_11_12_091128;
        }

        private void Services_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        
        private async void button1_Click(object sender, EventArgs e)
        {
            string searchedData = txtSearch.Text.ToLower();

            // Instead of using SqlConnection, retrieve data from Firebase
            var firebaseResponse = await client.GetAsync($"Services");
            if (firebaseResponse != null && firebaseResponse.ResultAs<dynamic>() != null) // Check if data exists for the searched term.
            {
                var services = firebaseResponse.ResultAs<Dictionary<string, dynamic>>();
                
                // Perform a case-insensitive search for the name
                var matchingService = services.FirstOrDefault(name =>
                    name.Key.ToLower() == searchedData);
               

                if (matchingService.Key != null)
                {
                    //MessageBox.Show($"Service '{matchingService.Key}' found in Firebase database");
                    // Display or process the retrieved service data as needed
                    DisplayServiceInformation(matchingService.Value);
                }
            }
            else
            {
                MessageBox.Show("no service found");
            }
           

                /*string query = "SELECT * FROM services WHERE service LIKE @searchedData";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection)) 
                    {
                        command.Parameters.AddWithValue("@searchedData", "%" + searchedData + "%");
                        try
                        {
                            connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            p.Controls.Clear();
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Sorry! No matching records found.");
                                return;
                            }
                            foreach (DataRow row in dataTable.Rows)
                            {


                                Label Service = new Label();
                                Service.Text = "Service: " + row["service"].ToString();
                                Service.Location = new Point(10, 10);
                                Service.AutoSize = true;
                                Service.Font = new Font("times new roman", 12);

                                Label Price = new Label();
                                Price.Text = "Price: " + row["price"].ToString();
                                Price.Location = new Point(10, 40);
                                Price.AutoSize = true;
                                Price.Font = new Font("times new roman", 12);

                                Panel panel = new Panel();
                                panel.BorderStyle = BorderStyle.FixedSingle;
                                panel.Padding = new Padding(5);
                                panel.BackColor = Color.Thistle;



                                string descriptionFromDatabase = row["description"].ToString();


                                string[] sentences = descriptionFromDatabase.Split('.');


                                string formattedDescription = string.Join(Environment.NewLine, sentences);

                                Label Description = new Label();
                                Description.Text = "Description: \n" + formattedDescription; 
                                Description.Location = new Point(10, 70);
                                Description.AutoSize = true;
                                Description.Font = new Font("Times New Roman", 12);



                                panel.Controls.Add(Service);
                                panel.Controls.Add(Price);
                                panel.Controls.Add(Description);
                                panel.Height = 200;
                                panel.Width = 900;


                                p.Controls.Add(panel);
                                p.Controls.Add(new Panel() { Height = 911 });

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

                    }
                }*/


        }
        private void DisplayServiceInformation(dynamic matchingService)
        {
            Label serviceNameLabel = new Label();
            serviceNameLabel.Text = "Service Name: " + matchingService.name;
            serviceNameLabel.Location = new Point(10, 10);
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Font = new Font("times new roman", 12);

            Label priceLabel = new Label();
            priceLabel.Text = "Price: " + matchingService.price.ToString();
            priceLabel.Location = new Point(10, 40);
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("times new roman", 12);

            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Padding = new Padding(5);
            panel.BackColor = Color.Thistle;

            string descriptionFromDatabase = matchingService.description.ToString();
            string[] sentences = descriptionFromDatabase.Split('.');
            string formattedDescription = string.Join(Environment.NewLine, sentences);

            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Description: " + formattedDescription;
            descriptionLabel.Location = new Point(10, 70);
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Times New Roman", 12);

            panel.Controls.Add(serviceNameLabel);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(descriptionLabel);
            panel.Height = 200;
            panel.Width = 900;

            p.Controls.Clear();
            p.Controls.Add(panel);
            p.Controls.Add(new Panel() { Height = 911 });
        }



        private void HomepageText_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchText_Click(object sender, EventArgs e)
        {

        }

        private void ServiceName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void logoimage_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
                Region region = new Region(path);
                pictureBox1.Region = region;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
