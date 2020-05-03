using System.Collections.Generic;

namespace DesignPatterns.SOLID.OCP
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, Specification<Product> specification)
        {
            foreach (var item in items)
            {
                if (specification.IsSatisified(item))
                    yield return item;
            }
        }
    }
}
