using Ardalis.Result;
using Ardalis.SharedKernel;
using Flexi.Application.Core.Aggregates.StudentAggregate;
using Flexi.Application.Core.Aggregates.StudentAggregate.Specifications;
using Flexi.Application.Core.Aggregates.SubjectAggregate;
using Flexi.Application.Core.Aggregates.SubjectAggregate.Specifications;

namespace Flexi.Application.UseCases.Subjects.Enroll;
internal class EnrollStudentHandler(IReadRepository<Student> _stdRepository, IRepository<Subject> _subRepository)
  : ICommandHandler<EnrollStudentCommand, Result<Subject>>
{
  public async Task<Result<Subject>> Handle(EnrollStudentCommand request, CancellationToken cancellationToken)
  {
    var subject = await _subRepository.FirstOrDefaultAsync(new SubjectByIdSpec(request.SubjectId), cancellationToken) ?? throw new Exception("Subject not found.");
    var student = await _stdRepository.FirstOrDefaultAsync(new StudentByIdSpec(request.StudentId), cancellationToken) ?? throw new Exception("Student not found.");

    var minCapacity = subject.Lectures.Min(l => l.LectureTheatre?.Capacity);
    var enrolledCount = subject.Enrollments.Count();

    if (enrolledCount >= minCapacity)
    {
      throw new Exception("Capacity is full.");
    }

    var totalHours = student.Enrollments.Sum(e => e.Subject!.Lectures.Sum(l => l.Duration));

    if (totalHours >= 10)
    {
      throw new Exception("Total weekly hours limit exceeded.");
    }

    subject.EnrollStudent(student.Id);
    await _subRepository.UpdateAsync(subject, cancellationToken);

    return subject;
  }
}
