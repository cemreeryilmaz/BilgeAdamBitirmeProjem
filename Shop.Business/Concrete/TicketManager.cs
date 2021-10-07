using System.Collections.Generic;
using Shop.Business.Abstract;
using Shop.DataAccess.Abstract;
using Shop.Entities.Concrete;

namespace Shop.Business.Concrete
{
    public class TicketManager:ITicketService
    {
        private ITicketDal _ticketDal;

        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public List<Ticket> GetAll()
        {
            return _ticketDal.GetList();
        }

        public Ticket GetById(int ticketId)
        {
            return _ticketDal.Get(t => t.TicketId == ticketId);
        }
    }
}