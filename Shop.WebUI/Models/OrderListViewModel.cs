using System.Collections.Generic;
using Shop.Entities.Concrete;

namespace Shop.WebUI.Models
{
    public class OrderListViewModel
    {
        public List<Order> Orders  { get; set; }
        public List<Product> Products  { get; set; }
        public List<Category> Categories  { get; set; }
        public List<Ticket> Tickets  { get; set; }
        public List<User> Users  { get; set; }
    }
}