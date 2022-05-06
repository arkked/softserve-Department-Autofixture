using DepartmentAPI.Models;
using System.Collections.Generic;

namespace DepartmentAPI.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IEmployeeService _employeeService;

        Department department = new Department()
        {
            Id = 1,
            Name = "Department 1",
            Employees = new List<Employee>()
            {
                new Employee() { Id = 1, DepartmentId = 1, Name = "Jan Kowalski", Salary = 2000 },
                new Employee() { Id = 2, DepartmentId = 1, Name = "Adam Nowak", Salary = 3000 },
                new Employee() { Id = 3, DepartmentId = 1, Name = "Michal Robak", Salary = 5000 }
            }
        };

 
        public DepartmentService(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return department.Employees;
        }

        string IDepartmentService.GetDepartmentName()
        {
            return department.Name;
        }

        public IEnumerable<string> GetEmployeesNames()
        {
            return _employeeService.GetEmployeesNames(department);
        }


    }
}
