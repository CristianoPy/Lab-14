

using Lab_14;

var employee1 = new Employee()
{
    name = "John",
    salary = 4000.00,
    department = "Development"
};

var employee2 = new Employee()
{
    name = "Jack",
    salary = 5000.00,
    department = "Testing"
};

var employee3 = new Employee()
{
    name = "Mary",
    salary = 5500.00,
    department = "HR"
};

var employee4 = new Employee()
{
    name = "Cris",
    salary = 10000.00,
    department = "Maintenance"
};

var employee5 = new Employee()
{
    name = "Mark",
    salary = 7000.00,
    department = "Logistics"
};
Console.WriteLine(employee1);
Console.WriteLine(employee2);
Console.WriteLine(employee3);
Console.WriteLine(employee4);
Console.WriteLine(employee5);

var eM = new Employee_Management();

eM.AddEmployee();
eM.RemoveEmployee();
eM.GetNoWellPayedEmployee();
eM.GetEmployeeByDepartment();
eM.GetMaxSalary();
eM.GetTotalCost();
eM.GetCostForDepartment();
eM.IncreaseSalarry();

