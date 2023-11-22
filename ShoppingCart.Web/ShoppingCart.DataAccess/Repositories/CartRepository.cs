using ShoppingCart.DataAccess.Data;
using ShoppingCart.DataAccess.ViewModels;
using ShoppingCart.Models;
using System.Linq.Expressions;
using Cart = ShoppingCart.Models.Cart;

namespace ShoppingCart.DataAccess.Repositories
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private ApplicationDbContext _context;
        
        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void IncrementCartItem(Cart cartItem, int count)
        {
            throw new NotImplementedException();
        }

        public void Update(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}