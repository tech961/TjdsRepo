using Microsoft.EntityFrameworkCore;
using Rs.Domain.Aggregates.Blogs;
using Rs.Domain.Aggregates.Files;
using Rs.Domain.Aggregates.Provinces;
using Rs.Domain.Aggregates.Pets;

namespace Rs.Domain.Common.Interfaces;

public interface IDataContext
{
    public DbSet<User> Users { get; set; }
    DbSet<Blog> Blogs { get; }

    DbSet<UserVerificationCode> UserVerificationCodes { get; }

    DbSet<Province> Provinces { get; }
    
    DbSet<City> Cities { get; }
    
    DbSet<District> Districts { get; }
    
    DbSet<Neighborhood> Neighborhoods { get; }

    DbSet<FileManager> FileManagers { get; }
    DbSet<Pet> Pets { get; }
    int SaveChanges();

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}