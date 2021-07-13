using System;
using System.Threading;
using System.Threading.Tasks;
using BL.Service;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
  public class Delete : IRequest
  {
    public class Command : IRequest
    {
      public Guid Id { get; set; }
      public Activity Activity { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
      // private readonly DataContext _context;
      private readonly IActivityService _activityService;
      public Handler(IActivityService activityService)
      {
        _activityService = activityService;
        // _context = context;
      }

      public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
      {
        var activity = await _activityService.GetActivityById(request.Id);        
        await _activityService.DeleteActivityAsync(activity);
        return Unit.Value;

        // var activity = await _activityService.GetActivityById(request.Id);        
        // await _activityService.DeleteActivityAsync(request.Id);
        // return Unit.Value;
      }
    }
  }
}