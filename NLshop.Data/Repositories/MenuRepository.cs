using NLshop.Data.Infrastructure;
using NLShop.Data.Infrastructure;

using NLShop.Model.Models;

namespace NLShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}