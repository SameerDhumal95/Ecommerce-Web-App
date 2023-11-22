using ShoppingCart.DataAccess.ViewModels;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public interface ICartRepository: IRepository<Models.Cart>
    {
        void IncrementCartItem(Models.Cart cartItem, int count);
        void Update(Models.Cart cart);

    }
}

