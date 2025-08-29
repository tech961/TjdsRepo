namespace Rs.Application.Features.Pets.CommandHandlers.UpdatePet;

public sealed record UpdatePetCommand(
    Guid Id,
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
) : ICommand<UpdatePetResponse>;
