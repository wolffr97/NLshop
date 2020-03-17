using System;

namespace NLShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NlShopDbContext Init();
    }
}