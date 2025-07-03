using System.ComponentModel.DataAnnotations;

namespace MirTech.Contracts;

public record UpdateEmployeeRequest
{
    [Required]
    public required string FullName { get; init; }

    [Required]
    public required string Department { get; init; }

    [Required]
    public DateTime DateOfBirth { get; init; }

    [Required]
    public DateTime DateOfEmployment { get; init; }

    [Required]
    [Range(0, (double)decimal.MaxValue)]
    public decimal Salary { get; init; }
} 