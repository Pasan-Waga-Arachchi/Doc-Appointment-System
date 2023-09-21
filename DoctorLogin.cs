using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace RAD_Project
{
    public partial class DoctorLogin : UserControl
    {

        //private string connectionString = @"Data Source=LAPTOP-5CPQSKO6;Initial Catalog=LOGIN;Integrated Security=True";
       // using(SqlConnection con = new SqlConnection(connectionString)) ;
        public DoctorLogin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //con.Open();
            SqlConnection con = DatabaseConnection.Instance.GetConnection();
            string query = "SELECT * FROM doctor_login WHERE user_name=@userName AND password=@password";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@userName", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    FormController controller = FormController.Instance;
                    controller.hideAllUserControllers();
                    Control userpat = controller.getUserControll("userControl1_Time3");
                    userpat.Show();
                    controller.UserType = "Doctor";
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
            Control userlog = controller.getUserControll("UserControl1_Login1");
            userlog.Show();
        }
    }

    
}
