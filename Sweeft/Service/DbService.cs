namespace Sweeft.Service;

public class DbService<TEntity> : IDbService
{
    private readonly SweeftContext _context;

    public DbService(SweeftContext context)
    {
        _context = context;
    }

    public List<TeacherEntity> GetTeachers() 
    {
        return _context.Teachers.Where(x => !x.Deleted_at.HasValue).ToList();
    }

    public List<TeacherEntity> GetAllTeachersByStudent(string studentName)
    {
        var student = _context.Pupiles.SingleOrDefault(p => p.FirstName == studentName);

        if (student == null)
        {
            return new List<TeacherEntity>();
        }

        var teachers = _context.Teachers
            .Where(teacher => teacher.TeacherPupils.Any(tp => tp.PupilId == student.Id))
            .Where(x => !x.Deleted_at.HasValue)
            .ToList();

        return teachers;
    }


    public bool Update(TEntity entity) 
    {
        if (entity == null) return false;
        _context.Add(entity);
        _context.SaveChanges();
        return true;
    }
}
