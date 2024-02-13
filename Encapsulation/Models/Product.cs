
namespace Encapsulation.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public static List<Product> List = new List<Product>();
    }
}
