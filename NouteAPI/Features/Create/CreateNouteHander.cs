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
                date = DateTime.Now,
                lable = request.lable,
                text = request.text
            };
            db.Nouts.Add(noute);
            await db.SaveChangesAsync();

            return new CreateNouteResponse(noute.id, $"Заметка с id {noute.id} успешно создана");
        }
    }
}
