using BookStore.Entities.Authors;

namespace BookStore.Interfaces.Authors
{
    public interface IAuthorRepository
    {

        Task<Author> FindByNameAsync(string name);

        Task<List<Author>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string? filter = null
        );

    }
}
