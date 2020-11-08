using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentACar.DAL.Repositories
{
    public interface IBaseRepository<TModel,TUpsertRequest>
    {
        Task<List<TModel>> GetAll(CancellationToken cancellationToken = default);
        Task<TModel> GetById(int id, CancellationToken cancellationToken = default);
        Task<int> Save(TUpsertRequest obj, CancellationToken cancellationToken = default);
        Task Update(int id, TUpsertRequest obj, CancellationToken cancellationToken = default);
        Task Remove(int id, CancellationToken cancellationToken = default);


    }
}
