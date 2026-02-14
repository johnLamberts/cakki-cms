using Cakki.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Entities.Auth
{
    /// <summary>
    /// Media folder for organization
    /// </summary>
    public class MediaFolder : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid? ParentFolderId { get; set; }
        public string Path { get; set; } = string.Empty; // Full path for quick lookup
        public int SortOrder { get; set; }

        // Navigation properties
        public virtual MediaFolder? ParentFolder { get; set; }
        public virtual ICollection<MediaFolder> ChildFolders { get; set; } = new List<MediaFolder>();
        public virtual ICollection<MediaAsset> Assets { get; set; } = new List<MediaAsset>();
    }
}
