using UdemyNewMicroservice.Catalog.Api.Features.Categories.Dto;
using AutoMapper;

namespace UdemyNewMicroservice.Catalog.Api.Features.Categories
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
