using Cakki.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Entities.Auth
{
    /// <summary>
    /// Page version history
    /// </summary>
    public class PageVersion : BaseEntity
    {
        public Guid PageId { get; set; }
        public int VersionNumber { get; set; }
        public string Layout { get; set; } = "{}";
        public string? MobileLayout { get; set; }
        public string? TabletLayout { get; set; }
        public string? ChangeLog { get; set; }
        public string? ChangeSummary { get; set; }

        // Audit
        public Guid CreatedByUserId { get; set; }
        public string CreatedByUserName { get; set; } = string.Empty;

        // Navigation properties
        public virtual Page Page { get; set; } = null!;
    }
}
