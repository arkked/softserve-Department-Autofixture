using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using DepartmentAPI.Controllers;
using DepartmentAPI.Models;
using DepartmentAPI.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DepartmentTest
{
    public class DepartmentUnitTest
    {


        public class AutoNamingAttribute : AutoDataAttribute
        {
            public AutoNamingAttribute() : base(() => new Fixture().Customize(new AutoMoqCustomization()))
            {

            }
        }

        [Theory]
        [AutoNaming]
        public void GetEmployeesNames_ReturnNamesWithCondition_ResultOk([Frozen] Mock<IEmployeeService> employeeNameMock, Mock<IDepartmentService> departmentMock, Department department)
        {

            /* for example purposes */

            var employeesNames = new List<string>()
            {
                "Jan Kowalski",
                "Adam Nowak",
                "Michal Robak"
            };
    
            var sut = new DepartmentController(departmentMock.Object, employeeNameMock.Object);

            employeeNameMock.Setup(e => e.GetEmployeesNames(It.IsAny<Department>())).Returns(employeesNames);

            var result = sut.GetEmployeesNames(department);

            result.Should().BeOfType<ActionResult<IEnumerable<string>>>();

        }
    }
}
