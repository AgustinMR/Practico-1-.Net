using System;

namespace PresentationLayerWinform
{
    partial class EmployeeAddEdit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.HourlyRate = new System.Windows.Forms.TextBox();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.empType2 = new System.Windows.Forms.RadioButton();
            this.empType = new System.Windows.Forms.RadioButton();
            this.startTimeEmployee = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.labelHourlyRateUpdate = new System.Windows.Forms.Label();
            this.hourlyRateUpdate = new System.Windows.Forms.TextBox();
            this.labelSalaryUpdate = new System.Windows.Forms.Label();
            this.salaryUpdate = new System.Windows.Forms.TextBox();
            this.startTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameUpdate = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.HourlyRate);
            this.tabPage1.Controls.Add(this.labelHourlyRate);
            this.tabPage1.Controls.Add(this.salary);
            this.tabPage1.Controls.Add(this.labelSalary);
            this.tabPage1.Controls.Add(this.empType2);
            this.tabPage1.Controls.Add(this.empType);
            this.tabPage1.Controls.Add(this.startTimeEmployee);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.EmployeeName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create New";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(783, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HourlyRate
            // 
            this.HourlyRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourlyRate.Location = new System.Drawing.Point(182, 261);
            this.HourlyRate.Name = "HourlyRate";
            this.HourlyRate.Size = new System.Drawing.Size(241, 26);
            this.HourlyRate.TabIndex = 10;
            this.HourlyRate.Visible = false;
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHourlyRate.Location = new System.Drawing.Point(63, 264);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(88, 18);
            this.labelHourlyRate.TabIndex = 9;
            this.labelHourlyRate.Text = "Hourly Rate";
            this.labelHourlyRate.Visible = false;
            this.labelHourlyRate.Click += new System.EventHandler(this.labelHourlyRate_Click);
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(182, 261);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(241, 26);
            this.salary.TabIndex = 8;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelSalary.Location = new System.Drawing.Point(99, 264);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(52, 18);
            this.labelSalary.TabIndex = 7;
            this.labelSalary.Text = "Salary";
            this.labelSalary.Click += new System.EventHandler(this.label4_Click);
            // 
            // empType2
            // 
            this.empType2.AutoSize = true;
            this.empType2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empType2.Location = new System.Drawing.Point(182, 90);
            this.empType2.Name = "empType2";
            this.empType2.Size = new System.Drawing.Size(112, 28);
            this.empType2.TabIndex = 6;
            this.empType2.Text = "Part time";
            this.empType2.UseVisualStyleBackColor = true;
            // 
            // empType
            // 
            this.empType.AutoSize = true;
            this.empType.Checked = true;
            this.empType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empType.Location = new System.Drawing.Point(71, 90);
            this.empType.Name = "empType";
            this.empType.Size = new System.Drawing.Size(105, 28);
            this.empType.TabIndex = 5;
            this.empType.TabStop = true;
            this.empType.Text = "Full time";
            this.empType.UseVisualStyleBackColor = true;
            this.empType.CheckedChanged += new System.EventHandler(this.empType_CheckedChanged);
            // 
            // startTimeEmployee
            // 
            this.startTimeEmployee.CustomFormat = "yyyy-mm-dd";
            this.startTimeEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeEmployee.Location = new System.Drawing.Point(182, 200);
            this.startTimeEmployee.Name = "startTimeEmployee";
            this.startTimeEmployee.Size = new System.Drawing.Size(241, 26);
            this.startTimeEmployee.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(72, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(105, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(182, 152);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(241, 26);
            this.EmployeeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.labelHourlyRateUpdate);
            this.tabPage2.Controls.Add(this.hourlyRateUpdate);
            this.tabPage2.Controls.Add(this.labelSalaryUpdate);
            this.tabPage2.Controls.Add(this.salaryUpdate);
            this.tabPage2.Controls.Add(this.startTimeUpdate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.nameUpdate);
            this.tabPage2.Controls.Add(this.comboBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(783, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelHourlyRateUpdate
            // 
            this.labelHourlyRateUpdate.AutoSize = true;
            this.labelHourlyRateUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRateUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHourlyRateUpdate.Location = new System.Drawing.Point(51, 275);
            this.labelHourlyRateUpdate.Name = "labelHourlyRateUpdate";
            this.labelHourlyRateUpdate.Size = new System.Drawing.Size(88, 18);
            this.labelHourlyRateUpdate.TabIndex = 12;
            this.labelHourlyRateUpdate.Text = "Hourly Rate";
            this.labelHourlyRateUpdate.Visible = false;
            this.labelHourlyRateUpdate.Click += new System.EventHandler(this.label8_Click);
            // 
            // hourlyRateUpdate
            // 
            this.hourlyRateUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyRateUpdate.Location = new System.Drawing.Point(206, 272);
            this.hourlyRateUpdate.Name = "hourlyRateUpdate";
            this.hourlyRateUpdate.Size = new System.Drawing.Size(241, 26);
            this.hourlyRateUpdate.TabIndex = 11;
            this.hourlyRateUpdate.Visible = false;
            this.hourlyRateUpdate.WordWrap = false;
            this.hourlyRateUpdate.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelSalaryUpdate
            // 
            this.labelSalaryUpdate.AutoSize = true;
            this.labelSalaryUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaryUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelSalaryUpdate.Location = new System.Drawing.Point(87, 272);
            this.labelSalaryUpdate.Name = "labelSalaryUpdate";
            this.labelSalaryUpdate.Size = new System.Drawing.Size(52, 18);
            this.labelSalaryUpdate.TabIndex = 10;
            this.labelSalaryUpdate.Text = "Salary";
            this.labelSalaryUpdate.Visible = false;
            this.labelSalaryUpdate.Click += new System.EventHandler(this.label7_Click);
            // 
            // salaryUpdate
            // 
            this.salaryUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryUpdate.Location = new System.Drawing.Point(206, 272);
            this.salaryUpdate.Name = "salaryUpdate";
            this.salaryUpdate.Size = new System.Drawing.Size(241, 26);
            this.salaryUpdate.TabIndex = 9;
            this.salaryUpdate.Visible = false;
            this.salaryUpdate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // startTimeUpdate
            // 
            this.startTimeUpdate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeUpdate.CustomFormat = "yyyy-mm-dd";
            this.startTimeUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeUpdate.Location = new System.Drawing.Point(206, 219);
            this.startTimeUpdate.Name = "startTimeUpdate";
            this.startTimeUpdate.Size = new System.Drawing.Size(241, 26);
            this.startTimeUpdate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(61, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(89, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // nameUpdate
            // 
            this.nameUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUpdate.Location = new System.Drawing.Point(206, 169);
            this.nameUpdate.Name = "nameUpdate";
            this.nameUpdate.Size = new System.Drawing.Size(241, 26);
            this.nameUpdate.TabIndex = 5;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(64, 92);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(517, 26);
            this.comboBox.TabIndex = 2;
            this.comboBox.Text = "Select an Employee...";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Update Employee";
            // 
            // EmployeeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeAddEdit";
            this.Text = "EmployeeAddEdit";
            this.Load += new System.EventHandler(this.EmployeeAddEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.DateTimePicker startTimeEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton empType2;
        private System.Windows.Forms.RadioButton empType;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox HourlyRate;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DateTimePicker startTimeUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameUpdate;
        private System.Windows.Forms.Label labelSalaryUpdate;
        private System.Windows.Forms.TextBox salaryUpdate;
        private System.Windows.Forms.Label labelHourlyRateUpdate;
        private System.Windows.Forms.TextBox hourlyRateUpdate;
        private System.Windows.Forms.Button button2;
    }
}