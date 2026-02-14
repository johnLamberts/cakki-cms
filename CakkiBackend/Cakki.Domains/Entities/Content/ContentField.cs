using Cakki.Domains.Common;


namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Field definition within a Content Type
    /// </summary>
    public class ContentField : BaseEntity
    {
        public Guid ContentTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public FieldType Type { get; set; }
        public int SortOrder { get; set; }

        // Validation rules
        public bool IsRequired { get; set; }
        public bool IsUnique { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public string? RegexPattern { get; set; }
        public string? DefaultValue { get; set; }

        // For dropdown/multi-select
        public string[]? Options { get; set; }

        // For reference fields
        public Guid? ReferenceContentTypeId { get; set; }

        // Settings
        public bool IsLocalized { get; set; }
        public bool IsSearchable { get; set; }
        public string? ValidationMessage { get; set; }
        public string? Placeholder { get; set; }
        public string? HelpText { get; set; }

        // Additional configuration (JSON)
        public string? Config { get; set; }

        // Navigation properties
        public virtual ContentType ContentType { get; set; } = null!;
        public virtual ContentType? ReferenceContentType { get; set; }
    }

}
