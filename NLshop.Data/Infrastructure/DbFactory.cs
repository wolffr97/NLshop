using NLshop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLshop.Data
{
    public class DbFactory : Disposable, IDbFactory
    {
        NlShopDbContext dbContext;

        public NlShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NlShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}