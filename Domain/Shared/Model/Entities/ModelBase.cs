namespace Domain.Shared.Model.Entities;

public class ModelBase
{
    public int Id { get; set; }
    
    // Those fields are for audit purposes

    public int CreatedUser { get; set; }

    public int? UpdatedUser { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsActive { get; set; }
}