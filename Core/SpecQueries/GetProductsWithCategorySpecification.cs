using GenericRepositoryWithSpecificationExample.Core.Models;
using GenericRepositoryWithSpecificationExample.Infrastructure.Spec;

namespace GenericRepositoryWithSpecificationExample.Core.SpecQueries
{
    public class GetProductsWithCategorySpecification : BaseSpecification<Product>
    {
        public GetProductsWithCategorySpecification()
        {
            AddIncludes(x => x.Category);
        }
    }
}
