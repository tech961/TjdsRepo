namespace Rs.Domain.Aggregates.Pets;

public class MedicalRecord
{
    public Guid Id { get; set; }
    public string Condition { get; set; }
    public string Treatment { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; }
}