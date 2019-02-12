using PersonalSite.Shared.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Server.Services
{
    public interface ICartService
    {
        Cart UpdateCart(Cart cart);
        Cart ClearCart();
    }

    public class CartService
    {
    }
}
