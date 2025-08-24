using MediatR;
using NouteAPI.Models;

namespace NouteAPI.Get
{
    public record GetNouteQuerty(Guid ounerId) : IRequest<IEnumerable<Noute>>;
}
