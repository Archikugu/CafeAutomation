using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.Entities.Repository;
using CafeOtomasyonu.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.DAL
{
	public class UrunHareketleriDal : EntityRepositoryBase<CafeContext, UrunHareketleri, UrunHareketleriValidator>
	{
		public void UrunHareketleriEkle(CafeContext context, UrunHareketleri urunHareketleri, string aciklama)
		{
			UrunHareketleriDal urunHareketleriDal = new UrunHareketleriDal();
			urunHareketleri.Tarih = DateTime.Now;
			urunHareketleri.Aciklama = aciklama;
			if (urunHareketleriDal.AddOrUpdate(context, urunHareketleri))
			{
				urunHareketleriDal.Save(context);
			}
		}
	}
}
