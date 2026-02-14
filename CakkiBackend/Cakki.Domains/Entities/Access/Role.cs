using Microsoft.AspNetCore.Identity;

namespace Cakki.Domains.Entities.Auth
{
    /// <summary>
    /// Role entity for Role-Based Access Control
    /// </summary>
    public class Role : IdentityRole<Guid>
    {
        public string? Description { get; set; }
        public bool IsSystemRole { get; set; } // Cannot be deleted (Admin, Editor, etc.)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    }
}
