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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1_Channel));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appintIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SpecialcomboBox = new System.Windows.Forms.ComboBox();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_appoint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_show_doctors = new System.Windows.Forms.Button();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txt_PatientID = new System.Windows.Forms.TextBox();
            this.txt_PatientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.appintIDcomboBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.SpecialcomboBox);
            this.panel1.Controls.Add(this.timepicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_appoint);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_show_doctors);
            this.panel1.Controls.Add(this.TypecomboBox);
            this.panel1.Controls.Add(this.txt_Reason);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.txt_PatientID);
            this.panel1.Controls.Add(this.txt_PatientName);
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
            // appintIDcomboBox
            // 
            this.appintIDcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appintIDcomboBox.FormattingEnabled = true;
            this.appintIDcomboBox.Location = new System.Drawing.Point(331, 12);
            this.appintIDcomboBox.Name = "appintIDcomboBox";
            this.appintIDcomboBox.Size = new System.Drawing.Size(228, 33);
            this.appintIDcomboBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Cornsilk;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Appointment ID:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Aqua;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(423, 1016);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 64);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete Appointment";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseEnter += new System.EventHandler(this.btn_delete_MouseEnter);
            this.btn_delete.MouseLeave += new System.EventHandler(this.btn_delete_MouseLeave);
            // 
            // SpecialcomboBox
            // 
            this.SpecialcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialcomboBox.FormattingEnabled = true;
            this.SpecialcomboBox.Location = new System.Drawing.Point(331, 505);
            this.SpecialcomboBox.Name = "SpecialcomboBox";
            this.SpecialcomboBox.Size = new System.Drawing.Size(228, 33);
            this.SpecialcomboBox.Sorted = true;
            this.SpecialcomboBox.TabIndex = 18;
            // 
            // timepicker
            // 
            this.timepicker.CustomFormat = "HH:mm:ss";
            this.timepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker.Location = new System.Drawing.Point(331, 215);
            this.timepicker.Name = "timepicker";
            this.timepicker.Size = new System.Drawing.Size(292, 30);
            this.timepicker.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Cornsilk;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Appoinment Time:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Aqua;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(607, 1016);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(119, 64);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.MouseEnter += new System.EventHandler(this.btn_clear_MouseEnter);
            this.btn_clear.MouseLeave += new System.EventHandler(this.btn_clear_MouseLeave);
            // 
            // btn_appoint
            // 
            this.btn_appoint.BackColor = System.Drawing.Color.Aqua;
            this.btn_appoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appoint.Location = new System.Drawing.Point(31, 1016);
            this.btn_appoint.Name = "btn_appoint";
            this.btn_appoint.Size = new System.Drawing.Size(154, 64);
            this.btn_appoint.TabIndex = 14;
            this.btn_appoint.Text = "Make Appointment";
            this.btn_appoint.UseVisualStyleBackColor = false;
            this.btn_appoint.Click += new System.EventHandler(this.btn_appoint_Click);
            this.btn_appoint.MouseEnter += new System.EventHandler(this.btn_appoint_MouseEnter);
            this.btn_appoint.MouseLeave += new System.EventHandler(this.btn_appoint_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Specialization:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 633);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 368);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_show_doctors
            // 
            this.btn_show_doctors.BackColor = System.Drawing.Color.Aqua;
            this.btn_show_doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_doctors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_show_doctors.Location = new System.Drawing.Point(62, 566);
            this.btn_show_doctors.Name = "btn_show_doctors";
            this.btn_show_doctors.Size = new System.Drawing.Size(629, 61);
            this.btn_show_doctors.TabIndex = 10;
            this.btn_show_doctors.Text = "Show Available Doctors";
            this.btn_show_doctors.UseVisualStyleBackColor = false;
            this.btn_show_doctors.Click += new System.EventHandler(this.btn_show_doctors_Click);
            this.btn_show_doctors.MouseEnter += new System.EventHandler(this.btn_show_doctors_MouseEnter);
            this.btn_show_doctors.MouseLeave += new System.EventHandler(this.btn_show_doctors_MouseLeave);
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Location = new System.Drawing.Point(331, 418);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(228, 33);
            this.TypecomboBox.TabIndex = 9;
            // 
            // txt_Reason
            // 
            this.txt_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reason.Location = new System.Drawing.Point(331, 282);
            this.txt_Reason.Multiline = true;
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Reason.Size = new System.Drawing.Size(355, 119);
            this.txt_Reason.TabIndex = 8;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy-MM-dd";
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(331, 157);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(355, 30);
            this.dateTime.TabIndex = 7;
            // 
            // txt_PatientID
            // 
            this.txt_PatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientID.Location = new System.Drawing.Point(331, 109);
            this.txt_PatientID.Name = "txt_PatientID";
            this.txt_PatientID.Size = new System.Drawing.Size(292, 30);
            this.txt_PatientID.TabIndex = 6;
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PatientName.Location = new System.Drawing.Point(331, 59);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.Size = new System.Drawing.Size(292, 30);
            this.txt_PatientName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Appointment Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reason For Appointment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appointment Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControl1_Channel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1_Channel";
            this.Size = new System.Drawing.Size(781, 482);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txt_PatientID;
        private System.Windows.Forms.TextBox txt_PatientName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_show_doctors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_appoint;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker timepicker;
        private System.Windows.Forms.ComboBox SpecialcomboBox;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox appintIDcomboBox;
        private System.Windows.Forms.Label label8;
    }
}
