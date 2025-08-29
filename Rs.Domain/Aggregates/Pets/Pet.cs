namespace Rs.Domain.Aggregates.Pets;

public class Pet: BaseAuditableEntity
{
    private static readonly List<VaccinationRecord> _vaccinations = [];
    private static readonly List<MedicalRecord> _medicalHistory = [];
    private static readonly List<ActivityRecord> _activities = [];
    
    public Pet(Guid id,
        string name,
        string photoUrl,
        DateTime? birthDate,
        string species,
        string breed,
        string gender,
        double? weightKg,
        string healthStatus,
        string vaccinationStatus, 
        string country,
        string city,
        Guid ownerId, 
        User owner, 
        bool isArchived)
    {
        Id = id;
        Name = name;
        PhotoUrl = photoUrl;
        BirthDate = birthDate;
        Species = species;
        Breed = breed;
        Gender = gender;
        WeightKg = weightKg;
        HealthStatus = healthStatus;
        VaccinationStatus = vaccinationStatus;
        Country = country;
        City = city;
        OwnerId = ownerId;
        Owner = owner;
        IsArchived = isArchived;
    }

    public new Guid Id { get; set; } 

    public string Name { get; set; }          
    public string PhotoUrl { get; set; }      
    public DateTime? BirthDate { get; set; }
    public string Species { get; set; } 
    public string Breed { get; set; }        
    public string Gender { get; set; }        

    public double? WeightKg { get; set; }   
    public string HealthStatus { get; set; }  
    public string VaccinationStatus { get; set; } 
    
    public string Country { get; set; }
    public string City { get; set; }
    
    public Guid OwnerId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool IsArchived { get; set; } = false;
    
    public IReadOnlyCollection<VaccinationRecord> Vaccinations { get; set; } = _vaccinations;
    public IReadOnlyCollection<MedicalRecord> MedicalHistory { get; set; } = _medicalHistory;
    public IReadOnlyCollection<ActivityRecord> Activities { get; set; } = _activities;
    public User Owner { get; set; }
}