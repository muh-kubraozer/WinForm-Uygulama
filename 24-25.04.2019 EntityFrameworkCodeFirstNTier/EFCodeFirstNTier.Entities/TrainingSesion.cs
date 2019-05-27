using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.Entities
{
    public class TrainingSession
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] yaparsak program ıd yi kafasına göre atamıyor.
        public int TrainingSessionId { get; set; }
        //[Required] customer si olmayan tarining session oluşturulamasın anlamına gelir
        public int CustomerId { get; set; }
        //[Required] trainer ıd si olmayan tarining session oluşturulamasın anlamına gelir
        public int TrainerId { get; set; }
        public DateTime SessionStartDate { get; set; }
        public DateTime SessionEndDate { get; set; }

        public TrainingTypes TrainingType { get; set; }

        public Customer Customer { get; set; }
        public Trainer Trainer { get; set; }
    }
}
