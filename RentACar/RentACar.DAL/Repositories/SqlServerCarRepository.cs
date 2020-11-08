using AutoMapper;
using RentACar.DAL.DB;
using RentACar.DAL.Domain;
using RentACar.DAL.Requests;
using RentACar.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Repositories
{
    public class SqlServerCarRepository : BaseRepository<CarViewModel, CarUpsertRequest, Car>
    {
        public SqlServerCarRepository(RentACarDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
