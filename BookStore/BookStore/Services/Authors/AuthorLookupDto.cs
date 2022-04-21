using Volo.Abp.Application.Dtos;

namespace BookStore.Services.Authors
{
    public class AuthorLookupDto : EntityDto<Guid>
    {

        public string Name { get; set; }

    }
}
