namespace Sweeft.Configuration;

public class GenderEntityConfiguration : IEntityTypeConfiguration<GenderEntity>
{
    public void Configure(EntityTypeBuilder<GenderEntity> builder)
    {
        DefineGenderTable(builder);
        AddDataToGenderTable(builder);
    }

    private void DefineGenderTable(EntityTypeBuilder<GenderEntity> builder)
    {
        builder.ToTable("Genders");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("GenderId");

        builder.Property(x => x.Name)
            .HasMaxLength(50);

        builder.Property(x => x.Created_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Updated_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Deleted_at)
            .HasColumnType("datetime");
    }

    private void AddDataToGenderTable(EntityTypeBuilder<GenderEntity> builder) 
    {
       builder.HasData(GenderEnum.List.Select(x => new GenderEntity 
       {
           Id = x.Value,
           Name = x.Name,
           Created_at = DateTime.UtcNow
       }).ToList());
    }
}
