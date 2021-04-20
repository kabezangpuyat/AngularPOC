using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MNV.Domain.Entities;
using System;

namespace MNV.Database.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee", schema: "dbo").HasKey(x => x.ID);

            builder.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(e => e.Key).HasColumnName("Key").HasDefaultValue(Guid.NewGuid());
            builder.Property(e => e.UserID).HasColumnName("UserID").IsRequired(true);
            builder.Property(e => e.DepartmentID).HasColumnName("DepartmentID").IsRequired(true);
            builder.Property(e => e.EmployeeID).HasColumnName("EmployeeID").IsRequired(true);
            builder.Property(e => e.PhotoFileName).HasColumnName("PhotoFileName").IsRequired(true).HasMaxLength(150);
            builder.Property(e => e.StartDate).HasColumnName("StartDate").IsRequired(true);
            builder.Property(e => e.CreatedByID).HasColumnName("CreatedByID").IsRequired(false);
            builder.Property(e => e.ModifiedByID).HasColumnName("ModifiedByID").IsRequired(false);
            builder.Property(e => e.DateCreated).HasColumnName("DateCreated").HasDefaultValue(DateTimeOffset.Now);
            builder.Property(e => e.DateModified).HasColumnName("DateModified").IsRequired(false);
            builder.Property(e => e.Active).HasColumnName("Active").HasDefaultValue(true);

            builder.HasOne<User>(x => x.User)
                .WithOne(x=>x.Employee) 
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(true);

            builder.HasOne<Department>(x => x.Department)
                .WithMany(x=>x.Employees)
                .HasForeignKey(x => x.DepartmentID)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(true);
        }
    }
}
