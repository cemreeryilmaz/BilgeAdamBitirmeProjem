using System.Collections.Generic;
using Shop.Entities.Concrete;

namespace Shop.Business.Abstract
{
    public interface ITicketService
    {
        List<Ticket> GetAll();
        Ticket GetById(int ticketId);
    }
}