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

        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel, CreateAuthorDto>();
        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel, UpdateAuthorDto>();
    }
}
