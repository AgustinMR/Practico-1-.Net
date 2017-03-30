using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Shared.Entities {

    public abstract class Employee {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}
