using System;

namespace BL.Models
{
  /// <summary>
  /// Specifies the fields for an Activity
  /// </summary>
  public class Activity
  {   
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string City { get; set; }
    public string Venue { get; set; }
  }
}