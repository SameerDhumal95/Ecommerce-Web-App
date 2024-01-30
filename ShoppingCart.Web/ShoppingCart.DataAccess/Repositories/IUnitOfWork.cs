using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }

        ICartRepository Cart { get; }

        IOrderHeaderRepository OrderHeader { get; }
        
        IOrderDetailRepository OrderDetails { get; }
        void Save();
    }
}
