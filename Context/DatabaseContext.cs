using Microsoft.EntityFrameworkCore;
using TesterZip.Models.Excel;

namespace TesterZip.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=REHANG\SQLEXPRESS;Initial Catalog=TesterKu;Integrated Security=True;TrustServerCertificate=True");
            options.UseSqlServer(connectionString);
        }
        public DbSet<IDCard> IDCards { get; set; }
    }
}
