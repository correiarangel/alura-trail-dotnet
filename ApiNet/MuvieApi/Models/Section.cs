using System.ComponentModel.DataAnnotations;

namespace MuvieApi.Models;

    public class Section
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public virtual Movie? Movie { get; set; }

        public int? CinemaId { get; set; }
        public virtual Cinema? Cinema { get; set; }
    }
