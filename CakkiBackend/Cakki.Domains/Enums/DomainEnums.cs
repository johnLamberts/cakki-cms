namespace Cakki.Domains.Enums;

/// <summary>
/// Content publishing status
/// </summary>
public enum ContentStatus
{
    Draft = 0,
    PendingReview = 1,
    Approved = 2,
    Scheduled = 3,
    Published = 4,
    Archived = 5,
    Rejected = 6
}

/// <summary>
/// Field data types for content schema
/// </summary>
public enum FieldType
{
    Text = 0,
    RichText = 1,
    Number = 2,
    Boolean = 3,
    Date = 4,
    DateTime = 5,
    Email = 6,
    Url = 7,
    Json = 8,
    Media = 9,
    Reference = 10,
    Color = 11,
    Location = 12,
    Dropdown = 13,
    MultiSelect = 14,
    Tags = 15
}

/// <summary>
/// MFA method types
/// </summary>
public enum MfaType
{
    None = 0,
    Totp = 1,      // Time-based One-Time Password (Authenticator apps)
    Fido2 = 2,     // WebAuthn/FIDO2 (biometric, security keys)
    Sms = 3,       // SMS (not recommended but supported)
    Email = 4      // Email codes
}

/// <summary>
/// Session status
/// </summary>
public enum SessionStatus
{
    Active = 0,
    Expired = 1,
    Revoked = 2,
    Suspicious = 3
}

/// <summary>
/// Audit action types
/// </summary>
public enum AuditAction
{
    Create = 0,
    Read = 1,
    Update = 2,
    Delete = 3,
    Login = 4,
    Logout = 5,
    FailedLogin = 6,
    PasswordChanged = 7,
    MfaEnabled = 8,
    MfaDisabled = 9,
    SessionRevoked = 10,
    PermissionChanged = 11,
    Published = 12,
    Unpublished = 13
}

/// <summary>
/// Permission scopes
/// </summary>
public enum PermissionScope
{
    None = 0,
    Own = 1,        // Only resources created by user
    Team = 2,       // Resources within user's team
    All = 3         // All resources
}