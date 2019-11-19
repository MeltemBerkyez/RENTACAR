using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RENTACAR.ORM.Entity
{
   public class Arabalar:BaaseEntity
    {
        
        [Required]
        public string Plaka { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string AracTipi { get; set; }
        [Required]
        public string Vites { get; set; }
        [Required]
        public string YakıtTipi { get; set; }
        [Required]
        public double Fiyat { get; set; }
        [Required]
       


        List<Musteriler> Customers { get; set; }

    }
}
