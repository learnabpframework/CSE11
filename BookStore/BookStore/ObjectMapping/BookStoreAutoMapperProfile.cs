using AutoMapper;
using BookStore.Entities.Authors;
using BookStore.Services.Dtos.Authors;

namespace BookStore.ObjectMapping;

public class BookStoreAutoMapperProfile : Profile
{
    public BookStoreAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<Author, AuthorDto>();
    }
}
