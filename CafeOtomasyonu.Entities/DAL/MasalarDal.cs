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
    public class MasalarDal : EntityRepositoryBase<CafeContext, Masalar, MasalarValidator>
    {
        public object MasalariListele(CafeContext context)
        {
            var model = (from masa in context.Masalar
                             //Left join yaptık kullanıcı id si null dönenleri listelemek için 
                         join k in context.Kullanicilar on masa.KullaniciId equals k.Id into kullanici
                         from kullaniciMasa in kullanici.DefaultIfEmpty()
                         select new
                         {
                             masa.Aciklama,
                             masa.Durumu,
                             masa.EklenmeTarihi,
                             masa.Id,
                             masa.Islem,
                             masa.MasaAdi,
                             masa.RezerveMi,
                             masa.SonIslemTarihi,
                             Kullanici = kullaniciMasa.KullaniciAdi
                         }).ToList();
            return model;
        }
    }
}
