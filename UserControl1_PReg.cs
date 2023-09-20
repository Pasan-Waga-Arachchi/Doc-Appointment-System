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

        //SQL Connection
        private SqlConnection connectDB()
        {
            string connectionString;
            SqlConnection cnn;
            cnn = DatabaseConnection.Instance.GetConnection();
            return cnn;
        }

        //Add button 
        private void RegAdd_Click(object sender, EventArgs e)
        {
            String pid = txtPID.Text;
            String name = txtName.Text;
            String address = txtAddress.Text;
            String gender = "";
            String food = "";
            String drug = "";
            String plaster = "";
            int age = Convert.ToInt32(txtAge.Text);
            Int64 contact = Convert.ToInt64(txtContact.Text);
            String blood = txtBlood.Text;
            Int64 emergency = Convert.ToInt64(txtEmergency.Text);


            if (radioMale.Checked)
            {
                gender = "Male";
            }else
            {
                gender = "Female";
            }

            if (checkBoxFood.Checked)
            {
                food = "Yes";
            } else
            {
                food = "No";
            }

            if (checkBoxDrug.Checked)
            {
                drug = "Yes";
            }else
            {
                drug = "No";
            }

            if (checkBoxPlaster.Checked)
            {
                plaster = "Yes";
            }else
            {
                plaster = "No";
            }


            SqlConnection cnn;
            cnn = connectDB();
            SqlCommand command;

            String sql = "";

            sql = "Insert into Patient values('" + pid + "','" + name + "','" + address + "','" + age + "','" + gender + "','" + contact + "','" + blood + "','" + emergency + "','" + food + "','" + drug + "','" + plaster + "')";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
            cnn.Close();
            ClearTextBoxes(this);
        }

        //close function
        private void RegClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormController regcontroller = FormController.Instance; ;
            regcontroller.hideAllUserControllers();
            Control pcontroller = regcontroller.getUserControll("userControl1_Patients1");
            pcontroller.Show();
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }


                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }


        private void RegReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
