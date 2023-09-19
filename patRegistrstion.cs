using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RAD_Project
{
    public partial class patRegistrstion : UserControl

    {
        private string connectionString = @"Data Source=LAPTOP-5CPQSKO6;Initial Catalog=LOGIN;Integrated Security=True";
        public patRegistrstion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string userName = textBox2.Text;
                string password = textBox3.Text;
                string email = textBox1.Text;

                if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(email))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO patient (user_name, pasword,email) VALUES (@userName, @password,@email)";
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User data inserted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert user data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }

                        FormController controller = FormController.Instance;
                        controller.hideAllUserControllers();
                        Control reg = controller.getUserControll("pat_login1");
                        reg.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        
            

        private void button2_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control reg = controller.getUserControll("pat_login1");
            reg.Show();
        }
    }
}
