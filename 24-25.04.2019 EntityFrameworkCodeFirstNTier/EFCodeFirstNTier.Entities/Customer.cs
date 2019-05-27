using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int PersonId { get; set; }
        public DateTime MembershipStartDate { get; set; }
        public DateTime? MembershipEndDate { get; set; }
        public Person Person { get; set; } //Hocaya sorulacak
    }
}
