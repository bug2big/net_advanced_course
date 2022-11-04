namespace CartingService.API.ApiModels;

public record CartDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public double Price { get; set; }

    public int Quantity { get; set; }
}

