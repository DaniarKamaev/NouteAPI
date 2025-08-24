using MediatR;
using NouteAPI.Models;

namespace NouteAPI.Features.Get
{
    public record GetNouteQuerty(Guid ounerId) : IRequest<IEnumerable<Noute>>;
}
