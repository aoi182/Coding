namespace DesignPatterns.SOLID.OCP
{
    public class SizeSpecification : Specification<Product>
    {
        private Size Size;

        public SizeSpecification(Size size)
        {
            Size = size;
        }

        public override bool IsSatisified(Product item)
        {
            return item.Size == Size;
        }
    }
}
