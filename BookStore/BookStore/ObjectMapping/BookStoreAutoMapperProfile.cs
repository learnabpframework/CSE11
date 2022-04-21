using AutoMapper;
using BookStore.Entities.Authors;
using BookStore.Entities.Books;
using BookStore.Services.Authors;
using BookStore.Services.Dtos.Authors;
using BookStore.Services.Dtos.Books;

namespace BookStore.ObjectMapping;

public class BookStoreAutoMapperProfile : Profile
{
    public BookStoreAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();

        CreateMap<Pages.Books.CreateModalModel.CreateBookViewModel, CreateUpdateBookDto>();
        CreateMap<BookDto, Pages.Books.EditModalModel.EditBookViewModel>();
        CreateMap<Pages.Books.EditModalModel.EditBookViewModel, CreateUpdateBookDto>();

        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel, CreateAuthorDto>();
        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel, UpdateAuthorDto>();
    }
}
