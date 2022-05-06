using DepartmentAPI.Models;
using System.Collections;
using System.Collections.Generic;

namespace DepartmentAPI.Services
{
    public interface IEmployeeService
    {
        IEnumerable<string> GetEmployeesNames(Department department);

    }
}
