using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace NouteAPI.Get
{
    public static class GetNouteEndpoint 
    {
        public static void MapGetNoute(this IEndpointRouteBuilder app)
        {
            app.MapGet("api/noute/getNoute/{ounerId}", async (
                [FromRoute] Guid ounerId,
                IMediator mediator) =>
            {
                var query = new GetNouteQuerty(ounerId);
                var noute = await mediator.Send(query);

                return Results.Ok(noute);
            });
        }
    }
}