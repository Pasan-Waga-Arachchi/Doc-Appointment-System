using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections;
using TextBox = System.Windows.Forms.TextBox;

namespace RAD_Project
{
    public partial class UserControl1_PInfo : UserControl
    {
        public UserControl1_PInfo()
        {
            InitializeComponent();
            
        }
        private SqlConnection connectDB()
        {
            string connectionString;
            SqlConnection cnn;
           // connectionString = @"Data Source=IMASHINETHMINI;Initial Catalog=Patient;Integrated Security=True";
            cnn =DatabaseConnection.Instance.GetConnection();
           
            //MessageBox.Show("Connected");
            return cnn;

            
        }
        void populate()
        {
            //using (SqlConnection cnn = connectDB())
                SqlConnection cnn = connectDB();
                String query = "select * from Patient";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            
        }

        public static void EmptyTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }
        }

        int key = 0;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtPID.Text = "";
            txtName.Text = "";
            txtEmergency.Text = "";
            txtDOB.Text = "";
            txtContact.Text = "";
            txtBlood.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            if (radioMale.Checked=true)
            {
                radioMale.Checked = false;

            }
            else
            {
                radioFemale.Checked = false;
            }

            if (checkBoxFood.Checked = true)
            {
                checkBoxFood.Checked = false;
            }
            if(checkBoxDrug.Checked = true)
            {
                checkBoxDrug.Checked = false;
            }
            if(checkBoxPlaster.Checked = true)
            {
                checkBoxPlaster.Checked = false;
            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormController regcontroller = FormController.Instance; ;
            regcontroller.hideAllUserControllers();
            Control pcontroller = regcontroller.getUserControll("userControl1_Patients1");
            pcontroller.Show();
        }

        private void UserControl1_PInfo_Load(object sender, EventArgs e)
        {
            populate();
        }

        

        private void BtnIUpdate_Click(object sender, EventArgs e)
        {
            String pid = txtPID.Text;
            String name = txtName.Text;
            String address = txtAddress.Text;
            String gender = "";
            String dob = Convert.ToDateTime(txtDOB.Text).ToString("dd-MM-yyyy");
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
            }
            else
            {
                gender = "Female";
            }

            if (checkBoxFood.Checked)
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

            sql = "update Patient set Patient_ID='{0}',Name='{1}',Address='{2}',DateOFBirth='{3}',Age='{4}',Gender='{5}',Mobile_Number='{6}',Blood_Group ='{7}',Emergency_Contact_No='{8}',Food_Allergies='{9}',Drug_Allergies='{10}',Plaster_Allergies='{11}'";
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Data Updated");
            cnn.Close();
           
        }

        private void BtnIDelete_Click(object sender, EventArgs e)
        {
            
            if (txtPID.Text != "")
            {
                String pid = txtPID.Text;
                SqlConnection cnn = connectDB();
                
                    String sql = "delete Patient where Patient_ID= '" + pid + "'";
                    
                    SqlCommand command;
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    populate();

                MessageBox.Show("Record Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void TxtPID_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPID.Text != " ")
            {

                String pid = txtPID.Text;
                SqlConnection cnn;
                cnn = connectDB();
                SqlCommand command;
                String sql = "";

                sql = "select * from Patient where Patient_ID= '" + pid + "'";
                command = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                command.ExecuteNonQuery();

                cnn.Close();

            }
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text != " ")
            {
                String contact = txtContact.Text;

                SqlConnection cnn;
                cnn = connectDB();
                SqlCommand command;
                String sql = "";

                sql = "select * from Patient where Mobile_Number= " + contact + "";
                command = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                command.ExecuteNonQuery();

                cnn.Close();

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtAge.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string gender = "";
                if (radioFemale.Checked)
                {
                    gender = radioFemale.Text;
                }
                else
                {
                    gender = radioMale.Text;
                }

                gender = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtContact.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtBlood.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtEmergency.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                checkBoxFood.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                checkBoxDrug.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                checkBoxPlaster.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            }
            
           
            
        }
    }
}
