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
    public partial class UserControl1_Admin : UserControl
    {
        public UserControl1_Admin()
        {
            InitializeComponent();
        }

        private void UserControl1_Admin_Load(object sender, EventArgs e)
        {

        }

        private void sdsd_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormController regcontroller = FormController.Instance; ;
            regcontroller.hideAllUserControllers();
            Control Dcontroller = regcontroller.getUserControll("userControl1_Doctor");
            Dcontroller.Show();
            Dcontroller.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormController regcontroller = FormController.Instance; ;
            regcontroller.hideAllUserControllers();
            Control Acontroller = regcontroller.getUserControll("userControl1_Appoinmentnew");
            Acontroller.Show();
            Acontroller.BringToFront();
        }
    }
}
