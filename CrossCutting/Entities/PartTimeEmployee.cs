using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Shared.Entities
{

    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
    }
}
