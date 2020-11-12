using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CFM.Infrastructure.Db
{
    public class CFMContext : DbContext
    {
        private readonly IConfiguration _config;
        public CFMContext(
            DbContextOptions options,
            IConfiguration config)
            : base(options)
        {
            this._config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("CFM"));
        }
    }
}
