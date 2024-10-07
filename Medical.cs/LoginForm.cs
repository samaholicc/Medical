using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical.cs
{


    public partial class LoginForm : Form
    {
        private string connectionString = "server=localhost;database=resasoins;uid=root;pwd=samia;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(IdTextBox.Text, MdpTextBox.Text))
            {
                MessageBox.Show("Login successful!");

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }



        private bool Login(string username, string password)
        {
            string Username = IdTextBox.Text;


            string Password = MdpTextBox.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))

            {

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE UserId = @Username AND Password = @Password", conn);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true){
                MdpTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                MdpTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
