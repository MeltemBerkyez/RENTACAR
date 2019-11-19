using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RENTACAR.ORM.Entity
{
   public class BaaseEntity
    {
        [Requried]
        public int ID { get; set; }
        public DateTime? AddDate = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        [Requried]
        public bool AktifMi { get; set; }
    }
    
}
