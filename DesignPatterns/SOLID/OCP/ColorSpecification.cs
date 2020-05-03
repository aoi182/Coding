namespace DesignPatterns.SOLID.OCP
{
    public class ColorSpecification : Specification<Product>
    {
        private Color Color;

        public ColorSpecification(Color color)
        {
            Color = color;
        }

        public override bool IsSatisified(Product item)
        {
            return item.Color == Color;
        }
    }
}
