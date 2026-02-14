using Cakki.Domain.Common;
using Cakki.Domain.Enums;

namespace Cakki.Domain.Entities.Access
{
    public class Permission : BaseEntity
    {

        public string Name { get; set; } = string.Empty;
        public string Resources { get; set; } = string.Empty; // Content, Pages, Media
        public string Action { get; set; } = string.Empty;  // Create, Read, Update, Delete
        public PermissionScope Scope { get; set; } = PermissionScope.None;

        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

        public string FullPermission => $"{Resources}.{Action}.{Scope}";

    }
}
