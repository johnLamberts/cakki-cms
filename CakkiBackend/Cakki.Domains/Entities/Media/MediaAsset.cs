using Cakki.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Media asset (images, videos, documents)
    /// </summary>
    public class MediaAsset : BaseEntity
    {
        public string FileName { get; set; } = string.Empty;
        public string OriginalFileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string MimeType { get; set; } = string.Empty;
        public long FileSizeBytes { get; set; }
        public string? FileExtension { get; set; }

        // Classification
        public string AssetType { get; set; } = string.Empty; // Image, Video, Document, Audio
        public Guid? FolderId { get; set; }

        // Image-specific
        public int? Width { get; set; }
        public int? Height { get; set; }
        public decimal? FocalPointX { get; set; } // 0-1 (percentage)
        public decimal? FocalPointY { get; set; } // 0-1 (percentage)
        public string? AltText { get; set; }
        public string? Caption { get; set; }

        // Optimization
        public bool IsOptimized { get; set; }
        public string[]? GeneratedFormats { get; set; } // ["webp", "avif"]
        public string[]? GeneratedSizes { get; set; }   // ["thumbnail", "medium", "large"]

        // Metadata
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string[]? Tags { get; set; }
        public string? MetadataJson { get; set; } // EXIF, etc.

        // CDN
        public string? CdnUrl { get; set; }

        // Usage tracking
        public int DownloadCount { get; set; }
        public DateTime? LastAccessedAt { get; set; }

        // Navigation properties
        public virtual MediaFolder? Folder { get; set; }
    }
}
