using MediatR;
namespace NouteAPI.Create
{
    public record CreateNoute(
        Guid ounerId,
        string lable,
        string text
        ) : IRequest<CreateNouteResponse>;
}
