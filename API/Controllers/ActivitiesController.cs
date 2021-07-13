using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
// using Application.Models;
// using Persistence.Models;
using Microsoft.AspNetCore.Mvc;
using Domain;

namespace API.Controllers
{

  public class ActivitiesController : BaseApiController
  {
    // private readonly IMediator _mediator;

    // // private readonly DataContext _context;
    // public ActivitiesController(IMediator mediator)
    // {
    //   //   this._context = context;
    //   _mediator = mediator;
    // }

    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
      //   return await _context.Activities.ToListAsync();
      return await Mediator.Send(new List.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(Guid id)
    {
      //   return await _context.Activities.FindAsync(id);
      return await Mediator.Send(new Details.Query { Id = id });
    }

    [HttpPost]
    public async Task<IActionResult> SaveActivity(Activity activity)
    {
      return Ok(await Mediator.Send(new Create.Command { Activity = activity }));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> EditActivity(Guid id, Activity activity)
    {
      activity.Id = id;
      return Ok(await Mediator.Send(new Edit.Command { Activity = activity }));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteActivity(Guid id)
    {
      return Ok(await Mediator.Send(new Delete.Command { Id = id }));
    }
  }
}