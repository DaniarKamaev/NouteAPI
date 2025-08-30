using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using System.Security.Principal;

namespace NouteAPI.Models.NouteDbContext
{
    public class NouteDbContext(DbContextOptions<NouteDbContext> options) 
        : DbContext(options)
    {
       
        public DbSet<Noute> nouteSet {  get; set; }

        /*
        public List<Noute> Nouts { get; set; } = new();
        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }
        */
    }
}
