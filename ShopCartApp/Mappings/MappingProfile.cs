using AutoMapper;
using ShopCartApp.Entities;
using ShopCartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartApp.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Image, ImageDto>().ReverseMap();        
        }
    }
}
