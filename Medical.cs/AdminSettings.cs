using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical.cs
{
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the database
            string connectionString = "server=localhost;user id=root;password=samia;database=resasoins";

            // Retrieve data from the text boxes
            string userId = IdtextBox.Text;
            string name = NametextBox.Text;
            string email = EmailtextBox.Text;
            string password = MdptextBox.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO users (UserId, Name, Email, Password) VALUES (@UserId, @Name, @Email, @Password)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command to prevent SQL injection
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            UserAdded newForm = new UserAdded();
                            newForm.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

