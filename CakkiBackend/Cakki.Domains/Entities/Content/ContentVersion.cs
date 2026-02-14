using Cakki.Domains.Common;


namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Content version history for "time travel" functionality
    /// </summary>
    public class ContentVersion : BaseEntity
    {
        public Guid ContentEntryId { get; set; }
        public int VersionNumber { get; set; }
        public string Data { get; set; } = "{}"; // Snapshot of content data
        public string? ChangeLog { get; set; }
        public string? ChangeSummary { get; set; }

        // Audit
        public Guid CreatedByUserId { get; set; }
        public string CreatedByUserName { get; set; } = string.Empty;

        // Navigation properties
        public virtual ContentEntry ContentEntry { get; set; } = null!;
    }

}
