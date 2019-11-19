using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RENTACAR.ORM.Entity
{
    public class Kİralama:BaaseEntity
    {
        public int ArabaID { get; set; }
        public virtual Arabalar arabalar { get; set; }  //Araba classın daki ArabaID yi al dediğim için bunu yazmak zorundayım. Burada araba ID yi foreign key yapmış olduk
        public int MusteriID { get; set; }
        public virtual Musteriler musteriler { get; set; }


        public string TeslimAlmaYeri { get; set; }
        public string TeslimEtmeYeri { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int? KiralanmaSuresi { get; set; }
        public double Fatura { get; set; }
        

    }
}
