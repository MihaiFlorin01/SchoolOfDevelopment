using AutoMapper;
using SchoolOf.Data.Models;
using SchoolOf.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Mappers
{
    public class CartsMapperProfile : Profile
    {
        public CartsMapperProfile()
        {
            CreateMap<Cart, CartDto>()
                .ForMember(destination => destination.Status, x => x.MapFrom(source => source.Status.ToString()));
        }
    }
}
