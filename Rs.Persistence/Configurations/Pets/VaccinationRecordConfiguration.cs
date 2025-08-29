using Rs.Domain.Aggregates.Pets;

namespace Rs.Persistence.Configurations.Pets;

public class VaccinationRecordConfiguration : IEntityTypeConfiguration<VaccinationRecord>
{
    public void Configure(EntityTypeBuilder<VaccinationRecord> builder)
    {
        builder.HasKey(vr => vr.Id);

        builder.HasOne(vr => vr.Pet)
            .WithMany(p => p.Vaccinations)
            .HasForeignKey(vr => vr.PetId);

        builder.ToTable("VaccinationRecords", SchemaConfig.Pet);
    }
}
