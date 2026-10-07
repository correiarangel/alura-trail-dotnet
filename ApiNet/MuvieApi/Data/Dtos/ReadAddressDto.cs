namespace MuvieApi.Data.Dtos;

public class ReadAddressDto
{
    public int Id { get; set; }
    public string? Street { get; set; }

    public string? Neighborhood { get; set; }

    public int Number { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }
}
