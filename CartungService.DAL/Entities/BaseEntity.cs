namespace CartingService.DAL.Entities;

public class BaseEntity
{
    [Required()]
    public Guid Id { get; set; }
}
