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

var employee1 = new Employee()
{
    FirstName = "Ismoil",
    LastName = "Zainalov",
    BirthDate = DateTime.Now,
    Salary = 3000
};
var employee2 = new Employee()
{
    FirstName = "Mark",
    LastName = "John",
    BirthDate = DateTime.Now,
    Salary = 7000
};
departmentService.AddDepartments(department1);
departmentService.AddDepartments(department2);

employeeService.AddEmployees(employee1);
employeeService.AddEmployees(employee2);
List<Department> department = departmentService.GetDepartments();
foreach (var item in department)
{
    System.Console.WriteLine($"Name: {item.Name}, Description: {item.Description}");
}
List<Employee> employees = employeeService.GetEmployees();
foreach (var item in employees)
{
    System.Console.WriteLine($"FirstName: {item.FirstName}, LastName: {item.LastName}, Salary: {item.Salary}");
}
