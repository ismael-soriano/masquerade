using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmascarada
{
    public class ShopContext : DbContext, IDbBase
    {
        public IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }
    }
}
