using MediatR;

namespace NouteAPI.Features.Edit
{
    public record EditNoute(
        Guid id,
        Guid ounerId,
        string lable,
        string text) : IRequest<EditNouteResponse>;
}
