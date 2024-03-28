using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegate.Entities
{
    internal class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }





        public override string ToString()
        {
            return $"Full Name: {Name} {SurName} , Address: {Address}, Salary: {Salary}";
        }
    }
    
}
