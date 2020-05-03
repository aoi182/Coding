using System.Collections.Generic;

namespace DesignPatterns.SOLID.OCP
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (Product p in products)
                if (p.Color == color)
                    yield return p;
        }
    }
}
