using Cakki.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Entities.Auth
{
    /// <summary>
    /// Active workflow instance for a specific content item
    /// </summary>
    public class WorkflowInstance : BaseEntity
    {
        public Guid WorkflowDefinitionId { get; set; }
        public string EntityType { get; set; } = string.Empty; // ContentEntry, Page
        public Guid EntityId { get; set; }

        public string CurrentState { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }

        // Current assignees
        public Guid[]? AssignedToUserIds { get; set; }
        public Guid[]? AssignedToRoleIds { get; set; }

        // Workflow data (JSON)
        public string Data { get; set; } = "{}";

        // Navigation properties
        public virtual WorkflowDefinition WorkflowDefinition { get; set; } = null!;
        public virtual ICollection<WorkflowTransition> Transitions { get; set; } = new List<WorkflowTransition>();
    }
}
