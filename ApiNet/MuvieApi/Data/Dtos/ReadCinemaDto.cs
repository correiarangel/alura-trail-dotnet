namespace MuvieApi.Data.Dtos;

    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ReadAddressDto? AddressDto { get; set; }

        public ReadSectionDto? SectionsDto { get; set; }
    }

