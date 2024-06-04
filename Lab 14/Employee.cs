using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    internal class Employee
    {
        public string name;
        public Guid Id { get; set; }
        public double salary;
        public string department;

        public Employee()
        {
            this.Id = Guid.NewGuid();
        }

        public override string ToString() => 
            $"Name: {name}, Id: {Id}, Department: {department}, Salary:{salary}";


    }
}
