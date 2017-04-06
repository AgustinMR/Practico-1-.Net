using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

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
            DataTable tabla = new DataTable();
            DataColumn[] columns = { new DataColumn("Employee ID"), new DataColumn("Name"), new DataColumn("Start Date"), new DataColumn("Emp. Type") };
            tabla.Columns.AddRange(columns);
            employees.DataSource = tabla;
            string typeEmp;
            foreach (Employee emp in new ServiceEmployeesClient().GetAllEmployees())
            {
                if (emp.GetType() == typeof(FullTimeEmployee)) typeEmp = "Full Time";
                else typeEmp = "Part Time";
                Object[] row = { emp.EmployeeId, emp.Name, emp.StartDate, typeEmp };
                tabla.Rows.Add(row);
            }
        }
    }
}
