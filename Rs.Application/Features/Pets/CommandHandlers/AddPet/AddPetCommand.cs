namespace Rs.Application.Features.Pets.CommandHandlers.AddPet;

public sealed record AddPetCommand(
    string Name,
    string PhotoUrl,
    DateTime? BirthDate,
    string Species,
    string Breed,
    string Gender,
    double? WeightKg,
    string HealthStatus,
    string VaccinationStatus,
    string Country,
    string City,
    Guid OwnerId
) : ICommand<AddPetResponse>;
