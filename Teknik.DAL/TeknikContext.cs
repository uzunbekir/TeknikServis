using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Teknik.Entity.Entities;
using Teknik.Entity.IdentifyModels;


namespace Teknik.DAL
{
   public class TeknikContext:IdentityDbContext<ApplicationUser>
    {
        public TeknikContext():base("TeknikCon")
        {

        }
        public virtual DbSet<Ariza> Arizalar { get; set; }
        public virtual DbSet<ArizaBilgilendirme> ArizaBilgilendirneler { get; set; }
        public virtual DbSet<Fotograf> Fotograflar { get; set; }
        public virtual DbSet<PcMarka> Markalar { get; set; }
        public virtual DbSet<PcModel> Modeller { get; set; }
        public virtual DbSet<Anket> Anketler { get; set; }
    }
}
