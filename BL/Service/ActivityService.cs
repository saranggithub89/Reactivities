using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using BL.Models;
using Domain;
using Persistence.Repositories;
// using Persistence.Models;
// using Persistence.Repositories;

namespace BL.Service
{
  public class ActivityService : IActivityService
  {
    private readonly IActivityRepository _activityRepository;
    public ActivityService(IActivityRepository activityRepository)
    {
      _activityRepository = activityRepository;
    }

    public async Task<Activity> AddActivityAsync(Activity activity)
    {
      return await _activityRepository.AddAsync(activity);
    }

    public async Task<Activity> GetActivityById(Guid id)
    {
      return  await Task.FromResult(_activityRepository.GetAll().Where(wh => wh.Id == id).FirstOrDefault());
    }

    public List<Activity> GetAllActivitiesAsync()
    {
      return _activityRepository.GetAll().ToList();
    }

    public async Task<Activity> UpdateActivityAsync(Activity activity)
    {
      return await _activityRepository.UpdateAsync(activity);
    }

    public async Task<Activity> DeleteActivityAsync(Activity activity)
    {
      return await _activityRepository.DeleteAsync(activity);
    }
  }

}