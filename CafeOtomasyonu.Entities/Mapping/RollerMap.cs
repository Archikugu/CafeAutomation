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
    public class RollerMap : EntityTypeConfiguration<Roller>
    {
        public RollerMap()
        {
            this.ToTable("Roller");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.ControlCaption).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.ControlName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.FormName).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
