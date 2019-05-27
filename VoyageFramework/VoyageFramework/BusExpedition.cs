using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class BusExpedition
    {
        DriverCollection<Driver> driverCollection = new DriverCollection<Driver>();
        HostCollection<Host> hostCollection = new HostCollection<Host>();
        TicketCollection<Ticket> ticketCollection = new TicketCollection<Ticket>();
        public Driver driver;
        public Host host;
        public string Code { get { return Codes(); } }
        private Bus _bus;
        public Bus Bus {
            get { return _bus; }
            set
            {
                if (driverCollection.Length > 0)
                {
                    foreach (var item in driverCollection)
                    {
                        if (this.Bus is LuxuryBus && item.LicenseType == LicenseType.HighLicense || this.Bus is StandardBus && item.LicenseType != LicenseType.None)
                            _bus = value;
                        else
                            throw new Exception("Hata:Sürücü Eklenemedi.");
                    }
                }
            }

        }
       
        //public Driver[] Drivers { get; }
        //public Host[] Hosts { get; }
        public Route Route { get; }
        public DateTime DepartureTime { get; } //planlı kalkış zamanı
        public DateTime _estimatedDepartureTime;
        public DateTime EstimatedDepartureTime
        {
            get { return _estimatedDepartureTime; }
            set {if (HasDelay == true)
                    value = EstimatedDepartureTime;
                else
                    value = DepartureTime;
            }
        }
        private DateTime _estimatedArrivalTime; //tahmini varış zamanı
        public DateTime EstimatedArrivalTime { get
            {
                TimeSpan duration = TimeSpan.Parse(Route.Duration.ToString());
                if (HasDelay == true)
                {
                    return _estimatedDepartureTime + duration;
                }
                return DepartureTime + duration;
            }
        } 
        public bool HasDelay { get { return DepartureTime != EstimatedDepartureTime ? true : false; } }
        public bool HasSnackService;

        private bool IsDriverLicenseTypeSuitable(Driver driver)//lisans uygunlugu
        {
            bool suitable = true;
            if (driver.LicenseType == LicenseType.None)
            {
                suitable = false;
                throw new Exception("sürücü lisans uygun değil");
            }

            if (this.Bus != null)
            {
                if (this.Bus is LuxuryBus)
                {
                    if (driver.LicenseType != LicenseType.HighLicense)
                    {
                        suitable = false;
                        throw new Exception("sürücü Lisans uygun değil");
                    }
                }
            }
            return suitable;
        }

        private Ticket[] _ticket;
        public Ticket[] Ticket
        {
            get
            {
                return _ticket;
            }
        }

        public string Codes()
        {
            Random rnd = new Random();
            int rn = rnd.Next(1000, 9999);
            string code = "";
            if (this.Bus is LuxuryBus)
            {
                code = "LX" + DepartureTime.ToString("YYMMDD") + rn.ToString();
            }
           else
            {
                code = "SX" + DepartureTime.ToString("YYMMDD") + rn.ToString();
            }
            return code;
        }

        //private Driver[] _drivers;
        //private Host[] _host;
        public void AddDriver(Driver driver)
        {
            int addDriver = (Route.Distance / 400) + 1;
            if (addDriver > driverCollection.Length && IsDriverLicenseTypeSuitable(driver))
                driverCollection.Add(driver);
            //int drivers = (Route.Distance / 400)+1;
            //if(_drivers.Length < drivers)
            // {
            //     Array.Resize(ref _drivers, _drivers.Length + 1);
            //     _drivers[_drivers.Length - 1] = driver;
            // }

        }
        public void AddHost(Host host)
        {
            int addHost = (Route.Distance / 400) + 1;
            if (addHost > hostCollection.Length)
                hostCollection.Add(host);
            //int hosts = (Route.Distance / 600)+1;
            //if(_host.Length < hosts)
            // {
            //     Array.Resize(ref _host, _host.Length + 1);
            //     _host[_host.Length - 1] = host;
            // }

        }
        public void RemoveAtDriver(int index)
        {
            driverCollection.RemoveAt(index);

        }
        public void RemoveDriver(Driver driver)
        {
            driverCollection.Remove(driver);

            //    int index = -1;
            //    for (int i = 0; i < _drivers.Length; i++)
            //    {
            //        if (driver.IdentityNumber == _drivers[i].IdentityNumber)
            //        {
            //            index = i;
            //            break;
            //        }
            //    }
            //    for (int j = index; j < _drivers.Length; j++)
            //    {
            //        _drivers[j] = _drivers[j + 1];
            //    }
            //    Array.Resize(ref _drivers, _drivers.Length - 1);
        }
        public void RemoveHost(Host host)
        {
            //int index = -1;
            //for (int i = 0; i < _host.Length; i++)
            //{
            //    if (host.IdentityNumber == _host[i].IdentityNumber)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //for (int j = index; j < _host.Length; j++)
            //{
            //    _host[j] = _host[j + 1];
            //}
            //Array.Resize(ref _host, _host.Length - 1);
            hostCollection.Remove(host);

        }
        public void RemoveAtHost(int index)
        {
            hostCollection.RemoveAt(index);

        }

        public decimal GetPriceOf(int seatNumber)
        {
            SeatInformation selection = new SeatInformation();
            if (Bus.Capacity == 30)
            {
                if (selection.Section == SeatSection.LeftSide)
                {
                    return Route.BasePrice * 125 / 100;
                }
                else
                {
                    return Route.BasePrice * 120 / 100;
                }
            }
            else
            {
                return Route.BasePrice * 135 / 100;
            }
    
        }

        //public void AddTicket(Ticket ticket)
        //{
        //    Array.Resize(ref _ticket, _ticket.Length + 1);
        //    _ticket[_ticket.Length - 1] = ticket;
        //}

        public Ticket SellTicket(Person person,int seatNumber,decimal fee)
        {
            decimal kar = 105 / 100;

            if (IsSeatAvailableFor(seatNumber,person.Gender) && IsSeatEmpty(seatNumber))
            {
                if (person is Driver || person is Host)

                    fee = Route.BasePrice;
                else
                    fee = Route.BasePrice + Route.BasePrice * kar;
                Ticket ticket = new Ticket(this,GetSeatInformation(seatNumber), person, fee);
                ticketCollection.Add(ticket);
                return ticket;
            }

            else
            {
                throw new Exception("HATA!!Lütfen Ödeme Yapınız..");
            }


        }
        public Ticket[] SellDoubleTickets(Person person1,Person person2,int seatNumber,decimal fee)
        {
            decimal kar = 105 / 100;
            Ticket[] tickets = new Ticket[2];
            if (Bus is StandardBus && GetSeatInformation(seatNumber).Category != SeatCategory.Singular && IsSeatEmpty(seatNumber))
            {
                int nearSeat = seatNumber % 3 == 2 ? seatNumber - 1 : seatNumber % 3 == 0 ? seatNumber - 1 :
                throw new Exception("Çift Kişilik Bir Secim Yapınız..");

                if (IsSeatEmpty(seatNumber))
                {
                    if (person1 is Driver || person1 is Host && person2 is Driver || person2 is Host)
                    {
                        fee = Route.BasePrice;
                        tickets[0] = new Ticket(this, GetSeatInformation(seatNumber), person1, fee / 2);
                        tickets[1] = new Ticket(this, GetSeatInformation(seatNumber), person2, fee / 2);
                        ticketCollection.Add(tickets[0]);
                        ticketCollection.Add(tickets[1]);

                    }
                    else
                    {
                        fee = Route.BasePrice * kar;
                        tickets[0] = new Ticket(this, GetSeatInformation(seatNumber), person1, fee / 2);
                        tickets[1] = new Ticket(this, GetSeatInformation(seatNumber), person2, fee / 2);
                        ticketCollection.Add(tickets[0]);
                        ticketCollection.Add(tickets[1]);

                    }
                }
                else
                    throw new Exception("Secilen koltuklar doludur");
            }
            else
                throw new Exception("HATA:Lüks otobüs için çift koltuk seçimi yapılamaz..");

            return tickets;
        }
        public bool IsSeatEmpty(int seatNumber)
        {
            for(int i=0; i < _ticket.Length; i++)
            {
                if (_ticket[i].SeatInformation.Number == seatNumber)
                    return false;
            }
            return true;
                
        }
        public bool IsSeatAvailableFor(int seatNumber,Gender gender)
        {
            bool result = true;
            if (Bus is StandardBus && GetSeatInformation(seatNumber).Category != SeatCategory.Singular && IsSeatEmpty(seatNumber))
            {
                int nearSeat = seatNumber % 3 == 2 ? seatNumber + 1 : seatNumber % 3 == 0 ? seatNumber - 1 : -1;
                foreach (Ticket ticket in _ticket)
                {
                    if (ticket.SeatInformation.Number == nearSeat)
                    {
                        result = ticket.Passenger.Gender == gender;
                        break;
                    }
                }
            }
            else result = false;
            return result;
        }
        public SeatInformation GetSeatInformation(int seatNumber)
        {
            SeatSection section = new SeatSection();
            SeatCategory category = new SeatCategory();
            SeatInformation seatInformation = new SeatInformation(seatNumber,section,category);

           if(Bus is StandardBus)
            {
                if (seatNumber % 3 == 1)
                {
                    section = SeatSection.LeftSide;
                    category = SeatCategory.Singular;
                }
                else if (seatNumber % 3 == 2)
                {
                    section = SeatSection.RightSide;
                    category = SeatCategory.Corridor;
                }
                else if (seatNumber % 3 == 0)
                {
                    section = SeatSection.RightSide;
                    category = SeatCategory.Window;
                }
            }
            else
            {
                if (seatNumber % 2 == 1)
                {
                    section = SeatSection.LeftSide;
                }
                else if (seatNumber % 2 == 0)
                {
                    section = SeatSection.RightSide;
                }
            }
            return seatInformation;
        }
        public void CanselTicket(Ticket ticket)
        {
            ticketCollection.Remove(ticket);
            //int index = 0;

            //for (int i = 0; i < _ticket.Length; i++)
            //{
            //    if (_ticket[i].SeatInformation.Number == ticket.SeatInformation.Number)
            //    {
            //        index = i;
            //        continue;
            //    }
            //    var yeniİndis = i > index ? i - 1 : i;
            //    _ticket[yeniİndis] = _ticket[i];

            //}
            //Array.Resize(ref _ticket, _ticket.Length - 1);
        }
    }
}
