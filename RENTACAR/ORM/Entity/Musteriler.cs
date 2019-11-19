using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RENTACAR.ORM.Entity
{
   public class Musteriler:BaaseEntity
    {
        
        [Requried]
        public string Ad { get; set; }
        [Requried]
        public string Soyad { get; set; }
        [Requried]
        public string TC { get; set; }
        [Requried]
        public string EhliyetNo { get; set; }
        [Requried]
        public string Telefon { get; set; }
        [Requried]
        public string Email { get; set; }
        [Requried]
        public string Adres { get; set; }
        [Requried]
        public string Sifre{ get; set; }
        

       List<Arabalar> Cars { get; set; }

    }
}
