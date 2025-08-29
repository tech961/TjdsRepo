using Rs.Domain.Aggregates.Pets;

namespace Rs.Application.Features.Pets.CommandHandlers.UpdatePet;

[AutoMap(typeof(Pet))]
public sealed class UpdatePetResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PhotoUrl { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public string Gender { get; set; }
    public double? WeightKg { get; set; }
    public string HealthStatus { get; set; }
    public string VaccinationStatus { get; set; }
    public Guid OwnerId { get; set; }
    public bool IsArchived { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
