using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{

  public class ActivitiesController : BaseApiController
  {
    private readonly DataContext _context;
    public ActivitiesController(DataContext context)
    {
      this._context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
      return await _context.Activities.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(Guid id)
    {
      return await _context.Activities.FindAsync(id);
    }

    [HttpPost]
    public async Task<int> SaveActivity(Activity activity)
    {
      var savedActivity = await _context.Activities.AddAsync(activity);
      return await _context.SaveChangesAsync();
    }

    [HttpDelete]
    public int DeleteActivity(Activity activity)
    {        
      _context.Activities.Remove(activity);
      _context.SaveChanges();
      return 1;
    }
  }
}