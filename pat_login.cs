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

namespace RAD_Project
{
    public partial class pat_login : UserControl
    {
       // private string connectionString = @"Data Source=LAPTOP-5CPQSKO6;Initial Catalog=LOGIN;Integrated Security=True";

        public pat_login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control reg1 = controller.getUserControll("patRegistrstion1");
            reg1.Show();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            // using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //con.Open();
            SqlConnection con = DatabaseConnection.Instance.GetConnection();
            string query = "SELECT * FROM patient_login WHERE user_name=@userName AND pasword=@password";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@userName", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    FormController controller = FormController.Instance;
                    controller.hideAllUserControllers();
                    Control reg2 = controller.getUserControll("UserControl1_Channel1");
                    reg2.Show();
                    controller.UserType = "Patient";
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            //}
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control reg3 = controller.getUserControll("UserControl1_Login1");
            reg3.Show();
        }
    }
}
