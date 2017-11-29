using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik.Entity.Entities
{
   public class Anket
    {   
         [ForeignKey("Ariza")]
        public int ID { get; set; }

        public int ArizaID { get; set; }

        //public string TeknikerID { get; set; }
        //public string KullaniciID { get; set; }

        public string Puan { get; set; }
        public string  Aciklama { get; set; }

        //Mapping
   
        public virtual Ariza Ariza { get; set; }
    }
}
