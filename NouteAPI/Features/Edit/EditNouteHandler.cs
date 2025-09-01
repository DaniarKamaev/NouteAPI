using MediatR;
using NouteAPI.Features.Create;
using NouteAPI.Features.Get;
using NouteAPI.Models;
using NouteAPI.Models.NouteDbContext;
using System.Linq;

namespace NouteAPI.Features.Edit
{
    public class EditNouteHandler(NouteDbContext db) : IRequestHandler<EditNoute, EditNouteResponse>
    {
        public async Task<EditNouteResponse> Handle(EditNoute request, CancellationToken cancellationToken)
        {

            
            var noute = db.nouteSet.FirstOrDefault(a => a.id == request.id);

            if (noute == null)
            {
                throw new Exception($"Заметка с id {request.id} не найдена");
            }

            noute.date = DateTime.UtcNow;
            noute.lable = request.lable;
            noute.text = request.text;
            
            await db.SaveChangesAsync();
            return new EditNouteResponse(request.id, $"Заметка с id {request.id} успешно отредактированна");


        }
    }
}
