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
    public class MusterilerMap : EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            this.ToTable("Musteriler");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.AdiSoyadi).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Telefon).HasColumnType("varchar").HasMaxLength(25);
            this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(500);
            this.Property(x => x.Adres).HasColumnType("varchar").HasMaxLength(200);
            this.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(150);
        }
    }
}
