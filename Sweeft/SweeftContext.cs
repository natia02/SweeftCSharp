namespace Sweeft;

public class SweeftContext : DbContext
{
    public SweeftContext(DbContextOptions<SweeftContext> options) : base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("ConnectionStringHoesHere");
        base.OnConfiguring(optionsBuilder);
    }

    public virtual DbSet<TeacherEntity> Teachers { get; set; } = null!;
    public virtual DbSet<PupilEntity> Pupiles { get; set; } = null!;
    public virtual DbSet<TeacherPupilEntity> TeacherPupiles { get; set; } = null!;
    public virtual DbSet<GenderEntity> Genders { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SweeftContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
