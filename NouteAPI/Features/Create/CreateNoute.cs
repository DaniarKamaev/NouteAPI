using MediatR;

namespace NouteAPI.Features.Create
{
    public record CreateNoute(
        Guid ounerId,
        string lable,
        string text
        ) : IRequest<CreateNouteResponse>;
}
