using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ELaundry
{
    
    public partial class gettingStarted : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "YoOcIWZwX7T6yTzIzVKstlRjtdOZvxQq6utmpDpB",
            BasePath = "https://elaundry-426d3-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        //string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public gettingStarted()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            client = new FireSharp.FirebaseClient(config);
        }

        private string Hashing(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void gettingStarted_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string ConfirmPassword = textBox3.Text;


            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
       string.IsNullOrWhiteSpace(textBox2.Text) ||
       string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            if (password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                return;
            }

            string hashedPassword = Hashing(password);


            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Authentication (username, password) VALUES (@username, @hashedPassword)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                        this.Hide();
                        login Log = new login();
                        Log.Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }*/
            SetResponse response = await client.SetAsync($"Authentication/{username}", new
            {
                Password = hashedPassword,
                Username = username
            }

                ) ;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Data stored in Firebase!");
            }
            else
            {
                MessageBox.Show($"Failed to store data in Firebase. Status code: {response.StatusCode}");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login Log = new login();
            Log.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0'; 
            }
            else
            {
                textBox2.PasswordChar = '*'; 
                textBox3.PasswordChar = '*';
            }
        }
        
    }
}
