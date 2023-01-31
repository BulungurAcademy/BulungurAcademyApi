namespace BulungurAcademy.Domain.Entities.Common;

public class Auditable
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
