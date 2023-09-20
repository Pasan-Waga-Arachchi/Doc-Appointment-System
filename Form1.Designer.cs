using System.Windows.Forms;

namespace RAD_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.AboutUsButton = new System.Windows.Forms.Button();
            this.PatientButton = new System.Windows.Forms.Button();
            this.TimeButton = new System.Windows.Forms.Button();
            this.ChannelButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.controllContainerPanel = new System.Windows.Forms.Panel();
            this.userControl1_Admin1 = new RAD_Project.UserControl1_Admin();
            this.userControl1_Test1 = new RAD_Project.UserControl1_Test();
            this.userControl1_Home1 = new RAD_Project.UserControl1_Home();
            this.userControl1AboutUs2 = new RAD_Project.UserControl1AboutUs();
            this.userControl1AboutUs1 = new RAD_Project.UserControl1AboutUs();
            this.userControl1_Time2 = new RAD_Project.UserControl1_Time();
            this.userControl1_Time1 = new RAD_Project.UserControl1_Time();
            this.userControl1_Patients1 = new RAD_Project.UserControl1_Patients();
            this.userControl1_Login1 = new RAD_Project.UserControl1_Login();
            this.userControl1_Channel1 = new RAD_Project.UserControl1_Channel();
            this.userControl1_PReg1 = new RAD_Project.UserControl1_PReg();
            this.userControl1_PInfo1 = new RAD_Project.UserControl1_PInfo();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.controllContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 558);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "APPOINMENT";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.AdminButton);
            this.panel3.Controls.Add(this.AboutUsButton);
            this.panel3.Controls.Add(this.PatientButton);
            this.panel3.Controls.Add(this.TimeButton);
            this.panel3.Controls.Add(this.ChannelButton);
            this.panel3.Controls.Add(this.LoginButton);
            this.panel3.Controls.Add(this.HomeButton);
            this.panel3.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(16, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 372);
            this.panel3.TabIndex = 0;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Black;
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminButton.Location = new System.Drawing.Point(0, 315);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(230, 55);
            this.AdminButton.TabIndex = 6;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminBtn_Click);
            this.AdminButton.MouseEnter += new System.EventHandler(this.AdminButton_MouseEnter);
            this.AdminButton.MouseLeave += new System.EventHandler(this.AdminButton_MouseLeave);
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.BackColor = System.Drawing.Color.Black;
            this.AboutUsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutUsButton.Location = new System.Drawing.Point(0, 260);
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.Size = new System.Drawing.Size(230, 55);
            this.AboutUsButton.TabIndex = 5;
            this.AboutUsButton.Text = "About Us";
            this.AboutUsButton.UseVisualStyleBackColor = false;
            this.AboutUsButton.Click += new System.EventHandler(this.button7_Click);
            this.AboutUsButton.MouseEnter += new System.EventHandler(this.button7_MouseEnter);
            this.AboutUsButton.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            // 
            // PatientButton
            // 
            this.PatientButton.BackColor = System.Drawing.Color.Black;
            this.PatientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientButton.Location = new System.Drawing.Point(0, 208);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(230, 52);
            this.PatientButton.TabIndex = 4;
            this.PatientButton.Text = "Patients";
            this.PatientButton.UseVisualStyleBackColor = false;
            this.PatientButton.Click += new System.EventHandler(this.button6_Click);
            this.PatientButton.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.PatientButton.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            // 
            // TimeButton
            // 
            this.TimeButton.BackColor = System.Drawing.Color.Black;
            this.TimeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeButton.Location = new System.Drawing.Point(0, 156);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(230, 52);
            this.TimeButton.TabIndex = 3;
            this.TimeButton.Text = "Time Schedule";
            this.TimeButton.UseVisualStyleBackColor = false;
            this.TimeButton.Click += new System.EventHandler(this.button5_Click);
            this.TimeButton.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.TimeButton.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // ChannelButton
            // 
            this.ChannelButton.BackColor = System.Drawing.Color.Black;
            this.ChannelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChannelButton.Location = new System.Drawing.Point(0, 104);
            this.ChannelButton.Name = "ChannelButton";
            this.ChannelButton.Size = new System.Drawing.Size(230, 52);
            this.ChannelButton.TabIndex = 2;
            this.ChannelButton.Text = "Channel Your Doctor";
            this.ChannelButton.UseVisualStyleBackColor = false;
            this.ChannelButton.Click += new System.EventHandler(this.button4_Click);
            this.ChannelButton.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.ChannelButton.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Black;
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginButton.Location = new System.Drawing.Point(0, 52);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(230, 52);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button3_Click);
            this.LoginButton.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.LoginButton.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Black;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(230, 52);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.button2_Click);
            this.HomeButton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.HomeButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(265, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 58);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Time";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(804, 8);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(62, 43);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // controllContainerPanel
            // 
            this.controllContainerPanel.Controls.Add(this.userControl1_Admin1);
            this.controllContainerPanel.Controls.Add(this.userControl1_Test1);
            this.controllContainerPanel.Controls.Add(this.userControl1_Home1);
            this.controllContainerPanel.Controls.Add(this.userControl1AboutUs2);
            this.controllContainerPanel.Controls.Add(this.userControl1AboutUs1);
            this.controllContainerPanel.Controls.Add(this.userControl1_Time2);
            this.controllContainerPanel.Controls.Add(this.userControl1_Time1);
            this.controllContainerPanel.Controls.Add(this.userControl1_Patients1);
            this.controllContainerPanel.Controls.Add(this.userControl1_Login1);
            this.controllContainerPanel.Controls.Add(this.userControl1_Channel1);
            this.controllContainerPanel.Controls.Add(this.userControl1_PReg1);
            this.controllContainerPanel.Controls.Add(this.userControl1_PInfo1);
            this.controllContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllContainerPanel.Location = new System.Drawing.Point(265, 58);
            this.controllContainerPanel.Name = "controllContainerPanel";
            this.controllContainerPanel.Size = new System.Drawing.Size(877, 500);
            this.controllContainerPanel.TabIndex = 2;
            // 
            // userControl1_Admin1
            // 
            this.userControl1_Admin1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl1_Admin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Admin1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Admin1.Name = "userControl1_Admin1";
            this.userControl1_Admin1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Admin1.TabIndex = 10;
            // 
            // userControl1_Test1
            // 
            this.userControl1_Test1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Test1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Test1.Name = "userControl1_Test1";
            this.userControl1_Test1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Test1.TabIndex = 9;
            // 
            // userControl1_Home1
            // 
            this.userControl1_Home1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl1_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Home1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Home1.Name = "userControl1_Home1";
            this.userControl1_Home1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Home1.TabIndex = 8;
            // 
            // userControl1AboutUs2
            // 
            this.userControl1AboutUs2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1AboutUs2.Location = new System.Drawing.Point(0, 0);
            this.userControl1AboutUs2.Name = "userControl1AboutUs2";
            this.userControl1AboutUs2.Size = new System.Drawing.Size(877, 500);
            this.userControl1AboutUs2.TabIndex = 6;
            // 
            // userControl1AboutUs1
            // 
            this.userControl1AboutUs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1AboutUs1.Location = new System.Drawing.Point(0, 0);
            this.userControl1AboutUs1.Name = "userControl1AboutUs1";
            this.userControl1AboutUs1.Size = new System.Drawing.Size(877, 500);
            this.userControl1AboutUs1.TabIndex = 5;
            // 
            // userControl1_Time2
            // 
            this.userControl1_Time2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Time2.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Time2.Name = "userControl1_Time2";
            this.userControl1_Time2.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Time2.TabIndex = 4;
            // 
            // userControl1_Time1
            // 
            this.userControl1_Time1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Time1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Time1.Name = "userControl1_Time1";
            this.userControl1_Time1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Time1.TabIndex = 3;
            // 
            // userControl1_Patients1
            // 
            this.userControl1_Patients1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl1_Patients1.BackgroundImage")));
            this.userControl1_Patients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Patients1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Patients1.Name = "userControl1_Patients1";
            this.userControl1_Patients1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Patients1.TabIndex = 2;
            // 
            // userControl1_Login1
            // 
            this.userControl1_Login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Login1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Login1.Name = "userControl1_Login1";
            this.userControl1_Login1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Login1.TabIndex = 1;
            // 
            // userControl1_Channel1
            // 
            this.userControl1_Channel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_Channel1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_Channel1.Name = "userControl1_Channel1";
            this.userControl1_Channel1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_Channel1.TabIndex = 0;
            // 
            // userControl1_PReg1
            // 
            this.userControl1_PReg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl1_PReg1.BackgroundImage")));
            this.userControl1_PReg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_PReg1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_PReg1.Name = "userControl1_PReg1";
            this.userControl1_PReg1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_PReg1.TabIndex = 9;
            // 
            // userControl1_PInfo1
            // 
            this.userControl1_PInfo1.BackColor = System.Drawing.Color.Transparent;
            this.userControl1_PInfo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl1_PInfo1.BackgroundImage")));
            this.userControl1_PInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1_PInfo1.Location = new System.Drawing.Point(0, 0);
            this.userControl1_PInfo1.Name = "userControl1_PInfo1";
            this.userControl1_PInfo1.Size = new System.Drawing.Size(877, 500);
            this.userControl1_PInfo1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1142, 558);
            this.Controls.Add(this.controllContainerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.controllContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AboutUsButton;
        private System.Windows.Forms.Button PatientButton;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Button ChannelButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel controllContainerPanel;
        private UserControl1_Channel userControl1_Channel1;
        private UserControl1_Login userControl1_Login1;
        private UserControl1_Patients userControl1_Patients1;
        private UserControl1_Time userControl1_Time1;
        private UserControl1_Time userControl1_Time2;
        private UserControl1AboutUs userControl1AboutUs1;
        private UserControl1AboutUs userControl1AboutUs2;
        private UserControl1_Home userControl1_Home1;
        private UserControl1_Test userControl1_Test1;
        private Button AdminButton;
        private UserControl1_Admin userControl1_Admin1;
        private UserControl1_PReg userControl1_PReg1;
        private UserControl1_PInfo userControl1_PInfo1;
    }
}

