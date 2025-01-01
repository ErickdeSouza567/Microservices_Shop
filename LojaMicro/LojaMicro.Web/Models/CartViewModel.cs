namespace LojaMicro.Web.Models
{
    public class CartViewModel
    {
        public CartHeaderViewModel CartHeader { get; set; } = CartHeaderViewModel();
        public IEnumerable<CartItemViewModel>? CartItems { get; set; }
    }
}
