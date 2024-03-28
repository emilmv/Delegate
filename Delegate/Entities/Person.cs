using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Entities
{
    internal class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public List<Person> Employees { get; set; }
        public Person()
        {
            Employees = new List<Person>();
        }
    }
}
