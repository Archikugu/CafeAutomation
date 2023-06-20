using CafeOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.Entities.Tools
{
	public class ConnectionTools
	{
		//Connection stringi dışarıdan alma 
		public static string Baglan()
		{
			string readStr;
			string path = @"ConnectionStr\baglanti.txt";
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
			using (var reader = new StreamReader(fileStream))
			{
				string row = reader.ReadLine();
				readStr = row;
				reader.Close();
			}
			fileStream.Close();
			return readStr;
		}

		public static void BaglantiKontol()
		{
			using (var context = new CafeContext())
			{
				if (!context.Database.Exists())
				{
					MessageBox.Show("Veritabanınız oluşturulacak. Daha sonra ayrı bir forma gönderilceksiniz.");
					context.Database.CreateIfNotExists();
				}
				//else
				//{
				//	MessageBox.Show("Veritabanınız zaten bulunuyor.");
				//}
				//tablo eklersek sonradan migration eklememiz gerkiyor
				Database.SetInitializer(new MigrateDatabaseToLatestVersion<CafeContext, Entities.Migrations.Configuration>());
			}
		}
		public static void VeriDoldur(CafeContext context)
		{
			//Test verisi 
			if (!context.Masalar.Any())
			{
				List<Masalar> masaList = new List<Masalar>()
				{
					new Masalar
					{
						MasaAdi="Masa-1",
						Aciklama="A grubu 1.Sıra",
						Islem = "Masa 1 oluşturuldu",
					},
				};
				context.Masalar.AddRange(masaList);
			}
			if (!context.Menu.Any())
			{
				List<Entities.Models.Menu> menuList = new List<Entities.Models.Menu>
				{
					new Entities.Models.Menu
					{
						MenuAdi="Sıcak İçecekler",
						Aciklama="Sıcak İçecek Grubu",
					},
				};
				context.Menu.AddRange(menuList);
			}
			if (!context.SatisKodu.Any())
			{
				List<SatisKodu> satisKoduList = new List<SatisKodu>() {
				new SatisKodu
				{
					SatisTanimi = "Satis",
					Sayi = 1
				}
			};
				context.SatisKodu.AddRange(satisKoduList);
			}
			context.SaveChanges();


		}
	}
}
