﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Employees; // Namespace de la clase generada con la utilizad svcutil.exe

namespace PresentationLayerWinform
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("Employee ID"), new DataColumn("Name"), new DataColumn("Start Date"), new DataColumn("Emp. Type") };
            dataTable.Columns.AddRange(columns);
            employees.DataSource = dataTable;
            string typeEmp;
            foreach (Employee emp in new ServiceEmployeesClient().GetAllEmployees()) {
                if (emp.GetType() == typeof(FullTimeEmployee)) typeEmp = "Full Time";
                else typeEmp = "Part Time";
                Object[] row = {emp.EmployeeId, emp.Name, emp.StartDate, typeEmp };
                dataTable.Rows.Add(row);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newEmployeeBtn_Click(object sender, EventArgs e)
        {
            new EmployeeAddEdit().Show();
        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
