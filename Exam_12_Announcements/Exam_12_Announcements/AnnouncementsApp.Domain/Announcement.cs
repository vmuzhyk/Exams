using System;
using System.Collections.Generic;
using System.Text;

namespace AnnouncementsApp.Domain
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }

        public Announcement()
        {

        }
        public Announcement(string title, string description)
        {
            Tittle = title;
            Description = description;
            DateAdded = DateTime.Now;
        }
    }
}
