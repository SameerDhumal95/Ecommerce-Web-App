using ShoppingCart.Models;

namespace ShoppingCart.Web.Areas.Customer.Controllers
{
    public class CartVM
    {
        public Cart Cart { get; set; } = new Cart();

        //public IEnumerable<Cart> cart { get; set; } = new List<Cart>();
    }
}