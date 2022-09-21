using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu
{
    internal class PlakDukDbContext : DbContext
    {
        public PlakDukDbContext() : base("conn")
        {

        }

        public Yonetici Yonetici { get; set; }
        public Album Album { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new YoneticiMapping());
            modelBuilder.Configurations.Add(new AlbumMapping());
        }
    }
}
