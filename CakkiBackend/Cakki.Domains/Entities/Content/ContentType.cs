using Cakki.Domains.Common;


namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Content Type definition (dynamic schema)
    /// </summary>
    public class ContentType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string ApiIdentifier { get; set; } = string.Empty; // Used in API URLs
        public bool IsSingleType { get; set; } // true = singleton (Homepage), false = collection (Blog Posts)
        public bool IsPublished { get; set; }
        public string? Icon { get; set; }

        // Settings
        public bool EnableVersioning { get; set; } = true;
        public bool EnableWorkflow { get; set; } = true;
        public bool EnableLocalization { get; set; }

        // API Configuration
        public bool EnableRestApi { get; set; } = true;
        public bool EnableGraphQL { get; set; } = true;

        // Navigation properties
        public virtual ICollection<ContentField> Fields { get; set; } = new List<ContentField>();
        public virtual ICollection<ContentEntry> Entries { get; set; } = new List<ContentEntry>();
    }

}
