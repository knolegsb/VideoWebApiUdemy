using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VideoWebApiUdemy.Models
{
    public class VideoDb : DbContext
    {
        public VideoDb() : base("DefaultConnection") {}

        public DbSet<Video> Videos { get; set; }
    }
}