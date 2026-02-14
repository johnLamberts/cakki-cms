using Cakki.Domains.Common;
using Cakki.Domains.Enums;


namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Permission entity for granular access control
    /// </summary>
    public class Permission : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Resource { get; set; } = string.Empty; // e.g., "Content", "Pages", "Media"
        public string Action { get; set; } = string.Empty;   // e.g., "Create", "Read", "Update", "Delete"
        public PermissionScope Scope { get; set; } = PermissionScope.None;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

        public string FullPermission => $"{Resource}.{Action}.{Scope}";
    }
}
