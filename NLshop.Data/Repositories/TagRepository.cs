using NLshop.Data.Infrastructure;
using NLShop.Data.Infrastructure;
using NLShop.Model.Models;


namespace NLShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}