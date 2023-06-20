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
	public class MasalarMap : EntityTypeConfiguration<Masalar>
	{
		public MasalarMap()
		{
			this.ToTable("Masalar");
			this.HasKey(x => x.Id);
			this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(x => x.MasaAdi).HasColumnType("varchar").HasMaxLength(15);
			this.Property(x => x.SatisKodu).HasColumnType("varchar").HasMaxLength(20);
			this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);
			this.Property(x => x.EklenmeTarihi).HasColumnType("Date");

			this.HasOptional(m => m.Kullanicilar).WithMany(m => m.Masalar).HasForeignKey(m => m.KullaniciId);
		}
	}
}
