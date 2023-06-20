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
    public class UrunMap : EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            this.ToTable("Urun");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.UrunKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(x => x.UrunAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);

            //decimal virgül değeri değiştirme
            //this.Property(x => x.BirimFiyati1).HasPrecision(28, 2);

            this.HasRequired(x => x.Menu).WithMany(x => x.Urun).HasForeignKey(x => x.MenuId);

        }
    }
}
