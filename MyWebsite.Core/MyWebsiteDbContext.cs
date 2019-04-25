using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core
{
    public class MyWebsiteDbContext :DbContext
    {
        public MyWebsiteDbContext() : base("MyWebsite")
        {

        }
        public DbSet<Actor> Actors { get; set; }
        
        public DbSet<Grammar> Grammars { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Lession> Lessions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionItem> QuestionItems { get; set; }
        public DbSet<SoundConservation> SoundConservations { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }

    }
}
