using Domain;
using Microsoft.EntityFrameworkCore;
// using Persistence.Models;
namespace Persistence
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Activity> Activities { get; set; }
  }
}