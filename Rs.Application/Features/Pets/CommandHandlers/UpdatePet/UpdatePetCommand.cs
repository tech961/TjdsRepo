namespace Rs.Application.Features.Pets.CommandHandlers.UpdatePet;

using Microsoft.AspNetCore.Http;

public sealed record UpdatePetCommand(
    Guid Id,
    string Name,
    IFormFile? Photo,
    DateTime? BirthDate,
    string Species,
    string Breed,
    string Gender,
    double? WeightKg,
    string HealthStatus,
    string VaccinationStatus,
    string Country,
    string City
) : ICommand<UpdatePetResponse>;
