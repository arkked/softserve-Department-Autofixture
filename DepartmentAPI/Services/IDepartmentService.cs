using DepartmentAPI.Models;
using System.Collections.Generic;

namespace DepartmentAPI.Services
{
    public interface IDepartmentService
    {  
        string GetDepartmentName();

        IEnumerable<Employee> GetEmployees();
        
    }
}
