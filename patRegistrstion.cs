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
        //private string connectionString = @"Data Source=LAPTOP-5CPQSKO6;Initial Catalog=LOGIN;Integrated Security=True";
        public patRegistrstion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string userName = textBox3.Text;
                string password = textBox4.Text;
                string email = textBox2.Text;



                //using (SqlConnection con = new SqlConnection(connectionString))
                // {
                //   con.Open();
                SqlConnection con = DatabaseConnection.Instance.GetConnection();
                        string query = "INSERT INTO patient_login (user_name, pasword,email) VALUES (@userName, @password,@email)";
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User data inserted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormController controller = FormController.Instance;
                            controller.hideAllUserControllers();
                            Control reg = controller.getUserControll("pat_login1");
                            reg.Show();
                            clearData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert user data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                  //  }
                
               
            }

               
        }
        public void clearData()
        {
            textBox4.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        
            

        private void button2_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control reg = controller.getUserControll("pat_login1");
            reg.Show();
            clearData();
        }
    }
}
