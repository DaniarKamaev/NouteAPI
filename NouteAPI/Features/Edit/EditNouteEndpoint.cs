using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace NouteAPI.Features.Edit
{
    public static class EditNouteEndpoint
    {
        public static void MapEditNoute(this IEndpointRouteBuilder app)
        {
            app.MapPost("api/noute/edit", async (
                [FromBody] EditNoute editNoute,
                IMediator mediator) =>
            {
                var response = await mediator.Send(editNoute);
                return Results.Ok(response);
            });
            

        }
    }
}
