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
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control aboutUsController=controller.getUserControll("userControl1_Home1");
            aboutUsController.Show();
        }
    }
}
