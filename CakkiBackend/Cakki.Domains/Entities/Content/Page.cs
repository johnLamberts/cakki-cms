using Cakki.Domains.Common;
using Cakki.Domains.Enums;

namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Page entity for visual editor
    /// </summary>
    public class Page : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public ContentStatus Status { get; set; } = ContentStatus.Draft;

        // Visual editor data (JSON structure of components and layout)
        public string Layout { get; set; } = "{}";
        public string? MobileLayout { get; set; }
        public string? TabletLayout { get; set; }

        // SEO
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }
        public string? OgImage { get; set; }

        // Publishing
        public DateTime? PublishedAt { get; set; }
        public DateTime? ScheduledPublishAt { get; set; }

        // Versioning
        public int Version { get; set; } = 1;
        public bool IsLatestVersion { get; set; } = true;

        // Locking
        public bool IsLocked { get; set; }
        public Guid? LockedBy { get; set; }
        public DateTime? LockedAt { get; set; }
        public string? LockedReason { get; set; }

        // Settings
        public bool IsHomePage { get; set; }
        public bool IsTemplate { get; set; }
        public Guid? TemplateId { get; set; }

        // Navigation properties
        public virtual ICollection<PageVersion> Versions { get; set; } = new List<PageVersion>();
        public virtual ICollection<PageComponent> Components { get; set; } = new List<PageComponent>();
    }
}
