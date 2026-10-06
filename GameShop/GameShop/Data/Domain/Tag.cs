using System.ComponentModel.DataAnnotations;

namespace GameShop.Data.Domain
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Game>Games{ get; set; } = new List<Game>();
    }
}
