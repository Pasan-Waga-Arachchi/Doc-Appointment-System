using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();

            label2.Parent = pictureBox1;
            //label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            //label3.BackColor = Color.Transparent;

            userControl1_Home1.Show();
            userControl1_Home1.BringToFront();

            userControl1_Login1.Hide();
            userControl1_Channel1.Hide();
            userControl1_Time1.Hide();  
            userControl1_Patients1.Hide();
            userControl1AboutUs1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Red;
            ExitButton.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.White;
            ExitButton.ForeColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.White;
            HomeButton.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            HomeButton.BackColor= Color.Black;
            HomeButton.ForeColor= Color.Red;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.White;
            LoginButton.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.Black;
            LoginButton.ForeColor = Color.Red;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            ChannelButton.BackColor = Color.White;
            ChannelButton.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ChannelButton.BackColor = Color.Black;
            ChannelButton.ForeColor = Color.Red;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            TimeButton.BackColor = Color.White;
            TimeButton.ForeColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            TimeButton.BackColor= Color.Black;
            TimeButton.ForeColor= Color.Red;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            PatientButton.BackColor= Color.White;
            PatientButton.ForeColor= Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            PatientButton.BackColor= Color.Black;
            PatientButton.ForeColor= Color.Red;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            AboutUsButton.BackColor = Color.White;
            AboutUsButton.ForeColor= Color.Black;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            AboutUsButton.BackColor= Color.Black;
            AboutUsButton.ForeColor= Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl1_Home1.Show();
            userControl1_Home1.BringToFront();

            userControl1_Login1.Hide();
            userControl1_Channel1.Hide();
            userControl1_Time1.Hide();
            userControl1_Patients1.Hide();
            userControl1AboutUs1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl1_Login1.Show();
            userControl1_Login1.BringToFront();

            userControl1_Home1.Hide();
            userControl1_Channel1.Hide();
            userControl1_Time1.Hide();
            userControl1_Patients1.Hide();
            userControl1AboutUs1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl1_Channel1.Show(); 
            userControl1_Channel1.BringToFront();

            userControl1_Time1.Hide();
            userControl1_Patients1.Hide();
            userControl1AboutUs1.Hide();
            userControl1_Home1.Hide();
            userControl1_Login1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl1_Time1.Show();
            userControl1_Time1.BringToFront();

            userControl1_Home1.Hide();
            userControl1_Login1.Hide();
            userControl1_Channel1.Hide();
            //userControl1_Time1.Hide();
            userControl1_Patients1.Hide();
            userControl1AboutUs1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormController formController = FormController.Instance;
            formController.hideAllUserControllers();
            Control patientController = formController.getUserControll("userControl1_Patients1");
            patientController.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormController formController = FormController.Instance;
            formController.hideAllUserControllers();
            Control aboutUsController = formController.getUserControll("userControl1AboutUs1");
            aboutUsController.Show();


        }
       public Panel ControllContainerPanel { 
            get { return this.controllContainerPanel; } 
        }
        public ControlCollection ControllSet
        {
            get { return (ControlCollection)this.controllContainerPanel.Controls; }
        }

        private void AdminButton_MouseEnter(object sender, EventArgs e)
        {
            AdminButton.BackColor = Color.White;
            AdminButton.ForeColor = Color.Black;
        }

        private void AdminButton_MouseLeave(object sender, EventArgs e)
        {
            AdminButton.BackColor= Color.Black;
            AdminButton.ForeColor= Color.Red;
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            FormController formController = FormController.Instance;
            formController.hideAllUserControllers();
            Control AdminUserControl = formController.getUserControll("UserControl1_Admin");
            userControl1_Admin1.Show();
            /*Control AdminUsController = formController.getUserControll("UserControl1_Admin");
            AdminUsController.Show();*/
        }
    }
}
