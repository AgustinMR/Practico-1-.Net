using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


 namespace DataAccessLayer{
   public class conexion{
        SqlConnection tcp;
        SqlCommand cmd;
        SqlDataReader cin;

        public conexion(){

            try{
                tcp = new SqlConnection("Data Source =.; Initial Catalog =.NET; Integrated Security = True");
                tcp.Open();
                MessageBox.Show("Conectado papa!");

            }
            catch (Exception ex){
                MessageBox.Show("Error al conectarse" + ex.ToString());
                tcp.Close();

            }
        }
    }



    public class DALEmployeesNativeSQL : IDALEmployees
    {
        public void AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
