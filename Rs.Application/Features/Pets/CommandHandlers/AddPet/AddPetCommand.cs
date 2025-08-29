namespace Rs.Application.Features.Pets.CommandHandlers.AddPet;

public sealed record AddPetCommand(
    string Name,
    IFormFile Photo,
    DateTime? BirthDate,
    string Species,
    string Breed,
    string Gender,
    double? WeightKg,
    string HealthStatus,
    string VaccinationStatus,
    string Country,
    string City
) : ICommand<AddPetResponse>;
