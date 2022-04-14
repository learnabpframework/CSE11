using Volo.Abp.Application.Dtos;

namespace BookStore.Services.Dtos.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {

        public string? Filter { get; set; }

    }
}
