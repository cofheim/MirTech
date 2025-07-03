using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MirTech.Core.Models;

namespace MirTech.DataAccess.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Department)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.DateOfBirth)
                .IsRequired();

            builder.Property(e => e.DateOfEmployment)
                .IsRequired();

            builder.Property(e => e.Salary)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");
        }
    }
} 