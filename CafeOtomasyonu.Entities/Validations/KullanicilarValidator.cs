using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class KullanicilarValidator : AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(x => x.AdSoyad).NotEmpty().WithMessage("Ad Soyad Alanı Boş Geçilemez!");
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez!");
            RuleFor(x => x.KullaniciAdi).MinimumLength(3).WithMessage("Kullanıcı Adı En az 5 Karakter Olmalıdır!");
            RuleFor(x => x.KullaniciAdi).MaximumLength(20).WithMessage("Kullanıcı Adı En fazla 20 Karakter Olmalıdır!");
            RuleFor(x => x.Parola).NotEmpty().WithMessage("Parola Alanı Boş Geçilemez!");
            RuleFor(x => x.Parola).MinimumLength(6).WithMessage("Parola En az 6 Karakter Olmalıdır!");
            RuleFor(x => x.Parola).MaximumLength(20).WithMessage("Parola En fazla 20 Karakter Olmalıdır!");
            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Yanlış Email Formatı!");
        }
    }
}
