using Cakki.Domains.Enums;
using Microsoft.AspNetCore.Identity;

namespace Cakki.Domains.Entities.Auth;

/// <summary>
/// User entity extending ASP.NET Core Identity
/// </summary>
public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? ProfilePictureUrl { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? LastLoginAt { get; set; }
    public string? LastLoginIp { get; set; }
    public string? LastLoginLocation { get; set; }

    // MFA Settings
    public bool IsMfaEnabled { get; set; }
    public MfaType PreferredMfaType { get; set; } = MfaType.None;

    // Soft delete
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }

    // Navigation properties
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    public virtual ICollection<UserSession> Sessions { get; set; } = new List<UserSession>();
    public virtual ICollection<MfaMethod> MfaMethods { get; set; } = new List<MfaMethod>();
    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    public string FullName => $"{FirstName} {LastName}".Trim();
}