using CafeOtomasyonu.Entities.Mapping;
using CafeOtomasyonu.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
	public class CafeContext : DbContext
	{
		// veri tabanını dışardan çağırma
		//public CafeContext() : base(ConnectionTools.Baglan())
		//{

		//}
		//public CafeContext() : base("Data source=(localdb)\\MSSQLLocalDB; Initial Catalog = Cafe; Integrated Security=true;")
		//{

		//}
		public CafeContext() : base("name=connection")
		{

		}

		public DbSet<Menu> Menu { get; set; }
		public DbSet<Urun> Urun { get; set; }
		public DbSet<Masalar> Masalar { get; set; }
		public DbSet<MasaHareketleri> MasaHareketleri { get; set; }
		public DbSet<Kullanicilar> Kullanicilar { get; set; }
		public DbSet<KullaniciHareketleri> KullaniciHareketleri { get; set; }
		public DbSet<OdemeHareketleri> OdemeHareketleri { get; set; }
		public DbSet<Roller> Rollers { get; set; }
		public DbSet<Satislar> Satislar { get; set; }
		public DbSet<Musteriler> Musteriler { get; set; }
		public DbSet<SatisKodu> SatisKodu { get; set; }
		public DbSet<ProgramAyarlari> ProgramAyarlari { get; set; }
		public DbSet<NewTable> NewTable { get; set; }
		public DbSet<UrunHareketleri> UrunHareketleris { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new KullaniciHareketleriMap());
			modelBuilder.Configurations.Add(new KullanicilarMap());
			modelBuilder.Configurations.Add(new MasaHareketleriMap());
			modelBuilder.Configurations.Add(new MasalarMap());
			modelBuilder.Configurations.Add(new MenuMap());
			modelBuilder.Configurations.Add(new OdemeHareketleriMap());
			modelBuilder.Configurations.Add(new RollerMap());
			modelBuilder.Configurations.Add(new SatislarMap());
			modelBuilder.Configurations.Add(new UrunMap());
			modelBuilder.Configurations.Add(new MusterilerMap());
		}

	}
}
