using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Shared.Entities {
    
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(FullTimeEmployee), typeof(PartTimeEmployee))]
    public abstract class Employee
    {
        [BsonId]
        public ObjectId Id { get; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }

}
