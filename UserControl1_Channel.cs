using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RAD_Project
{
    public partial class UserControl1_Channel : UserControl
    {
        public UserControl1_Channel()
        {
            InitializeComponent();
            PopulateAppointmentType();
            PopulateSpecialization();
            PopulateAppointmentID();
            ClearData();
        }

        private void ClearData()
        {
            txt_PatientID.Clear();
            txt_PatientName.Clear();
            txt_Reason.Clear();
            TypecomboBox.SelectedIndex = -1;
            //SpecialcomboBox.SelectedIndex = -1;
            dateTime.Value = DateTime.Now;
            timepicker.Value = DateTime.Now;
            dataGridView1.DataSource = null;
        }

        private void PopulateAppointmentType()
        {
            TypecomboBox.Items.Add("Regular Check-up");
            TypecomboBox.Items.Add("Follow-up");
            TypecomboBox.Items.Add("Consultation");
        }

        private void PopulateAppointmentID() 
        {
            for (int i = 1; i <= 10; i++) 
            {
                appintIDcomboBox.Items.Add("A"+i);
            }
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


        private void btn_show_doctors_Click(object sender, EventArgs e)
        {
            DateTime time = timepicker.Value;
            DateTime date = dateTime.Value.Date;
            string state = SpecialcomboBox.Text;

            try
            {
                string query = "SELECT doctorname,special,time,date FROM Doctor WHERE special = '"+state+"' AND date= '"+date+"' AND time= '"+time+"'";
                {
                    try
                    {
                        SqlConnection connection = DatabaseConnection.Instance.GetConnection();
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count == 0) 
                        {
                            MessageBox.Show("No any doctors available...","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            dataGridView1.DataSource = null;
                        }
                        else
                        {
                            dataGridView1.DataSource = table;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }  
        }

       private void btn_appoint_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseConnection.Instance.GetConnection();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string doctorName = dataGridView1.SelectedRows[0].Cells["DoctorName"].Value.ToString();
                string appointmentDate = dateTime.Value.ToString();
                string appointmentTime = timepicker.Value.ToString();
                string patientName  = txt_PatientName.Text;
                string patientID = txt_PatientID.Text;
                string appointmentID = appintIDcomboBox.SelectedItem.ToString();
                string reason = txt_Reason.Text;
                string appoinmentType = TypecomboBox.SelectedItem.ToString();
                string specialization = SpecialcomboBox.SelectedItem.ToString();

                try
                {
                    string query = "INSERT INTO Appointment (appointmentID, patientName, patientID, doctorname,appointmentDate, appointmentTime, reason,appoinmentType,specialization) " +
                           "VALUES (@AppointmentID,@PatientName,@PatientID,@DoctorName,@AppointmentDate,@AppointmenTime,@Reason,@AppointmentType,@Specialization)";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    cmd.Parameters.AddWithValue("@PatientName", patientName);
                    cmd.Parameters.AddWithValue("@PatientID", patientID);
                    cmd.Parameters.AddWithValue("@DoctorName", doctorName);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@AppointmenTime", appointmentTime);
                    cmd.Parameters.AddWithValue("@Reason", reason);
                    cmd.Parameters.AddWithValue("@AppointmentType", appoinmentType);
                    cmd.Parameters.AddWithValue("@Specialization", specialization);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Appointment with Dr. {doctorName} on {appointmentDate} has been scheduled.","Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to schedule the appointment.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor from the list.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (appintIDcomboBox.SelectedItem != null)
            {
                string selectedAppointmentID = appintIDcomboBox.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlConnection connection = DatabaseConnection.Instance.GetConnection();
                    string deleteQuery = "DELETE FROM Appointment WHERE appointmentID = @AppointmentID";
                    try
                    {
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@AppointmentID", selectedAppointmentID);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment deleted successfully.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show("No records were deleted. Please check the Appointment ID.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_show_doctors_MouseEnter(object sender, EventArgs e)
        {
            btn_show_doctors.BackColor = Color.Lime;
        }

        private void btn_show_doctors_MouseLeave(object sender, EventArgs e)
        {
            btn_show_doctors.BackColor = Color.Aqua;
        }

        private void btn_appoint_MouseEnter(object sender, EventArgs e)
        {
            btn_appoint.BackColor = Color.Lime;
        }

        private void btn_appoint_MouseLeave(object sender, EventArgs e)
        {
            btn_appoint.BackColor = Color.Aqua;
        }

        private void btn_clear_MouseEnter(object sender, EventArgs e)
        {
            btn_clear.BackColor = Color.Lime;
        }

        private void btn_clear_MouseLeave(object sender, EventArgs e)
        {
            btn_clear.BackColor = Color.Aqua;
        }
        private void btn_delete_MouseEnter(object sender, EventArgs e)
        {
            btn_delete.BackColor = Color.Lime;
        }

        private void btn_delete_MouseLeave(object sender, EventArgs e)
        {
            btn_delete.BackColor = Color.Aqua;
        }

        private void appintIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
