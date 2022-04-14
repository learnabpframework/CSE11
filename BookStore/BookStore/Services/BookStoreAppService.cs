using BookStore.Localization;
using Volo.Abp.Application.Services;

namespace BookStore.Services
{
    public class BookStoreAppService : ApplicationService
    {

        protected BookStoreAppService()
        {
            LocalizationResource = typeof(BookStoreResource);
        }

    }
}
