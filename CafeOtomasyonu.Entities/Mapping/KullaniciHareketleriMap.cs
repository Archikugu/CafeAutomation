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
    public class KullaniciHareketleriMap : EntityTypeConfiguration<KullaniciHareketleri>
    {
        public KullaniciHareketleriMap()
        {
            this.ToTable("KullaniciHareketleri");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);

            this.HasRequired(x => x.Kullanicilar).WithMany(x => x.KullaniciHareketleri).HasForeignKey(x => x.KullaniciId);
        }
    }
}
