namespace Sweeft.Configuration;

public class PupilEntityConfiguration : IEntityTypeConfiguration<PupilEntity>
{
    public void Configure(EntityTypeBuilder<PupilEntity> builder)
    {
        DefinePupilTable(builder);
    }

    private void DefinePupilTable(EntityTypeBuilder<PupilEntity> builder)
    {
        builder.ToTable("Pupiles");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("PupilId");

        builder.Property(x => x.FirstName)
            .HasMaxLength(100);

        builder.Property(x => x.LastName)
            .HasMaxLength(100);

        builder.Property(x => x.Gender);

        builder.Property(x => x.Class);

        builder.Property(x => x.Created_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Updated_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Deleted_at)
            .HasColumnType("datetime");
    }
}
