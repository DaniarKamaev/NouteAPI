using MediatR;
using NouteAPI.Models;
using NouteAPI.Models.NouteDbContext;

namespace NouteAPI.Features.Create
{
    public class CreateNouteHander(NouteDbContext db) : IRequestHandler<CreateNoute, CreateNouteResponse>
    {
        public async Task<CreateNouteResponse> Handle(CreateNoute request, CancellationToken cancellationToken)
        {
            var noute = new Noute
            {
                id = Guid.NewGuid(),
                ounerId = request.ounerId,
                date = DateTime.UtcNow,
                lable = request.lable,
                text = request.text
            };
            await db.AddAsync(noute);
            await db.SaveChangesAsync();
            Console.WriteLine("Заметка созданна");

            return new CreateNouteResponse(noute.id, $"Заметка с id {noute.id} успешно создана");
        }
    }
}
