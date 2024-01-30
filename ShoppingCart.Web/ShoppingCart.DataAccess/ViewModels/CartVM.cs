using ShoppingCart.Models;

namespace ShoppingCart.Web.Areas.Customer.Controllers
{
    public class CartVM
    {
        public Cart Cart { get; set; } = new Cart();

        public IEnumerable<Cart> ListOfCart { get; set; } = new List<Cart>();

        public OrderHeader OrderHeader { get; set; } = new OrderHeader();
    }
}