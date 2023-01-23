using System.Linq.Expressions;

namespace GenericRepositoryWithSpecificationExample.Infrastructure.Spec
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {

        }

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;

        }

        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        protected void AddIncludes(Expression<Func<T, object>> include)
        {
            Includes.Add(include);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }

        protected void AddOrderByDesending(Expression<Func<T, object>> orderByDesendingExpression)
        {
            OrderByDescending = orderByDesendingExpression;
        }
    }
}
