namespace Sweeft.Configuration;

public class TeacherPupilEntityConfiguration : IEntityTypeConfiguration<TeacherPupilEntity>
{
    public void Configure(EntityTypeBuilder<TeacherPupilEntity> builder)
    {
        DefinteTeacherPupilTable(builder);
    }

    private void DefinteTeacherPupilTable(EntityTypeBuilder<TeacherPupilEntity> builder) 
    {
        builder.ToTable("TeacherPupiles");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("TeacherPupilId");

        builder.HasOne(x => x.Teacher)
            .WithMany(x => x.TeacherPupils)
            .HasForeignKey(x => x.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Pupil)
            .WithMany(x => x.TeacherPupils)
            .HasForeignKey(x => x.PupilId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(x => x.Created_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Updated_at)
            .HasColumnType("datetime");

        builder.Property(x => x.Deleted_at)
            .HasColumnType("datetime");
    }
}
