using Shared.Entities;
using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;


namespace DataAccessLayer
{

    public class DALEmployeesMongo : IDALEmployees
    {

        public DALEmployeesMongo() {

        }

        public void AddEmployee(Employee emp)
        {
            if (emp != null) {
                var mongo = new MongoClient();
                var bd = mongo.GetDatabase("Practico1");
                var employees = bd.GetCollection<Employee>("Employee");
                employees.InsertOne(emp);
            }
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
        }

        public void UpdateEmployee(FullTimeEmployee emp)
        {
            if (emp != null)
            {
                var mongo = new MongoClient();
                var bd = mongo.GetDatabase("Practico1");
                var update = Builders<FullTimeEmployee>.Update.Set(e => e.Name, emp.Name).Set(e => e.StartDate, emp.StartDate).Set(e => e.Salary, emp.Salary);
                var filter = Builders<FullTimeEmployee>.Filter.Eq(e => e.EmployeeId, emp.EmployeeId);
                bd.GetCollection<FullTimeEmployee>("Employee").FindOneAndUpdate(filter, update);
            }
        }

        public void UpdateEmployee(PartTimeEmployee emp)
        {
            if (emp != null)
            {
                var mongo = new MongoClient();
                var bd = mongo.GetDatabase("Practico1");
                var update = Builders<PartTimeEmployee>.Update.Set(e => e.Name, emp.Name).Set(e => e.StartDate, emp.StartDate).Set(e => e.HourlyRate, emp.HourlyRate);
                var filter = Builders<PartTimeEmployee>.Filter.Eq("EmployeeId", emp.EmployeeId);
                bd.GetCollection<PartTimeEmployee>("Employee").FindOneAndUpdate(filter, update);
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
            var employees = bd.GetCollection<Employee>("Employee");
            var result = employees.Find(e => e.EmployeeId == id).FirstOrDefault();
            return result;
        }
    }
}
