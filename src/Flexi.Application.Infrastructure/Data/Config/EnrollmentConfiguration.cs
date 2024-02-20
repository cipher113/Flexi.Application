using Flexi.Application.Core.Aggregates.SubjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexi.Application.Infrastructure.Data.Config;
public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
  public void Configure(EntityTypeBuilder<Enrollment> builder)
  {
    builder.ToTable("Enrollments");

    builder.HasOne(e => e.Student)
        .WithMany(s => s.Enrollments)
        .HasForeignKey(e => e.StudentId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.HasOne(e => e.Subject)
        .WithMany(s => s.Enrollments)
        .HasForeignKey(e => e.SubjectId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
