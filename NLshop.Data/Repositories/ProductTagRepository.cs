using NLshop.Data.Infrastructure;
using NLShop.Data.Infrastructure;
using NLShop.Model.Models;

namespace NLShop.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}