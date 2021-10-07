using System.Reflection.Metadata;
using Shop.Core.Entities.Abstract;

namespace Shop.Entities.Concrete
{
    public class Ticket : IEntity
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public string Description { get; set; }
    }
}