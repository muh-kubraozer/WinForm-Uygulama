using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.Entities
{
    // [Table("Kisiler")] dersek sqlde tablo adı person değil Kisiler olur ancak person tablosu oluşmadan önce daha en başta yaparsak olur.
    public class Person
    {
        public int PersonId { get; set; }
        [MaxLength(64)] //maksimum karakter sayısını belirtmek için yapılır (attributeler üstüne yazılan şeyleri etkiler)
        public string Name { get; set; }
        public string Lastname { get; set; }
        //Ekstra bilgiler eklenebilir.
    }
}
