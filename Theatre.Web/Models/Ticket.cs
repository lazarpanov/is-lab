using System.ComponentModel.DataAnnotations;

namespace Theatre.Web.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Price { get; set; }
        public string? OwnerId { get; set; }
        public User? Owner { get; set; }
        public TheatreShow? TheatreShow { get; set; }
        public Guid TheatreShowId { get; set; }

    }
}
