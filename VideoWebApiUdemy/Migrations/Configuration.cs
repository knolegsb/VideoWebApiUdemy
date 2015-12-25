namespace VideoWebApiUdemy.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VideoWebApiUdemy.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VideoWebApiUdemy.Models.VideoDb context)
        {
            context.Videos.AddOrUpdate(v => v.Title,
                new Video() { Title = "MVC 4", Length = 120, Category = "Basic", Format = "WMV", Quality = Quality.A, ItemOpened = true },
                new Video() { Title = "MVC 5", Length = 80, Category = "Advanced", Format = "AVI", Quality = Quality.B, ItemOpened = false },
                new Video() { Title = "Jquery", Length = 130, Category = "Advanced", Format = "WMV", Quality = Quality.C, ItemOpened = true },
                new Video() { Title = "MVC 4", Length = 100, Category = "Basic", Format = "WMV", Quality = Quality.D, ItemOpened = false }
                );
            context.SaveChanges();
        }
    }
}
