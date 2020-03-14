using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLshop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NlShopDbContext Init();
    }
}
 