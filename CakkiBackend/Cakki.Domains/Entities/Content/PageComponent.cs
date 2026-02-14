using Cakki.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Entities.Auth
{
    /// <summary>
    /// Component instance on a page
    /// </summary>
    public class PageComponent : BaseEntity
    {
        public Guid PageId { get; set; }
        public Guid ComponentId { get; set; }
        public int SortOrder { get; set; }

        // Instance-specific overrides (JSON)
        public string? Overrides { get; set; }

        // Position in layout
        public string? ContainerId { get; set; }

        // Navigation properties
        public virtual Page Page { get; set; } = null!;
        public virtual Component Component { get; set; } = null!;
    }
}
