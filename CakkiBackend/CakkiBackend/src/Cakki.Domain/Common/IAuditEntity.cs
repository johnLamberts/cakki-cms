namespace CakkiBackend.src.Cakki.Domain.Common
{
    public interface IAuditEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        string? UpdatedBy { get; set; }
    }
}
