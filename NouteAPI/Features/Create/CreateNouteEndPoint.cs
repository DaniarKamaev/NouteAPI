using FluentValidation;
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
                IValidator<CreateNoute> validator,
                IMediator mediator) =>
            {
                var validationResult = await validator.ValidateAsync(reqest);

                if (!validationResult.IsValid)
                {
                    return Results.ValidationProblem(validationResult.ToDictionary());
                }
                var response = await mediator.Send(reqest);
                return Results.Ok(response);
            });
        }
    }
}
