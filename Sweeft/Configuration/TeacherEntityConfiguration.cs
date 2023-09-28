namespace Sweeft.Configuration;

public class TeacherEntityConfiguration : IEntityTypeConfiguration<TeacherEntity>
{
    public void Configure(EntityTypeBuilder<TeacherEntity> builder) 
    {
        DefineTeacherTable(builder);
    }

    private void DefineTeacherTable(EntityTypeBuilder<TeacherEntity> builder) 
    {
        builder.ToTable("Teachers");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("TeacherId");

        builder.Property(x => x.FirstName)
            .HasMaxLength(100);

        builder.Property(x => x.LastName)
            .HasMaxLength(100);

        builder.Property(x => x.Gender);

        builder.Property(x => x.Subject)
            .HasMaxLength(100);

        builder.Property(x => x.Created_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Updated_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Deleted_at)
            .HasColumnType("datetime");
    }
}
