using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmascarada
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
