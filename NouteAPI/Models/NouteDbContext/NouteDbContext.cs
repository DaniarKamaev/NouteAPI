using System.Security.Principal;

namespace NouteAPI.Models.NouteDbContext
{
    public class NouteDbContext
    {
        public List<Noute> Nouts { get; } = new();
        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }
    }
}
