using System;
using System.Reflection.Metadata;
using Shop.Core.Entities.Abstract;

namespace Shop.Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int TicketId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }


    }
}