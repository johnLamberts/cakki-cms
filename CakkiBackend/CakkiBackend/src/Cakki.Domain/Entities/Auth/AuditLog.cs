using Cakki.Domain.Common;
using Cakki.Domain.Entities.Auth;
using Cakki.Domain.Enums;

namespace Cakki.Domain.Entities.Auth
{
    /// <summary>
    /// Immutable audit log for all system actions
    /// </summary>
    public class AuditLog : BaseEntity
    {
        public Guid? UserId { get; set; }
        public string? UserName { get; set; }
        public AuditAction Action { get; set; }
        public string EntityName { get; set; } = string.Empty;
        public string? EntityId { get; set; }
        public string? OldValues { get; set; } // JSON
        public string? NewValues { get; set; } // JSON
        public string IpAddress { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        public string? AdditionalData { get; set; } // JSON for extra context
        public bool Success { get; set; } = true;
        public string? ErrorMessage { get; set; }

        // Navigation properties
        public virtual User? User { get; set; }
    }
}
