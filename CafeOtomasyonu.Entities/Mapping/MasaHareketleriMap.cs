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
	public class MasaHareketleriMap : EntityTypeConfiguration<MasaHareketleri>
	{
		public MasaHareketleriMap()
		{
			this.ToTable("MasaHareketleri");
			this.HasKey(x => x.Id);
			this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(x => x.SatisKodu).HasColumnType("varchar").HasMaxLength(15);
			this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);

			this.HasOptional(x => x.Masalar).WithMany(x => x.MasaHareketleri).HasForeignKey(x => x.MasaId);
			this.HasRequired(x => x.Urun).WithMany(x => x.MasaHareketleri).HasForeignKey(x => x.UrunId);

		}
	}
}
