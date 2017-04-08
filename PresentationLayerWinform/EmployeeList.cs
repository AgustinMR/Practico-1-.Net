using System;
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
            employee.DataSource = dataTable;
            string typeEmp;
            foreach (Employee emp in new ServiceEmployeesClient().GetAllEmployees())
            {
                if (emp.GetType() == typeof(Shared.Entities.FullTimeEmployee)) typeEmp = "Full Time";
                else typeEmp = "Part Time";
                Object[] row = { emp.EmployeeId, emp.Name, emp.StartDate, typeEmp };
                dataTable.Rows.Add(row);
            }
        }
    }
}
