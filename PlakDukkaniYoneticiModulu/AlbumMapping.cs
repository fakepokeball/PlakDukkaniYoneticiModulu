using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu
{
    internal class AlbumMapping : EntityTypeConfiguration<Album>
    {
        public AlbumMapping()
        {
            HasKey(a => a.AlbumId);
            Property(a => a.AlbumAdi).IsRequired();
            Property(a => a.SatistaMi).IsRequired();
            Property(a => a.SanatciGrup).IsRequired();
            Property(a => a.Fiyati).IsRequired();
            Property(a => a.CikisTarihi).IsRequired();
            ToTable("Albumler");
        }
    }
}
