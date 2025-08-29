namespace Rs.Domain.Aggregates.Pets;

public abstract class VaccinationRecord
{
    public Guid Id { get; set; }
    public string VaccineName { get; set; }
    public DateTime Date { get; set; }
    public DateTime? NextDueDate { get; set; }
    public string Notes { get; set; }
}