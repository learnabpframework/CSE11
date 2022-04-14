using BookStore.Constants;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Services.Dtos.Authors
{
    public class CreateAuthorDto
    {

        public Guid AuthorId { get; set; }

        [Required]
        [StringLength(AuthorConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }

    }
}
