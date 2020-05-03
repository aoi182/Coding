using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OCP
{
    public class OrSpecification<T> : Specification<T>
    {
        private Specification<T> first, second;

        public OrSpecification(Specification<T> first, Specification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsSatisified(T item)
        {
            return first.IsSatisified(item) || second.IsSatisified(item);
        }
    }
}
