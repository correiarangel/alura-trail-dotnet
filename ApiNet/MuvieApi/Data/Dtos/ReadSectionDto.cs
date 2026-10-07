using System.ComponentModel.DataAnnotations;

namespace MuvieApi.Data.Dtos;

    public class ReadSectionDto
    {
        public int MovieId { get; set; }

        public int? CinemaId { get; set; }
    }

