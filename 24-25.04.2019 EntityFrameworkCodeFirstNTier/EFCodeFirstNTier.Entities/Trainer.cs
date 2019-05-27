using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public int PersonId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; } //? nullable anlamına geliyor
        public Person Person { get; set; }
    }
}
