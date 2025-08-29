using Rs.Domain.Aggregates.Pets;

namespace Rs.Application.Features.Pets.CommandHandlers.AddPet;

public class AddPetCommandHandler(IDataContext context, IMapper mapper, ILogger<AddPetCommandHandler> logger)
    : ICommandHandler<AddPetCommand, AddPetResponse>
{
    public async Task<Result<AddPetResponse>> Handle(AddPetCommand request, CancellationToken cancellationToken)
    {
        var pet = new Pet(Guid.NewGuid(),
            request.Name,
            request.PhotoUrl,
            request.BirthDate,
            request.Species,
            request.Breed,
            request.Gender,
            request.WeightKg,
            request.HealthStatus,
            request.VaccinationStatus,
            request.Country,
            request.City,
            request.OwnerId,
            null!,
            false);

        await context.Pets.AddAsync(pet, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        var response = mapper.Map<AddPetResponse>(pet);
        return response;
    }
}
