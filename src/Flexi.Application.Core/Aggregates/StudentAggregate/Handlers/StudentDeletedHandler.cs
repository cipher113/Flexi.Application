using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flexi.Application.Core.Aggregates.ContributorAggregate.Events;
using Flexi.Application.Core.Aggregates.ContributorAggregate.Handlers;
using Flexi.Application.Core.Aggregates.StudentAggregate.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Flexi.Application.Core.Aggregates.StudentAggregate.Handlers;
internal class StudentDeletedHandler(ILogger<StudentDeletedHandler> _logger) : INotificationHandler<StudentDeletedEvent>
{
  public async Task Handle(StudentDeletedEvent domainEvent, CancellationToken cancellationToken)
  {
    _logger.LogInformation("Handling Contributed Deleted event for {contributorId}", domainEvent.StudentId);

    await Task.Delay(1);
  }
}
