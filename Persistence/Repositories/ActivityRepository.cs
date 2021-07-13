using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
// using Persistence.Models;

namespace Persistence.Repositories
{
  public class ActivityRepository : Repository<Activity>, IActivityRepository
  {
    public ActivityRepository(DataContext context) : base(context)
    {
    }

    // public async Task<Activity> GetActivityByIdAsync(Guid id)
    // {
    //   return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
    // }

    // public async Task<List<Activity>> GetAllActivitiesAsync()
    // {
    //   return await GetAll().ToListAsync();
    // }

    // public async Task<Activity> UpdateActivityAsync(Activity activity) 
    // {
    //     return await UpdateAsync(activity);
    // }
  }
}