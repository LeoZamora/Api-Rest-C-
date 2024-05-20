using Api_Rest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Api_Rest.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) 
        { 

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
