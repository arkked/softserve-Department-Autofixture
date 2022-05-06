using DepartmentAPI.Models;
using DepartmentAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DepartmentAPI.Controllers
{
    [ApiController]
    [Route("api/[department]")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;


        public DepartmentController(IDepartmentService departmentService, IEmployeeService employeeService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
 
        }

        [HttpGet]
        public ActionResult<Department> GetDepartmentName()
        {
            var department = _departmentService.GetDepartmentName();
            return Ok(department);
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetEmployeesNames(Department department)
        {
            if(department is null) throw new ArgumentNullException(nameof(department));

            var employees = _employeeService.GetEmployeesNames(department);

            if (employees is null) throw new ArgumentNullException(nameof(employees));

            return Ok(employees);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
