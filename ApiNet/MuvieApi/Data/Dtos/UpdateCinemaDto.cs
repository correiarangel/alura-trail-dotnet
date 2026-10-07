using System.ComponentModel.DataAnnotations;

namespace MuvieApi.Data.Dtos;

    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string? Name { get; set; }
        public int AddressId { get; set; }

    }
