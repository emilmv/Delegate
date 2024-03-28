using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
