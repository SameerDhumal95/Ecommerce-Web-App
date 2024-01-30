using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Repositories;
using ShoppingCart.Models;
using System.Security.Claims;

namespace ShoppingCart.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public CartVM vm {  get; set; }

        public CartController(UnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            vm = new CartVM()
            {
                ListOfCart = _unitOfWork.Cart.GetAll(x => x.ApplicationUserId == claims.Value, includeProperties: "Product"),
                OrderHeader = new OrderHeader()
            };

            foreach (var item in vm.ListOfCart) 
            {
                vm.OrderHeader.OrderTotal += (item.Product.Price * item.Count);
            }

            return View(vm);
        }
    }
}
