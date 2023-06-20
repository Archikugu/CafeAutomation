using CafeOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        //Mapping kısıtlma
        public MenuMap()
        {
            this.ToTable("Menu");
            this.HasKey(x => x.Id);
            //Otomatik artan
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.MenuAdi).HasColumnType("varchar").HasMaxLength(60);
            this.Property(x => x.Aciklama).HasColumnType("varchar").HasMaxLength(300);

            //Kolon Adı değiştirme
            //this.Property(x => x.Aciklama).HasColumnName("Description");
        }
    }
}
