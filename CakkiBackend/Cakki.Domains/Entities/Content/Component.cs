using Cakki.Domains.Common;


namespace Cakki.Domains.Entities.Auth
{
    /// <summary>
    /// Reusable component (Master Symbol)
    /// </summary>
    public class Component : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Category { get; set; } = string.Empty; // e.g., "Navigation", "Footer", "Hero"
        public string Structure { get; set; } = "{}"; // JSON structure
        public string? PreviewImage { get; set; }
        public bool IsGlobal { get; set; } // true = updates everywhere, false = instance-specific

        // Version tracking
        public int Version { get; set; } = 1;

        // Navigation properties
        public virtual ICollection<PageComponent> PageComponents { get; set; } = new List<PageComponent>();
    }
}
