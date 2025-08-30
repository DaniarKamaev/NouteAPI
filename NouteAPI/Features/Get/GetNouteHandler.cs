using MediatR;
using Microsoft.EntityFrameworkCore;
using NouteAPI.Models;
using NouteAPI.Models.NouteDbContext;
using System.Collections.Generic;

namespace NouteAPI.Features.Get
{
   public class GetNouteHandler(NouteDbContext db) : IRequestHandler<GetNouteQuerty, IEnumerable<Noute>>
   {
       public async Task<IEnumerable<Noute>> Handle(GetNouteQuerty request, CancellationToken cancellationToken)
       {
            try
            {
                Console.WriteLine($"Запрос учетных записей на идентификатор владельца: {request.ounerId}");
                var noutes = await db.nouteSet
                    .Where(a => a.ounerId == request.ounerId)
                    .ToListAsync(cancellationToken);
                Console.WriteLine($"Найдены {noutes.Count} аккаунтов");
                return noutes;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в GetAccountsHandler: {ex.Message}");
                return Enumerable.Empty<Noute>();
            }
        }
   }
}
