using Microsoft.AspNet.Identity.EntityFramework;
using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core
{
    public class MyWebsiteDbContext : IdentityDbContext
    {
        public MyWebsiteDbContext() : base("MyWebsite")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<Actor> Actors { get; set; }
        
        public DbSet<Grammar> Grammars { get; set; }
        public DbSet<Lession> Lessions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionItem> QuestionItems { get; set; }
        public DbSet<SoundConservation> SoundConservations { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public static MyWebsiteDbContext Create()
        {
            return new MyWebsiteDbContext();
        }
    }
}
