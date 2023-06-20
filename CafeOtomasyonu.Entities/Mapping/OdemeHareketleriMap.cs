using CafeOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Mapping
{
    public class OdemeHareketleriMap : EntityTypeConfiguration<OdemeHareketleri>
    {
        public OdemeHareketleriMap()
        {
            this.ToTable("OdemeHareketleri");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.SatisKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(x => x.OdemeTuru).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}
