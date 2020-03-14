using NLshop.Data.Infrastructure;
using NLShop.Data.Infrastructure;
using NLShop.Model.Models;

namespace NLShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}