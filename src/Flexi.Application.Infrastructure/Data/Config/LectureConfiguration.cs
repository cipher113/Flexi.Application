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

    builder.OwnsOne(l => l.TimeSlot, ts =>
    {
      ts.Property(ts => ts.Day).IsRequired();
      ts.Property(ts => ts.Time).IsRequired();
      ts.Property(ts => ts.Duration).IsRequired();
    });

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
