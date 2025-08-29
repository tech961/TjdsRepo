using Rs.Domain.Aggregates.Pets;

namespace Rs.Application.Features.Pets.CommandHandlers.UpdatePet;

public class UpdatePetCommandHandler(IDataContext context, IMapper mapper, ILogger<UpdatePetCommandHandler> logger)
    : ICommandHandler<UpdatePetCommand, UpdatePetResponse>
{
    public async Task<Result<UpdatePetResponse>> Handle(UpdatePetCommand request, CancellationToken cancellationToken)
    {
        var pet = await context.Pets.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
        if (pet == null)
        {
            return Result.Failure<UpdatePetResponse>(PetErrors.NotFound);
        }

        pet.Name = request.Name;
        pet.PhotoUrl = request.PhotoUrl;
        pet.BirthDate = request.BirthDate;
        pet.Species = request.Species;
        pet.Breed = request.Breed;
        pet.Gender = request.Gender;
        pet.WeightKg = request.WeightKg;
        pet.HealthStatus = request.HealthStatus;
        pet.VaccinationStatus = request.VaccinationStatus;
        pet.Country = request.Country;
        pet.City = request.City;
        pet.OwnerId = request.OwnerId;
        pet.UpdatedAt = DateTime.UtcNow;

        await context.SaveChangesAsync(cancellationToken);

        var response = mapper.Map<UpdatePetResponse>(pet);
        return response;
    }
}
