using System.ComponentModel.DataAnnotations;

namespace API.Entites
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
