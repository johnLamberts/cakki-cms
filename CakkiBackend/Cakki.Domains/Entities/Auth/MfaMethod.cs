using Cakki.Domains.Common;
using Cakki.Domains.Enums;

namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// MFA method configuration for a user (TOTP, FIDO2, etc.)
    /// </summary>
    public class MfaMethod : BaseEntity
    {
        public Guid UserId { get; set; }
        public MfaType Type { get; set; }
        public string Name { get; set; } = string.Empty; // User-friendly name (e.g., "iPhone 13")
        public bool IsEnabled { get; set; } = true;
        public bool IsPrimary { get; set; }

        // TOTP-specific
        public string? TotpSecret { get; set; }
        public string[]? BackupCodes { get; set; }

        // FIDO2-specific
        public byte[]? CredentialId { get; set; }
        public byte[]? PublicKey { get; set; }
        public int? SignatureCounter { get; set; }
        public string? AaGuid { get; set; } // Authenticator Attestation GUID

        // Usage tracking
        public DateTime? LastUsedAt { get; set; }
        public int UsageCount { get; set; }

        // Navigation properties
        public virtual User User { get; set; } = null!;
    }

}
