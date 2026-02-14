
using Cakki.Domain.Common;

namespace Cakki.Domain.Entities.Auth
{
    public class RefreshTokens : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string? RevokedById { get; set; }
        public string? ReplacedByToken { get; set; }
        public string? ReasonRevoked { get; set; }

        // Device Information - again this is one of the knowledge i gathered though.
        public string? DeviceId { get; set; }
        public string? DeviceName { get; set; }
        public string? UserAgent { get; set; }
        public string? IpAddress { get; set; }

        // Navigation Properties
        public virtual User User { get; set; } = null!;

        public bool IsActive => !IsRevoked && DateTime.UtcNow < ExpiresAt;
        public bool IsExpired => DateTime.UtcNow >= ExpiresAt;
    }
}
