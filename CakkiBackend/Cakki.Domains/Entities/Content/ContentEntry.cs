using Cakki.Domains.Common;
using Cakki.Domains.Enums;

namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Content entry instance (actual content data)
    /// </summary>
    public class ContentEntry : BaseEntity
    {
        public Guid ContentTypeId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public ContentStatus Status { get; set; } = ContentStatus.Draft;

        // Publishing
        public DateTime? PublishedAt { get; set; }
        public DateTime? ScheduledPublishAt { get; set; }
        public Guid? PublishedBy { get; set; }

        // Versioning
        public int Version { get; set; } = 1;
        public Guid? ParentVersionId { get; set; }
        public bool IsLatestVersion { get; set; } = true;

        // Localization
        public string? Locale { get; set; }
        public Guid? LocalizationParentId { get; set; }

        // Locking
        public bool IsLocked { get; set; }
        public Guid? LockedBy { get; set; }
        public DateTime? LockedAt { get; set; }

        // Data stored as JSON (flexible schema)
        public string Data { get; set; } = "{}";

        // SEO
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }

        // Navigation properties
        public virtual ContentType ContentType { get; set; } = null!;
        public virtual ICollection<ContentVersion> Versions { get; set; } = new List<ContentVersion>();
    }

}
