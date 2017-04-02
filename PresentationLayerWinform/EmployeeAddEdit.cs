using Service.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    public partial class EmployeeAddEdit : Form
    {
        public EmployeeAddEdit()
        {
            InitializeComponent();
        }

        private void EmployeeAddEdit_Load(object sender, EventArgs algo)
        {
            string tipo;
            foreach (Employee e in new ServiceEmployeesClient().GetAllEmployees())
            {
                tipo = "PartTime";
                if (e.GetType() == typeof(FullTimeEmployee)) tipo = "FullTime";
                comboBox.Items.Add(e.EmployeeId + " - " + e.Name + " - " + tipo);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelHourlyRate_Click(object sender, EventArgs e)
        {

        }

        private void empType_CheckedChanged(object sender, EventArgs e)
        {
            if (empType.Checked)
            {
                labelHourlyRate.Visible = false;
                HourlyRate.Visible = false;
                labelSalary.Visible = true;
                salary.Visible = true;
            }
            else
            {
                labelSalary.Visible = false;
                salary.Visible = false;
                labelHourlyRate.Visible = true;
                HourlyRate.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs elpm)
        {
            if (empType.Checked) // si el primer radio box esta checkeado, significa que es del tipo Full Time.
            {
                FullTimeEmployee e = new FullTimeEmployee();
                e.Name = EmployeeName.Text;
                e.StartDate = DateTime.Parse(startTimeEmployee.Value.ToString());
                e.Salary = int.Parse(salary.Text);
                new ServiceEmployeesClient().AddEmployee(e);
            }
            else
            {
                PartTimeEmployee e = new PartTimeEmployee();
                e.Name = EmployeeName.Text;
                e.StartDate = DateTime.Parse(startTimeEmployee.Value.ToString());
                e.HourlyRate = double.Parse(HourlyRate.Text);
                new ServiceEmployeesClient().AddEmployee(e);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs wtmw)
        {
            labelSalaryUpdate.Visible = false;
            salaryUpdate.Visible = false;
            labelHourlyRateUpdate.Visible = false;
            hourlyRateUpdate.Visible = false;
            Employee e = new ServiceEmployeesClient().GetEmployee(int.Parse(comboBox.SelectedItem.ToString().Substring(0,1)));
            if (e != null)
            {
                nameUpdate.Text = e.Name;
                startTimeUpdate.Value = e.StartDate;
                if (e.GetType() == typeof(FullTimeEmployee))
                {
                    labelSalaryUpdate.Visible = true;
                    salaryUpdate.Visible = true;
                    salaryUpdate.Text = ((FullTimeEmployee)e).Salary.ToString();
                }
                else
                {
                    labelHourlyRateUpdate.Visible = true;
                    hourlyRateUpdate.Visible = true;
                    hourlyRateUpdate.Text = ((PartTimeEmployee)e).HourlyRate.ToString();
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs sth)
        {
            if (hourlyRateUpdate.Visible == false)
            {
                FullTimeEmployee e = new FullTimeEmployee();
                e.EmployeeId = int.Parse(comboBox.SelectedItem.ToString().Substring(0, 1));
                e.Name = nameUpdate.Text;
                e.StartDate = DateTime.Parse(startTimeUpdate.Value.ToString());
                e.Salary = int.Parse(salaryUpdate.Text);
                new ServiceEmployeesClient().UpdateEmployee(e);
            }
            else
            {
                PartTimeEmployee e = new PartTimeEmployee();
                e.EmployeeId = int.Parse(comboBox.SelectedItem.ToString().Substring(0, 1));
                e.Name = nameUpdate.Text;
                e.StartDate = DateTime.Parse(startTimeUpdate.Value.ToString());
                e.HourlyRate = double.Parse(hourlyRateUpdate.Text);
                new ServiceEmployeesClient().UpdateEmployee(e);
            }
        }
    }
}
