using NLshop.Data.Infrastructure;
using NLShop.Data.Infrastructure;
using NLShop.Model.Models;

namespace NLShop.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}