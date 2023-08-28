using Microsoft.EntityFrameworkCore;

namespace Proj_Learn_ASP_Net_Core_MVC_7.Models.Domain
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
        {
                
        }
        public DbSet<PersonModel> tbl_person { get; set; }
    }
}
