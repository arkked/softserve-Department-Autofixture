namespace DepartmentAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
