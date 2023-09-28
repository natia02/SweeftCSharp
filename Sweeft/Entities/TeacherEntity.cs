namespace Sweeft.Entities;

public class TeacherEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Gender { get; set; }
    public string Subject { get; set; } = null!;
    public DateTime Created_at { get; set; }
    public DateTime? Updated_at { get; set; }
    public DateTime? Deleted_at { get; set; }

    public virtual List<TeacherPupilEntity> TeacherPupils { get; set; } = null!;
}
