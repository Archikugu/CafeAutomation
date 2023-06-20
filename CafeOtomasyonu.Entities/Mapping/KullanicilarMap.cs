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
    public class KullanicilarMap : EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap()
        {
            this.ToTable("Kullanicilar");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Adres).HasColumnType("varchar").HasMaxLength(500);
            this.Property(x => x.AdSoyad).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Telefon).HasColumnType("varchar").HasMaxLength(15);
            this.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Gorevi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.KullaniciAdi).HasColumnType("varchar").HasMaxLength(20);
            this.Property(x => x.Parola).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.HatirlatmaSorusu).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Cevap).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}
