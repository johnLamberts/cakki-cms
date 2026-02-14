using Cakki.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cakki.Domains.Entities.Auth
{

    /// <summary>
    /// Workflow state transition history
    /// </summary>
    public class WorkflowTransition : BaseEntity
    {
        public Guid WorkflowInstanceId { get; set; }
        public string FromState { get; set; } = string.Empty;
        public string ToState { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty; // Approve, Reject, Submit, etc.

        // Who performed the transition
        public Guid PerformedByUserId { get; set; }
        public string PerformedByUserName { get; set; } = string.Empty;

        // Optional comments/notes
        public string? Comment { get; set; }

        // Additional data (JSON)
        public string? Data { get; set; }

        // Navigation properties
        public virtual WorkflowInstance WorkflowInstance { get; set; } = null!;
    }
}
