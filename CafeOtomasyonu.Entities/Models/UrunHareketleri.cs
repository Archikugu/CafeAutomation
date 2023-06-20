using CafeOtomasyonu.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
	public class UrunHareketleri : IEntity
	{
		public int Id { get; set; }
		public int UrunId { get; set; }
		public string Aciklama { get; set; }
		public DateTime Tarih { get; set; }
		public virtual Urun Urun { get; set; }
	}
}
