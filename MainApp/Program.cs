using Domain.Models;
using Infrastructure.Services;

DepartmentService departmentService = new DepartmentService();
EmployeeService employeeService = new EmployeeService();
var department1 = new Department()
{
    Name = "Ismoil",
    Description = "Developer",
};
var department2 = new Department()
{
    Name = "Yusuf",
    Description = "Architecture",
};

DateTime date1 = new DateTime(2010, 07, 03);
var employee1 = new Employee()
{
    FirstName = "Ismoil",
    LastName = "Zainalov",
    BirthDate = date1,
    Salary = 3000
};
DateTime date2 = new DateTime(2007, 11, 22);

var employee2 = new Employee()
{
    FirstName = "Mark",
    LastName = "John",
    BirthDate = date2,
    Salary = 7000
};
departmentService.AddDepartments(department1);
departmentService.AddDepartments(department2);

employeeService.AddEmployees(employee1);
employeeService.AddEmployees(employee2);
List<Department> department = departmentService.GetDepartments();
Console.WriteLine("Department");
foreach (var item in department)
{
    System.Console.WriteLine($"Name: {item.Name}, Description: {item.Description}");
}
List<Employee> employees = employeeService.GetEmployees();
Console.WriteLine("Employee");

foreach (var item in employees)
{
    System.Console.WriteLine($"FirstName: {item.FirstName}, LastName: {item.LastName}, Salary: {item.Salary} , BirthDay: {item.BirthDate}");
}
int countDepartments = departmentService.CountDepartments();
System.Console.WriteLine(countDepartments);
int countEmployee = employeeService.CountEmployees();
System.Console.WriteLine(countEmployee);
