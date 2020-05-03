namespace DesignPatterns.SOLID.OCP
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisified(T item);

        public static Specification<T> operator & (Specification<T> first, Specification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }

        public static Specification<T> operator | (Specification<T> first, Specification<T> second)
        {
            return new OrSpecification<T>(first, second);
        }
    }
}
