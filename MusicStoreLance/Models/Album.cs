using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStoreLance.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Album> Album { get; set; }
    }
}