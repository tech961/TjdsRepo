namespace Rs.Domain.Aggregates.Pets;

public class ActivityRecord
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public double DistanceKm { get; set; } 
    public double DurationMinutes { get; set; } 
    public double CaloriesBurned { get; set; }
    public string Notes { get; set; }
}