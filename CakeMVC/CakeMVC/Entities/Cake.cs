using System.ComponentModel.DataAnnotations;

namespace CakeMVC.Entities
{
    public class Cake
    {

        public int CakeId { get; set; }

        [MaxLength(100)]

        public string Flavor { get; set; } = string.Empty;

        public string Cover { get; set; } = string.Empty;


        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }

    }
}
