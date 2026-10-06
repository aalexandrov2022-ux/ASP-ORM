using System.ComponentModel.DataAnnotations;

namespace GameShop.Data.Domain
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

       
        public decimal? Price { get; set; }

        [Required]
        
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int DeveloperId { get; set; }

        
        public Developer Developer { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }

        
        public Genre Genre { get; set; } = null!;

        public ICollection<Game> Games{ get; set; } = new List<Game>();

        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
