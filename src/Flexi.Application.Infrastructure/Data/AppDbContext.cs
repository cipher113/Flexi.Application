using System.Reflection;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.ContributorAggregate;
using Flexi.Application.Core.Aggregates.LectureAggregate;
using Flexi.Application.Core.Aggregates.LectureTheatreAggregate;
using Flexi.Application.Core.Aggregates.StudentAggregate;
using Flexi.Application.Core.Aggregates.SubjectAggregate;
using Microsoft.EntityFrameworkCore;

namespace Flexi.Application.Infrastructure.Data;
public class AppDbContext : DbContext
{
  private readonly IDomainEventDispatcher? _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options,
    IDomainEventDispatcher? dispatcher)
      : base(options)
  {
    _dispatcher = dispatcher;
  }

  public DbSet<Contributor> Contributors => Set<Contributor>();
  public DbSet<Lecture> Lectures => Set<Lecture>();
  public DbSet<LectureTheatre> LectureTheatres => Set<LectureTheatre>();
  public DbSet<Enrollment> Enrollments => Set<Enrollment>();
  public DbSet<Student> Students => Set<Student>();
  public DbSet<Subject> Subjects => Set<Subject>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null) return result;

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges()
  {
    return SaveChangesAsync().GetAwaiter().GetResult();
  }
}
