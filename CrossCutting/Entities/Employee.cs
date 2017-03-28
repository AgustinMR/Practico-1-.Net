using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities {

    public abstract class Employee {
        private int Id { get; set; }
        private string Name { get; set; }
        private DateTime StartDate { get; set; }
    }
}
