using Cakki.Domains.Common;

namespace Cakki.Domains.Entities.Auth
{
    /// <summary>
    /// Refresh token for secure token rotation (BFF pattern)
    /// </summary>
    public class RefreshToken : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string? RevokedByIp { get; set; }
        public string? ReplacedByToken { get; set; }
        public string? ReasonRevoked { get; set; }

        // Device information
        public string? DeviceId { get; set; }
        public string? DeviceName { get; set; }
        public string? UserAgent { get; set; }
        public string? IpAddress { get; set; }

        // Navigation properties
        public virtual User User { get; set; } = null!;

        public bool IsActive => !IsRevoked && DateTime.UtcNow < ExpiresAt;
        public bool IsExpired => DateTime.UtcNow >= ExpiresAt;
    }

}
