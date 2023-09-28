namespace Sweeft.Entities;

public class TeacherPupilEntity
{
    public Guid Id { get; set; }
    public Guid TeacherId { get; set; }
    public Guid PupilId { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime? Updated_at { get; set; }
    public DateTime? Deleted_at { get; set; }

    public virtual TeacherEntity Teacher { get; set; } = null!;
    public virtual PupilEntity Pupil { get; set; } = null!;

}
