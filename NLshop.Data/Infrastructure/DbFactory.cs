using NLshop.Data.Infrastructure;

namespace NLShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NlShopDbContext dbContext;

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