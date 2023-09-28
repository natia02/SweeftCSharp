namespace Sweeft.Entities;

public class GenderEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime Created_at { get; set; }
    public DateTime? Updated_at { get; set; }
    public DateTime? Deleted_at { get; set; }
}
