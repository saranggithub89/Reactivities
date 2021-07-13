using System.Threading;
using System.Threading.Tasks;
using BL.Service;
using Domain;
using MediatR;
// using Persistence;
// using Persistence.Models;

namespace Application.Activities
{
  public class Create
  {
    public class Command : IRequest
    {
      public Activity Activity { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
      private readonly IActivityService _activityService;
      // private readonly DataContext _context;

      public Handler(IActivityService activityService)
      {
        // _context = context;
        _activityService = activityService;
      }

      public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
      {
        // _context.Activities.Add(request.Activity);
        // await _context.SaveChangesAsync();
        // return Unit.Value;
         await _activityService.AddActivityAsync(request.Activity);
         return Unit.Value;
      }
    }
  }
}