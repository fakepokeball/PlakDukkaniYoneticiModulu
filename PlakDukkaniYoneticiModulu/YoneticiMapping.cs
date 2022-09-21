using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu
{
    internal class YoneticiMapping : EntityTypeConfiguration<Yonetici>
    {
        public YoneticiMapping()
        {
            HasKey(a => a.YoneticiId);
            Property(a => a.KullaniciAdi).HasMaxLength(32).IsRequired();
            Property(a => a.Sifre).HasMaxLength(32).IsRequired();
            ToTable("Yoneticiler");
        }
    }
}
