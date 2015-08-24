using System.Data.Common;
using System.Data.Entity;
using OkPay.Exchangers.DbContext.Initializers;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.DbContext
{
    public class OkPayContext: System.Data.Entity.DbContext
    {
        public OkPayContext()
            : base("OkPayContext")
        {
            Database.SetInitializer(new OkPayDatabaseInitializer());
        }
        public DbSet<Exchanger> Exchangers { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CourseMap> CourseMaps { get; set; }
    }
}