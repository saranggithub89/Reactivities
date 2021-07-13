using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
// using Application.Models;
// using Application.Models;
using BL.Service;
using Domain;
using MediatR;
// using Microsoft.EntityFrameworkCore;
// using Domain;
// using Persistence.Models; 

namespace Application.Activities
{
  public class List
  {
    // public readonly IActivityService _activityService;
    // public List(IActivityService activityService)
    // {
    //   _activityService = activityService;
    // }
    

    public class Query : IRequest<List<Activity>> { }


    public class Handler : IRequestHandler<Query, List<Activity>>
    {
      private readonly IActivityService _activityService;

      // // private readonly DataContext _context;

      // // public Handler(DataContext context)
      public Handler(IActivityService activityService)
      {
        // _context = context;
        _activityService = activityService;
      }

      public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
      {

        // return await _context.Activities.ToListAsync();
        return await Task.FromResult(_activityService.GetAllActivitiesAsync());
      }
    }
  }
}