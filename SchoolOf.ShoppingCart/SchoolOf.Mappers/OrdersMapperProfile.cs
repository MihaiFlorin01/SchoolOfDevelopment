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
    public class OrdersMapperProfile : Profile
    {
        public OrdersMapperProfile()
        {
            CreateMap(typeof(Order), typeof(OrderDto));
        }
    }
}
