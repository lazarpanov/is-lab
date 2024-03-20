using System.ComponentModel.DataAnnotations;

namespace Theatre.Web.Models
{
    public class TheatreShow
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        public DateTime ShowDate { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
