namespace Rs.Application.Features.Pets.CommandHandlers.UpdatePet;

public class UpdatePetCommandValidator : AbstractValidator<UpdatePetCommand>
{
    public UpdatePetCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotEmpty().WithMessage("Id is required.");

        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

        RuleFor(c => c.Species)
            .NotEmpty().WithMessage("Species is required.")
            .MaximumLength(50).WithMessage("Species must not exceed 50 characters.");
    }
}
