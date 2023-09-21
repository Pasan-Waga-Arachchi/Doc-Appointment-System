using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RAD_Project
{
    public partial class UserControl1AboutUs : UserControl
    {
        public UserControl1AboutUs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control aboutUsController = controller.getUserControll("userControl1_Test1");
            aboutUsController.Show();*/


            SqlConnection connection=DatabaseConnection.Instance.GetConnection();
            connection.Open();
            string sql = "select * from Doctor";
            SqlCommand cmd = new SqlCommand(sql, connection);

            //when usin select query
            SqlDataReader reader=cmd.ExecuteReader();
            string result = "";
            while (reader.Read())
            {
                result += reader.GetString(1) + "\n";

            }

            textBox1.Text = result;
            cmd.Dispose();
            connection.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //When other than select query
            SqlConnection connection = DatabaseConnection.Instance.GetConnection();
            connection.Open();
            string sql = "Insert into Doctor values(3,'SSS','male','2022-09-9','sda',12,'saaa','ggg',123)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, connection);
            int noOfAffectedRows = adapter.InsertCommand.ExecuteNonQuery();
            textBox2.Text = noOfAffectedRows.ToString();
            connection.Close();
        }
    }
}