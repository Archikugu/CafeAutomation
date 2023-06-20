using CafeOtomasyonu.Entities.Models;
using FluentValidation;

namespace CafeOtomasyonu.Entities.Validations
{
    public class UrunValidator : AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(x => x.UrunKodu).NotNull().NotEmpty().WithMessage("Ürün Kodu Boş Geçilemez!");
            RuleFor(x => x.UrunAdi).NotEmpty().WithMessage("Ürün Adı Alanı Boş Geçilemez!");

            RuleFor(x => x.BirimFiyati1).NotEmpty().WithMessage("Birim Fiyatı1 Boş Geçilemez!");
            RuleFor(x => x.BirimFiyati2).NotEmpty().WithMessage("Birim Fiyatı2 Boş Geçilemez!");
            RuleFor(x => x.BirimFiyati3).NotEmpty().WithMessage("Birim Fiyatı3 Boş Geçilemez!");

        }
    }
}
