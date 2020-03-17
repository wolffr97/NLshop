using NLshop.Data.Infrastructure;
using NLshop.Model;
using NLShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLshop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {

    }

    class ErrorRepository : RepositoryBase <Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
