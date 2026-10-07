using System.ComponentModel.DataAnnotations;

namespace MuvieApi.Data.Dtos;

    public class CreateSectionDto
    {
        public int MovieId { get; set; }
       
        public int CinemaId { get; set; }

    }

