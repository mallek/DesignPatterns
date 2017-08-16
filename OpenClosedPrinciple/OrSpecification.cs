using System;

namespace DesignPatterns
{  
    // combinator or
    public class OrSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public OrSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(Product p)
        {
            return first.IsSatisfied(p) || second.IsSatisfied(p);
        }
    }
}