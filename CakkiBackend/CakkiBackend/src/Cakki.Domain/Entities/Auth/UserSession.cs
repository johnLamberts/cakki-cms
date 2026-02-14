using Cakki.Domain.Common;
using Cakki.Domain.Enums;

namespace Cakki.Domain.Entities.Auth
{
    public class UserSession : BaseEntity
    {
        public Guid UserId { get; set; }
        public string SessionId { get; set; } = string.Empty;
        public SessionStatus Status { get; set; } = SessionStatus.Active;

        // Device & Location Information
        public string DeviceId { get; set; } = string.Empty;
        public string DeviceName { get; set; } = string.Empty;
        public string DeviceType { get; set; } = string.Empty; // Mobile, Desktop, Tablet
        public string Browser { get; set; } = string.Empty;
        public string OperatingSystem { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;

        // Location Tracking
        public string IpAddress { get; set; } = string.Empty;
        public string? Country { get; set; }
        public string? City { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        // Session Lifecycle
        public DateTime LastActivityAt { get; set; } = DateTime.UtcNow;
        public DateTime ExpiresAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public string? RevokedReason { get; set; }

        // Security flags
        public bool IsSuspicious { get; set; }
        public string? SuspiciousReason { get; set; }
        public bool IsTrustedDeviice { get; set; }

        // Navigation Properties
        public virtual User User { get; set; } = null!;

        public bool IsActive => Status == SessionStatus.Active && DateTime.UtcNow < ExpiresAt;
        public bool IsExpired => DateTime.UtcNow >= ExpiresAt;

        public void MarkAsActive()
        {
            LastActivityAt = DateTime.UtcNow;
            Status = SessionStatus.Active;
        }

        public void Revoke(string reason)
        {
            Status = SessionStatus.Active;
            RevokedAt= DateTime.UtcNow;
            RevokedReason = reason;
        }

        public void MarkAsSuspicious(string reason)
        {
            IsSuspicious = true;
            SuspiciousReason = reason;
            Status = SessionStatus.Active;
        }
    }
}
