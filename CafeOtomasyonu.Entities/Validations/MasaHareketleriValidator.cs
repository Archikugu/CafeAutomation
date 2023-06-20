using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
	public class MasaHareketleriValidator : AbstractValidator<MasaHareketleri>
	{
		public MasaHareketleriValidator()
		{
			RuleFor(x => x.SatisKodu).NotEmpty().WithMessage("Satış Kodu Boş Geçilemez!");
			//  RuleFor(x => x.SatisKodu).Length(15).WithMessage("Satış Kodu 15 Karakterden Oluşmalıdır!");
			RuleFor(x => x.Miktari).NotEmpty().WithMessage("Miktar Alanı Boş Geçilemez!");
			RuleFor(x => x.Miktari).GreaterThan(0).WithMessage("Miktar 0 dan Büyük Olmalıdır");

			RuleFor(x => x.BirimFiyati).NotEmpty().WithMessage("Birim Fiyatı Boş Geçilemez!");
			RuleFor(x => x.BirimFiyati).LessThanOrEqualTo(150).WithMessage("Birim Fiyatı en fazla 150'dir !");
		}
	}
}
