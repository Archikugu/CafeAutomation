using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class MusterilerValidator : AbstractValidator<Musteriler>
    {
        public MusterilerValidator()
        {
            RuleFor(x => x.AdiSoyadi).NotEmpty().WithMessage("Adı ve Soyadı Boş Geçilemez!");
            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Telefon Boş Geçilemez!");
        }
    }
}
