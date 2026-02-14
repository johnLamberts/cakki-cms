using Microsoft.AspNetCore.Identity;
using Cakki.Domain.Enums;

using Cakki.Domain.Common;

namespace Cakki.Domain.Entities.Auth;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName{ get; set; } = string.Empty;

    public string? ProfilePictureUrl { get; set; }
    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; } 
    public DateTime? LastLoginAt { get; set; }

    public string LastLoginIp { get; set; }
    public string? LastLoginLocation { get; set; }


    public bool IsMfaEnabled { get; set; }
    public MfaType PrefferedMfaType { get; set; } = MfaType.None;

    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }

    // Navigation Properties
    public virtual ICollection<RefreshTokens> RefreshTokens { get; set; } = new List<RefreshTokens>();
    public virtual ICollection<UserSession> Sessions { get; set; } = new List<UserSession>();
    public virtual ICollection<MfaMethod> MfaMethods { get; set; } = new List<MfaMethod>();
    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    public string FulllName => $"{FirstName} {LastName}".Trim();
}
