using System;
using System.Collections.Generic;
using System.Threading.Tasks;
// using BL.Models;
// using Persistence.Models;
using Domain;

namespace BL.Service
{
    public interface IActivityService
    {
        List<Activity> GetAllActivitiesAsync();

        Task<Activity> GetActivityById(Guid id);

        Task<Activity> AddActivityAsync(Activity activity);

        Task<Activity>  UpdateActivityAsync(Activity activity);

        Task<Activity>  DeleteActivityAsync(Activity activity);
    }
}