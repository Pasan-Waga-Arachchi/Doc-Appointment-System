using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_Project
{
    public partial class UserControl1_Home : UserControl
    {
        public UserControl1_Home()
        {
            InitializeComponent();
        }

        private void SelectSpecialistBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control doctor = controller.getUserControll("userControl1_Channel1");
            doctor.Show();
            
        }

        private void TestYourHealthBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control patient = controller.getUserControll("userControl1_Patients1");
            patient.Show();
        }

        private void LabReportBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control aboutus = controller.getUserControll("userControl1AboutUs1");
            aboutus.Show();
        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control doctor = controller.getUserControll("userControl1_Channel1");
            doctor.Show();
        }

        private void LabBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control patient = controller.getUserControll("userControl1_Patients1");
            patient.Show();
        }

        private void MedicineBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control patient = controller.getUserControll("userControl1_Patients1");
            patient.Show();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control patient = controller.getUserControll("userControl1_Patients1");
            patient.Show();
        }

        private void CallUsBtn_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control aboutus = controller.getUserControll("userControl1AboutUs1");
            aboutus.Show();
        }
    }
}
