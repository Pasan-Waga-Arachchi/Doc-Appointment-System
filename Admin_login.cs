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
    public partial class Admin_login : UserControl
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control userlog1 = controller.getUserControll("UserControl1_Login1");
            userlog1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredPassword = textBox1.Text;
            if (enteredPassword == "sys@pwd")
            {
                FormController controller = FormController.Instance;
                controller.hideAllUserControllers();
                Control userlog1 = controller.getUserControll("UserControl1_Admin1");
                userlog1.Show();
                
            }
        
            else
            {
                
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
        }
    }
}
