using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLshop.Data.Infrastructure;
using NLShop.Data.Infrastructure;
using NLShop.Model.Models;

namespace NLShop.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    {
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
