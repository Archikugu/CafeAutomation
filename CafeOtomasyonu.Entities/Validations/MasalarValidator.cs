using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class MasalarValidator : AbstractValidator<Masalar>
    {
        public MasalarValidator()
        {
            RuleFor(x => x.MasaAdi).NotEmpty().WithMessage("Masa Adı Alanı Boş Geçilemez!");
        }
    }
}
