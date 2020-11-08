using AutoMapper;
using RentACar.DAL.Domain;
using RentACar.DAL.Requests;
using RentACar.DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Mapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Car, CarViewModel>().ReverseMap();
            CreateMap<Car, CarUpsertRequest>().ReverseMap();



        }
    }
}
