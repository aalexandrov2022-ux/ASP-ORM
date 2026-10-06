using System.ComponentModel.DataAnnotations;

namespace GameShop.Data.Domain
{
    public class Developer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Game> Games { get; set; } = new List<Game>();
    }
}
