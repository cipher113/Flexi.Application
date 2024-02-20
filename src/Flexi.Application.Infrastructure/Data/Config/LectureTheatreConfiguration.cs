using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flexi.Application.Core.Aggregates.LectureTheatreAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Flexi.Application.Infrastructure.Data.Config;
public class LectureTheatreConfiguration : IEntityTypeConfiguration<LectureTheatre>
{
  public void Configure(EntityTypeBuilder<LectureTheatre> builder)
  {
    builder.ToTable("LectureTheatres");

    builder.Property(lt => lt.Name).IsRequired();
    builder.Property(lt => lt.Capacity).IsRequired();

    builder.HasMany(lt => lt.Lectures)
        .WithOne(l => l.LectureTheatre)
        .HasForeignKey(l => l.LectureTheatreId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
