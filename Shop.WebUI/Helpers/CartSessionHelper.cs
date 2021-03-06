using Microsoft.AspNetCore.Http;
using Shop.Entities.DomainModels;
using Shop.WebUI.Extensions;

namespace Shop.WebUI.Helpers
{
    public class CartSessionHelper:ICartSessionHelper
    {
        IHttpContextAccessor _httpContextAccessor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart(string key)
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
            if (cartToCheck == null)
            {
                SetCart(key, new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
            }

            return cartToCheck;
        }

        public void SetCart(string key, Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(key, cart);
        }

        public void Clear()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
        }
    }
}