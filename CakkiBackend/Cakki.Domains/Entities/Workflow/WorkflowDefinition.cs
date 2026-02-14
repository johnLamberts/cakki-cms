using Cakki.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Workflow definition (approval process template)
    /// </summary>
    public class WorkflowDefinition : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDefault { get; set; }

        // Which content types use this workflow
        public Guid[]? ContentTypeIds { get; set; }

        // Workflow configuration (JSON)
        // Defines states, transitions, and approval requirements
        public string Configuration { get; set; } = "{}";

        // Navigation properties
        public virtual ICollection<WorkflowInstance> Instances { get; set; } = new List<WorkflowInstance>();
    }

}
