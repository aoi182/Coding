namespace DesignPatterns.SOLID.OCP
{
    public class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> first, second;

        public AndSpecification(Specification<T> first, Specification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsSatisified(T item)
        {
            return first.IsSatisified(item) && second.IsSatisified(item);
        }
    }
}
