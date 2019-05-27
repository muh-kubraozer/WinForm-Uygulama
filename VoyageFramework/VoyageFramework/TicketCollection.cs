using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class TicketCollection<Ticket>
    {
        public int Length
        {
            get { return _length; }
            private set { _length = value; }
        }

        private Ticket[] _tickets;
        private int _length;


        public TicketCollection()
        {
            _tickets = new Ticket[0];
            Length = 0;
        }
        public Ticket this[int index]
        {
            get
            {
                return _tickets[index];
            }
            set
            {
                _tickets[index] = value;
            }
        }
        public bool Contains(Ticket ticket)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i].Equals(ticket))
                {
                    return true;
                }
            }
            return false;

        }
        public void Add(Ticket ticket)
        {

            if (_tickets == null)
            {
                _tickets = new Ticket[1];
                _tickets[0] = ticket;

            }
            if (_tickets.Length > 0 && !Contains(ticket))
            {
                Array.Resize(ref _tickets, ++Length);

                _tickets[_tickets.Length - 1] = ticket;
            }

        }
        public void RemoveAt(int index)
        {

            for (int i = 0; i < _tickets.Length; i++)
            {
                if (i == index)
                {
                    index = i;
                    continue;

                }
                var yeniİndis = i > index ? i - 1 : i;
                Array.Resize(ref _tickets, _tickets.Length - 1);

            }

        }
        public void Remove(Ticket ticket)
        {
            RemoveAt(IndexOf(ticket));
        }
        public int IndexOf(Ticket ticket)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i].Equals(ticket))
                    return i;
            }
            return -1;
        }
        public Ticket GetDriverAt(int index)
        {
            return _tickets[index];
        }
    }
}
