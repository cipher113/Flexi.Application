using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flexi.Application.Core.Aggregates.LectureAggregate;
using Flexi.Application.UseCases.Lectures;
using Flexi.Application.UseCases.Lectures.List;
using Microsoft.EntityFrameworkCore;

namespace Flexi.Application.Infrastructure.Data.Queries;
public class ListLecturesQueryService(AppDbContext _db) : IListLecturesQueryService
{
  public async Task<IEnumerable<LectureDTO>> ListAsync()
  {
    var result = await _db.Lectures.Include(x=>x.Subject).Include(x=>x.LectureTheatre).ToListAsync();
    var response = new List<LectureDTO>();
    foreach (var item in result)
    {
      response.Add(new LectureDTO(item.SubjectId, item.LectureTheatreId, item.Day, item.Time, item.Duration));
    }
    return response;
  }
}
