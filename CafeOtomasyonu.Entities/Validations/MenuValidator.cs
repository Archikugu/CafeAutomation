using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(x => x.MenuAdi).NotNull().NotEmpty().WithMessage("Menü Adı Alanı Boş Geçilemez!");
            RuleFor(x => x.MenuAdi).MinimumLength(3).WithMessage("Menü Adı Alanı En Az 3 Karakterden Oluşmalıdır!");
            RuleFor(x => x.MenuAdi).MaximumLength(15).WithMessage("Menü Adı Alanı En Fazla 15 Karakterden Oluşmalıdır!");
        }
    }
}
