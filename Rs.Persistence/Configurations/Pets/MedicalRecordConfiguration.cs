using Rs.Domain.Aggregates.Pets;

namespace Rs.Persistence.Configurations.Pets;

public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
{
    public void Configure(EntityTypeBuilder<MedicalRecord> builder)
    {
        builder.HasKey(mr => mr.Id);

        builder.HasOne(mr => mr.Pet)
            .WithMany(p => p.MedicalHistory)
            .HasForeignKey(mr => mr.PetId);

        builder.ToTable("MedicalRecords", SchemaConfig.Pet);
    }
}
