using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandReadDto
    {
        [Required]
        [MaxLength(250)]
        public int Id { get; set; }
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
    }
}