using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RENTACAR.ORM.Entity
{
    public class ODEME:BaaseEntity
    {
        public int ArabaID { get; set; }
        public virtual Arabalar arabalar { get; set; }  //Araba classın daki ArabaID yi al dediğim için bunu yazmak zorundayım. Burada araba ID yi foreign key yapmış olduk
        public int MusteriID { get; set; }
        public virtual Musteriler musteriler { get; set; }

        public string KSAdSoyad { get; set; }
        public string KSNo { get; set; }
        public int SKAy { get; set; }
        public int SKYil { get; set; }
        public string CVV { get; set; }
    }
}
