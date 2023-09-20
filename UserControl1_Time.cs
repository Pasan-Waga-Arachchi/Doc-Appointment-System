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
    public partial class UserControl1_Time : UserControl
    {
        public UserControl1_Time()
        {
            InitializeComponent();
            PopulateSpecialization();
            LoadDoctor();

        }


        private void PopulateSpecialization()
        {
            SpecialcomboBox.Items.Add("Urology");
            SpecialcomboBox.Items.Add("Psychiatry");
            SpecialcomboBox.Items.Add("Gastroenterology");
            SpecialcomboBox.Items.Add("Ophthalmology");
            SpecialcomboBox.Items.Add("Dermatology");
            SpecialcomboBox.Items.Add("Otolaryngology");
            SpecialcomboBox.Items.Add("Emergency medicine");
            SpecialcomboBox.Items.Add("Orthopedics");
            SpecialcomboBox.Items.Add("Family medicine");
            SpecialcomboBox.Items.Add("Obstetrics and gynaecology");
            SpecialcomboBox.Items.Add("Geriatric medicine");
            SpecialcomboBox.Items.Add("Oncology");
            SpecialcomboBox.Items.Add("Radiology");
            SpecialcomboBox.Items.Add("Plastic surgery");
            SpecialcomboBox.Items.Add("Endocrinology");
            SpecialcomboBox.Items.Add("Neurosurgery");
            SpecialcomboBox.Items.Add("Cardiology");
            SpecialcomboBox.Items.Add("Child Psychiatrist");
        }


        private void LoadDoctor()
        {
            SqlConnection connection = DatabaseConnection.Instance.GetConnection();

            string special = SpecialcomboBox.SelectedValue as string;
            try
            {
                string query = "SELECT Name,Time,Hospital FROM Doctor WHERE Specialization ='" + special + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                DataTable doctorDataTable = new DataTable();
                doctorDataTable.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = doctorDataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDoctor();
        }
    }
}
