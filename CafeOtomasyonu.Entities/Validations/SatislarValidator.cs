using CafeOtomasyonu.Entities.Models;
using FluentValidation;

namespace CafeOtomasyonu.Entities.Validations
{
    public class SatislarValidator : AbstractValidator<Satislar>
    {
        public SatislarValidator()
        {
            RuleFor(x => x.SatisKodu).NotEmpty().WithMessage("Satış Kodu Boş Geçilemez!");
        }
    }
}
