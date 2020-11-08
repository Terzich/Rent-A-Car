using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentACar.DAL.DB;
using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentACar.DAL.Repositories
{
    public class BaseRepository<TModel,TUpsertRequest ,TDatabase> : IBaseRepository<TModel, TUpsertRequest> where TDatabase : BaseEntity
    {

        protected readonly RentACarDbContext _context;
        protected readonly IMapper _mapper;

        public BaseRepository(RentACarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<TModel>> GetAll(CancellationToken cancellationToken = default)
        {
            var dataDomain = await _context.Set<TDatabase>().ToListAsync(cancellationToken);
            return _mapper.Map<List<TModel>>(dataDomain);

        }

        public async Task<TModel> GetById(int id, CancellationToken cancellationToken = default)
        {
            var objDomain = await _context.Set<TDatabase>().FindAsync(id);
            return _mapper.Map<TModel>(objDomain);
        }

        public async Task Remove(int id, CancellationToken cancellationToken = default)
        {
            var objDomain = await _context.Set<TDatabase>().FindAsync(id);
            _context.Set<TDatabase>().Remove(objDomain);
            await _context.SaveChangesAsync(cancellationToken);


        }

        public async Task<int> Save(TUpsertRequest obj, CancellationToken cancellationToken = default)
        {
            var domainToSave = _mapper.Map<TDatabase>(obj);
            await _context.Set<TDatabase>().AddAsync(domainToSave, cancellationToken);
            _context.SaveChanges();

            return domainToSave.Id;
        }

        public async Task Update(int id, TUpsertRequest obj, CancellationToken cancellationToken = default)
        {
            var objDomain = await _context.Set<TDatabase>().FindAsync(id);
            _context.Set<TDatabase>().Attach(objDomain);
            _context.Set<TDatabase>().Update(objDomain);

            _mapper.Map(obj, objDomain);
            _context.SaveChanges();

        }
    }
}
