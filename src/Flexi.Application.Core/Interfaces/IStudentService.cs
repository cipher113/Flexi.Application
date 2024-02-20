using Ardalis.Result;

namespace Flexi.Application.Core.Interfaces;
public interface IStudentService
{
  public Task<Result> DeleteStudent(int studentId);
}
