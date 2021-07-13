using System;
using System.Threading;
using System.Threading.Tasks;
using BL.Service;
using Domain;
using MediatR;
using Persistence;
// using Persistence.Models;

namespace Application.Activities
{
  public class Details
  {
    public class Query : IRequest<Activity>
    {
      public Guid Id { get; set; }
    }

    public class Handler : IRequestHandler<Query, Activity>
    {
      // private readonly DataContext _context;
      // public Handler(DataContext context)
      // {
      //   _context = context;
      // }

      private readonly IActivityService _activityService;

      // // private readonly DataContext _context;

      // // public Handler(DataContext context)
      public Handler(IActivityService activityService)
      {
        // _context = context;
        _activityService = activityService;
      }

      public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
      {
        return await _activityService.GetActivityById(request.Id);
      }
    }

  }
}