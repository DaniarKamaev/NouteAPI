using FluentValidation;
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
                IValidator<EditNoute> validator,
                IMediator mediator) =>
            {
                var validationResult = await validator.ValidateAsync(editNoute);

                if (!validationResult.IsValid)
                {
                    return Results.ValidationProblem(validationResult.ToDictionary());
                }
                var response = await mediator.Send(editNoute);
                return Results.Ok(response);
            });
            

        }
    }
}
