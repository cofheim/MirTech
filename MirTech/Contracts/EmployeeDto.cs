namespace MirTech.Contracts;

public record EmployeeDto(
    int Id,
    string FullName,
    string Department,
    DateTime DateOfBirth,
    DateTime DateOfEmployment,
    decimal Salary
); 