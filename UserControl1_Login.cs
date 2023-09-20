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
    public partial class UserControl1_Login : UserControl
    {
        public UserControl1_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control control1 = controller.getUserControll("admin_login2");
            control1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
            controller.hideAllUserControllers();
            Control doclog = controller.getUserControll("doctorLogin1");
            doclog.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormController controller = FormController.Instance;
             controller.hideAllUserControllers();
             Control patlog = controller.getUserControll("pat_login1");
             patlog.Show();
            //var newform = new pat_login();
            //newform.Show();
        }
    }
}
