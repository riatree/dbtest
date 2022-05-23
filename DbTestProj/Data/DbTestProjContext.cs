using DbTestProj.Models;
using Microsoft.EntityFrameworkCore;

namespace DbTestProj.Data
{
    public class DbTestProjContext : DbContext
    {
        public DbTestProjContext(DbContextOptions<DbTestProjContext> options) :base() {  }
        
        public DbSet<User>? Users { get; set; }

    }
}

