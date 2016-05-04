using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmascarada
{
    class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbBase context) : base(context) {}

        public IEnumerable<Product> GetAll()
        {
            return Entity.Select(c => c);
        }
    }
}
