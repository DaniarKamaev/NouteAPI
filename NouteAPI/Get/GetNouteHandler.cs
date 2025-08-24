using MediatR;
using NouteAPI.Models;
using NouteAPI.Models.NouteDbContext;
using System.Collections.Generic;

namespace NouteAPI.Get
{
    public class GetNouteHandler(NouteDbContext db) : IRequestHandler<GetNouteQuerty, IEnumerable<Noute>>
    {
        public Task<IEnumerable<Noute>> Handle(GetNouteQuerty request, CancellationToken cancellationToken)
        {
            var noute = db.Nouts.Where(a => a.ounerId == request.ounerId).ToList();
            return Task.FromResult<IEnumerable<Noute>>(noute);
        }
    }
}
