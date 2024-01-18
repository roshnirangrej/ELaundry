using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace ELaundry
{
    public partial class login : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "YoOcIWZwX7T6yTzIzVKstlRjtdOZvxQq6utmpDpB",
            BasePath = "https://elaundry-426d3-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        
        public login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
         
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
        private void login_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
        //string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private async void button1_Click(object sender, EventArgs e)
        {
            string enteredusername = textBox1.Text;
            string enteredpassword = textBox2.Text;

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }


            string hashedenteredPassword = Hashing(enteredpassword);
            string storedHashedPassword = "";

           /* using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT password FROM Authentication WHERE username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", enteredusername);
                   
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                storedHashedPassword = reader["password"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }*/

            // Instead of using SqlConnection, retrieve data from Firebase
            var firebaseResponse = await client.GetAsync($"Authentication/{enteredusername}");
            if (firebaseResponse != null && firebaseResponse.ResultAs<dynamic>() != null) // Check if data exists for the given username
            {
                var firebaseData = firebaseResponse.ResultAs<dynamic>();
                storedHashedPassword = firebaseData.Password;

                //MessageBox.Show("user found in firebase database");
                if (storedHashedPassword == hashedenteredPassword)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    ELaundry laundry = new ELaundry();
                    laundry.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }
            else
            {
                MessageBox.Show("User not found. Please check your credentials.");
                return; // Add this return statement to exit the method if user not found
            }


            /*if (storedHashedPassword == hashedenteredPassword)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                ELaundry laundry = new ELaundry();
                laundry.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                
            }
            else
            {
                textBox2.PasswordChar = '*';
               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            gettingStarted register = new gettingStarted();
            register.Show();
        }
    }
    }

