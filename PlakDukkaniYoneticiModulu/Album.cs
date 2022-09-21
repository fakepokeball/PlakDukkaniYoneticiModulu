using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu
{
    internal class Album
    {
        public int AlbumId { get; set; }
        public string AlbumAdi { get; set; }
        public string SanatciGrup { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyati { get; set; }
        public decimal İndirimOrani { get; set; }
        public bool SatistaMi { get; set; }
    }
}
