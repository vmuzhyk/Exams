using AnnouncementsApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnouncementsApp.Data
{
    public class AnnouncementContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-78G56KJ\SQLEXPRESS; Initial Catalog = AnnouncementAppData; Integrated Security=true;");
        }
    }
}
