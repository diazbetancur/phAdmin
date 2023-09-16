using Microsoft.EntityFrameworkCore;

namespace Information.Security.Api.Data
{
    public class DbPH : DbContext
    {
        public DbPH (DbContextOptions<DbPH> options) : base(options) { }
    }
}
