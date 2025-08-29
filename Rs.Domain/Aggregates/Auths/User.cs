using Microsoft.AspNetCore.Identity;

namespace Rs.Domain.Aggregates.Auths;

public class User : IdentityUser<Guid>
{
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }

    public Guid? ProfilePicId { get; private set; }

    public void UpdateUser(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void UpdateProfilePic(Guid profilePicId)
    {
        ProfilePicId = profilePicId;
    }
}