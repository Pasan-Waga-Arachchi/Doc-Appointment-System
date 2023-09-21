namespace RAD_Project
{
    partial class UserControl1_Channel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1_Channel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_appoint_Click = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SpecialcomboBox = new System.Windows.Forms.ComboBox();
            this.appintIDcomboBox = new System.Windows.Forms.ComboBox();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.txt_PatientID = new System.Windows.Forms.TextBox();
            this.txt_PatientName = new System.Windows.Forms.TextBox();
            this.btn_show_doctors = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.TypecomboBox);
            this.panel1.Controls.Add(this.timepicker);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_appoint_Click);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SpecialcomboBox);
            this.panel1.Controls.Add(this.appintIDcomboBox);
            this.panel1.Controls.Add(this.txt_Reason);
            this.panel1.Controls.Add(this.txt_PatientID);
            this.panel1.Controls.Add(this.txt_PatientName);
            this.panel1.Controls.Add(this.btn_show_doctors);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 482);
            this.panel1.TabIndex = 0;
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Location = new System.Drawing.Point(590, 121);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(144, 24);
            this.TypecomboBox.TabIndex = 26;
            // 
            // timepicker
            // 
            this.timepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepicker.CustomFormat = "HH:mm:ss";
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timepicker.Location = new System.Drawing.Point(225, 123);
            this.timepicker.Name = "timepicker";
            this.timepicker.Size = new System.Drawing.Size(144, 22);
            this.timepicker.TabIndex = 25;
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CustomFormat = "yyyy-MM-dd";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(590, 75);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(156, 22);
            this.dateTime.TabIndex = 24;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_clear.Location = new System.Drawing.Point(671, 414);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 56);
            this.btn_clear.TabIndex = 23;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.MouseEnter += new System.EventHandler(this.btn_clear_MouseEnter);
            this.btn_clear.MouseLeave += new System.EventHandler(this.btn_clear_MouseLeave);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_delete.Location = new System.Drawing.Point(671, 291);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 56);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseEnter += new System.EventHandler(this.btn_delete_MouseEnter);
            this.btn_delete.MouseLeave += new System.EventHandler(this.btn_delete_MouseLeave);
            // 
            // btn_appoint_Click
            // 
            this.btn_appoint_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_appoint_Click.Location = new System.Drawing.Point(563, 414);
            this.btn_appoint_Click.Name = "btn_appoint_Click";
            this.btn_appoint_Click.Size = new System.Drawing.Size(102, 56);
            this.btn_appoint_Click.TabIndex = 21;
            this.btn_appoint_Click.Text = "Set Appointment";
            this.btn_appoint_Click.UseVisualStyleBackColor = false;
            this.btn_appoint_Click.Click += new System.EventHandler(this.btn_appoint_Click_Click);
            this.btn_appoint_Click.MouseEnter += new System.EventHandler(this.btn_appoint_Click_MouseEnter);
            this.btn_appoint_Click.MouseLeave += new System.EventHandler(this.btn_appoint_Click_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(490, 232);
            this.dataGridView1.TabIndex = 20;
            // 
            // SpecialcomboBox
            // 
            this.SpecialcomboBox.FormattingEnabled = true;
            this.SpecialcomboBox.Location = new System.Drawing.Point(224, 180);
            this.SpecialcomboBox.Name = "SpecialcomboBox";
            this.SpecialcomboBox.Size = new System.Drawing.Size(144, 24);
            this.SpecialcomboBox.TabIndex = 19;
            // 
            // appintIDcomboBox
            // 
            this.appintIDcomboBox.FormattingEnabled = true;
            this.appintIDcomboBox.Location = new System.Drawing.Point(225, 27);
            this.appintIDcomboBox.Name = "appintIDcomboBox";
            this.appintIDcomboBox.Size = new System.Drawing.Size(144, 24);
            this.appintIDcomboBox.TabIndex = 17;
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(590, 178);
            this.txt_Reason.Multiline = true;
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(177, 67);
            this.txt_Reason.TabIndex = 15;
            // 
            // txt_PatientID
            // 
            this.txt_PatientID.Location = new System.Drawing.Point(225, 77);
            this.txt_PatientID.Name = "txt_PatientID";
            this.txt_PatientID.Size = new System.Drawing.Size(144, 22);
            this.txt_PatientID.TabIndex = 11;
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.Location = new System.Drawing.Point(590, 31);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.Size = new System.Drawing.Size(144, 22);
            this.txt_PatientName.TabIndex = 10;
            // 
            // btn_show_doctors
            // 
            this.btn_show_doctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_show_doctors.Location = new System.Drawing.Point(563, 291);
            this.btn_show_doctors.Name = "btn_show_doctors";
            this.btn_show_doctors.Size = new System.Drawing.Size(88, 56);
            this.btn_show_doctors.TabIndex = 1;
            this.btn_show_doctors.Text = "Show Doctors";
            this.btn_show_doctors.UseVisualStyleBackColor = false;
            this.btn_show_doctors.Click += new System.EventHandler(this.btn_show_doctors_Click);
            this.btn_show_doctors.MouseEnter += new System.EventHandler(this.btn_show_doctors_MouseEnter);
            this.btn_show_doctors.MouseLeave += new System.EventHandler(this.btn_show_doctors_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Specialization:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Appointment Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Appointment \r\nReason:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Appointment Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment ID:";
            // 
            // UserControl1_Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1_Channel";
            this.Size = new System.Drawing.Size(781, 482);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.TextBox txt_PatientID;
        private System.Windows.Forms.TextBox txt_PatientName;
        private System.Windows.Forms.Button btn_show_doctors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SpecialcomboBox;
        private System.Windows.Forms.ComboBox appintIDcomboBox;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_appoint_Click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.DateTimePicker timepicker;
        private System.Windows.Forms.ComboBox TypecomboBox;
    }
}
