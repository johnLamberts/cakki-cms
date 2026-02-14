using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Common
{
    /// <summary>
    /// Interface for entities that need audit tracking
    /// </summary>
    public interface IAuditableEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        string? UpdatedBy { get; set; }
    }
}
