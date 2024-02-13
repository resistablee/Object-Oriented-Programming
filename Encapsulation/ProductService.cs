using Encapsulation.Models;
using System.Collections;

namespace Encapsulation
{
    public class ProductService
    {
        private Queue<Product> Queue;

        public ProductService()
        {
            Queue = new Queue<Product>();
        }

        public void Add()
        {
            Product dequeuedItem = Queue.Dequeue();
            Product.List.Add(dequeuedItem);
        }

        public Product GetById(string Id)
        {
            Product item = Product.List.FirstOrDefault(x => x.Id == Guid.Parse(Id));
            if (item == null)
                return null;

            if (string.IsNullOrEmpty(item.Category))
                item.Category = "Unknown";

            // Ternary If
            item.Category = string.IsNullOrEmpty(item.Category) ? "Unknown" : item.Category;

            return item;
        }

        public void Enqueue(Product item)
        {
            // Encapsulation
            if (item.Price < 0)
                item.Price = 0;

            if (string.IsNullOrEmpty(item.Name))
            {
                return;
            }

            Queue.Enqueue(item);
        }
    }
}
