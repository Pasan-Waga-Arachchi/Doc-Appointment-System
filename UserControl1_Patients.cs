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
    public partial class UserControl1_Patients : UserControl
    {
        public UserControl1_Patients()
        {
            InitializeComponent();
        }

        private void PReg_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control patientregController = controller.getUserControll("UserControl1_PReg1");
            patientregController.Show();
        }

        private void PInfo_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control patientregController = controller.getUserControll("UserControl1_PInfo1");
            patientregController.Show();
        }
    }
}
