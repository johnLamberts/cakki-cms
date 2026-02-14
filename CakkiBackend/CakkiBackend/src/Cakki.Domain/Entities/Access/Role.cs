using Microsoft.AspNetCore.Identity;

namespace Cakki.Domain.Entities.Access;

public class Role : IdentityUser<Guid>
{
    public string? Description { get; set; }
    public bool IsSystemRole { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsActive { get; set; } = true;

    // Navigation properties
    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

}