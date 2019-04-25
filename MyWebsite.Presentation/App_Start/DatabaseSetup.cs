
using MyWebsite.Core;
using System.Data.Entity;

namespace MyWebsite.Presentation
{
    internal class DatabaseSetup
    {
        public static void Initialize()
        {
            Database.SetInitializer(new DbInitializer());

            using (var db = new MyWebsiteDbContext())
            {
                db.Database.Initialize(true);
            }
        }
    }
}