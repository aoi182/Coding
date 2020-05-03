namespace DesignPatterns.SOLID.OCP
{
    public static class CriteriaExtensions
    {
        public static AndSpecification<Product> And(this Color color, Size size)
        {
            var colosSpec = new ColorSpecification(color);
            var sizeSpec = new SizeSpecification(size);

            return new AndSpecification<Product>(colosSpec, sizeSpec);
        }
    }
}
