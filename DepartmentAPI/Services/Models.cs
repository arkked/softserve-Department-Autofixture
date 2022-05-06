namespace DepartmentAPI.Services
{
    public interface IAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }

    }

    public interface IEmployee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HourAmount { get; set; }

    }

    public interface ISalary
    {
        public int SalaryID { get; set; }
        public int EmployeeID { get; set; }
        public double hourlyWage { get; set; }

    }
}
