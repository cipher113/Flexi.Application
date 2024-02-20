using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flexi.Application.Core.Aggregates.LectureAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexi.Application.Infrastructure.Data.Config;
public class LectureConfiguration : IEntityTypeConfiguration<Lecture>
{
  public void Configure(EntityTypeBuilder<Lecture> builder)
  {
    builder.ToTable("Lectures");

    builder.Property(l => l.SubjectId).IsRequired();
    builder.Property(l => l.LectureTheatreId).IsRequired();
    builder.Property(l => l.Day).IsRequired();
    builder.Property(l => l.Time).IsRequired();
    builder.Property(l => l.Duration).IsRequired();

    builder.HasOne(l => l.Subject)
        .WithMany(s => s.Lectures)
        .HasForeignKey(l => l.SubjectId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.HasOne(l => l.LectureTheatre)
        .WithMany(lt => lt.Lectures)
        .HasForeignKey(l => l.LectureTheatreId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
