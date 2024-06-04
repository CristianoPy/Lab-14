using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    internal class Employee_Management
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee() => employees.Add(new Employee());

        public void RemoveEmployee() => employees.Remove(new Employee());
       

        public List<Employee>GetNoWellPayedEmployee() =>
            employees.FindAll(e => e.salary <= 5000);

        public List<Employee> GetEmployeeByDepartment() =>
            employees.FindAll(e => e.department == Department.testing);

        public List<Employee> GetMaxSalary() =>
            employees.FindAll(e => e.salary);

        public List<Employee> GetTotalCost() =>
            employees.Count(e => e.salary is < 3500 and > 5000);

        public List<Employee> GetCostForDepartment() =>
            employees.Count(e => e.Department);

        public void IncreaseSalarry()
        {

        }
    }
}
