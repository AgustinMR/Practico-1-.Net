﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace Shared.Entities
{
    [DataContract(Namespace = "Service.Employees")]
    public class PartTimeEmployee : Employee
    {
        [DataMember]
        public double HourlyRate { get; set; }
    }
}
