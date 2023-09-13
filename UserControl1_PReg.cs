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
    public partial class UserControl1_PReg : UserControl
    {
        public UserControl1_PReg()
        {
            InitializeComponent();
        }
        private SqlConnection connectDB()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=IMASHINETHMINI;Initial Catalog=Patient;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //MessageBox.Show("Connected");
            return cnn;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_PReg_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
           // userControl1_Patients1.Show();
           this.Hide();
           FormController regcontroller = FormController.Instance; ;
            regcontroller.hideAllUserControllers();
            Control pcontroller = regcontroller.getUserControll("userControl1_Patients1");
            pcontroller.Show();

        }

        private void RegReset_Click(object sender, EventArgs e)
        {

        }

        private void RegAdd_Click(object sender, EventArgs e)
        {
            int pid=Convert.ToInt32(txtPID.Text);
            String name=txtName.Text;
            String address=txtAddress.Text;
            String gender = "";
            String dob = Convert.ToDateTime(txtDOB.Text).ToString("dd-MM-yyyy");
            String food = "";
            String drug = "";
            String plaster = "";
            int age =Convert.ToInt32(txtAge.Text);
            Int64 contact=Convert.ToInt64(txtContact.Text);
            String blood=txtBlood.Text;
            Int64 emergency = Convert.ToInt64(txtEmergency.Text);
         

            if(radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if(checkBoxFood.Checked)
            {
                food = "Yes";
            }
            else
            {
                food = "No";
            }

            if (checkBoxDrug.Checked)
            {
                drug = "Yes";
            }
            else
            {
                drug = "No";
            }

            if (checkBoxPlaster.Checked)
            {
                plaster = "Yes";
            }
            else
            {
                plaster = "No";
            }


            SqlConnection cnn;
            cnn = connectDB();
            SqlCommand command;

            String sql = "";

            sql = "Insert into Patient values('" + pid+ "','"+name+ "','"+address+ "','"+dob+ "','"+age+ "','"+gender+ "','"+contact+ "','"+blood+ "','"+emergency+ "','"+food+ "','"+drug+"','"+plaster+"')";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
            cnn.Close();

            

            

        }
    }
}
