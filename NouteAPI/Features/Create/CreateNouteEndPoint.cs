using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace NouteAPI.Features.Create
{
    public static class CreateNouteEndPoint
    {
        public static void MapCreateNouteEndPoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("api/noute/create", async (
                [FromBody] CreateNoute reqest,
                IMediator mediator) =>
            {
                var response = await mediator.Send(reqest);
                return Results.Ok(response);
            });
        }
    }
}
