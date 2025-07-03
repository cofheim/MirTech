namespace MirTech.Core.Models;

public class Employee
{
    public int Id { get; set; }
    public required string FullName { get; set; }
    public required string Department { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public decimal Salary { get; set; }
} 