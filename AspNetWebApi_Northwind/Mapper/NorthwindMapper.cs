using AspNetWebApi_Northwind.DTOs;
using AspNetWebApi_Northwind.Models.Entities;
using AutoMapper;

namespace AspNetWebApi_Northwind.Mapper
{
    public class NorthwindMapper:Profile
    {
        public NorthwindMapper()
        {
            CreateMap<Category, CategoryDTO>()
            .ForMember(dest => dest.Ad, opt => opt.MapFrom(src => src.CategoryName))
            .ForMember(dest => dest.Aciklama, opt => opt.MapFrom(src => src.Description))
            .ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>()
           .ForMember(dest => dest.Ad, opt => opt.MapFrom(src => src.CategoryName))
           .ForMember(dest => dest.Aciklama, opt => opt.MapFrom(src => src.Description))
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId))
           .ReverseMap();
        }
    }
}
