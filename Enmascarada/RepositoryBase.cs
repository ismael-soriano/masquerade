using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmascarada
{
    public class RepositoryBase<T> where T : class
    {
        readonly IDbBase _context;
        public RepositoryBase(IDbBase context)
        {
            Check.NotNull(context, "context");
            _context = context;
        }

        protected IDbSet<T> Entity
        {
            get
            {
                return _context.CreateSet<T>();
            }
        }
    }
}
