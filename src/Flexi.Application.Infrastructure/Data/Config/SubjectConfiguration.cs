using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flexi.Application.Core.Aggregates.SubjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexi.Application.Infrastructure.Data.Config;
public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
  public void Configure(EntityTypeBuilder<Subject> builder)
  {
    builder.ToTable("Subjects");

    builder.Property(s => s.Name).IsRequired();

    builder.HasMany(s => s.Lectures)
        .WithOne(l => l.Subject)
        .HasForeignKey(l => l.SubjectId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
