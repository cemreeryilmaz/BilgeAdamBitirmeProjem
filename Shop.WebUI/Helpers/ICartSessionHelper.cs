using Shop.Entities.DomainModels;

namespace Shop.WebUI.Helpers
{
    public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void SetCart(string key, Cart cart);
        void Clear();

    }
}