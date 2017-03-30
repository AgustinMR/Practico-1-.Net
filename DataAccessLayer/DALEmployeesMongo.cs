using Shared.Entities;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using MongoDB.Bson;
using MongoDB;
using MongoDB.Driver;
>>>>>>> 1bd243345e8fe332dd5bb2fdeda09c710b8476ed

namespace DataAccessLayer
{

    public class DALEmployeesMongo : IDALEmployees
    {
        public void AddEmployee(Employee emp)
        {
<<<<<<< HEAD
=======
            if (emp != null) {
                var mongo = new MongoClient();
                var bd = mongo.GetDatabase("Practico1");
                var employees = bd.GetCollection<Employee>("Employee");
                employees.InsertOneAsync(emp);
            }
>>>>>>> 1bd243345e8fe332dd5bb2fdeda09c710b8476ed
        }

        public void DeleteEmployee(int id)
        {
            var mongo = new MongoClient();
            var bd = mongo.GetDatabase("Practico1");
            var employees = bd.GetCollection<Employee>("Employee");
            employees.DeleteOne(e => e.EmployeeId == id);
        }

        public void UpdateEmployee(Employee emp)
        {
            if (emp != null) {
                var filter = Builders<BsonDocument>.Filter.Eq("EmployeeId", emp.EmployeeId);
                var mongo = new MongoClient();
                var bd = mongo.GetDatabase("Practico1");
                var employees = bd.GetCollection<Employee>("Employee");
            }
        }

        public List<Employee> GetAllEmployees()
        {
            var mongo = new MongoClient();
            var bd = mongo.GetDatabase("Practico1");
            return bd.GetCollection<Employee>("Employee").Find(new BsonDocument()).ToList();
        }

        public Employee GetEmployee(int id)
        {
            var mongo = new MongoClient();
            var bd = mongo.GetDatabase("Practico1");
            Employee emp = bd.GetCollection<Employee>("Employee").Find(e => e.EmployeeId == id).First();
            return emp;
        }
    }
}
