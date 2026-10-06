using System.ComponentModel.DataAnnotations;

namespace GameShop.Data.Domain
{
    public class Card
    {
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        public string Cvc { get; set; }

        public string Type { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }

}
