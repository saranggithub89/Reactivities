using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BL.Service;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
  public class Edit
  {
    public class Command : IRequest
    {
      public Activity Activity { get; set; }
    }
    public class Handler : IRequestHandler<Command>
    {
      // private readonly DataContext _context;


      private readonly IMapper _mapper;

      private readonly IActivityService _activityService;

      public Handler(IActivityService activityService, IMapper mapper)
      {
        _mapper = mapper;
        _activityService = activityService;
        // _context = context;
      }

      public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
      {
        // var activity = await _context.Activities.FindAsync(request.Activity.Id);
        // _mapper.Map(request.Activity, activity);
        // // activity.Title = request.Activity.Title ?? activity.Title;
        // await _context.SaveChangesAsync();
        // return Unit.Value;
        var activity = await _activityService.GetActivityById(request.Activity.Id);
        _mapper.Map(request.Activity, activity);
        await _activityService.UpdateActivityAsync(activity);
        return Unit.Value;

      }
    }
  }
}