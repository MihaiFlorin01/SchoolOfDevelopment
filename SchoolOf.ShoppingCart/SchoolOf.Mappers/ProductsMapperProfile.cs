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
    public class ProductsMapperProfile : Profile
    {
        public ProductsMapperProfile()
        {
            CreateMap(typeof(Product), typeof(ProductDto));
        }
    }
}
