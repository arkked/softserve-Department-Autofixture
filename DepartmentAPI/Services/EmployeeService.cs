using DepartmentAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace DepartmentAPI.Services
{

    public class EmployeeService : IEmployeeService
    {
        private readonly IDepartmentService _departmentService;

        public EmployeeService(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }


        public IEnumerable<string> GetEmployeesNames(Department department)
        {

            var employees = _departmentService.GetEmployees().Where(e => e.DepartmentId == department.Id);

            var employeesNames = new List<string>();

            employeesNames.Add(employees
                .Where(e => e.Name.StartsWith("Jan"))
                .GroupBy(e => e.Name)
                .ToString());

            //foreach (var employee in employees)
            //{
            //    employeesNames.Add(employee.Name);
            //}

            return employeesNames;
        }

        
    }
}
