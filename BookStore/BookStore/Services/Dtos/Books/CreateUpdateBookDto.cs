using BookStore.Entities.Books;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Services.Dtos.Books
{
    public class CreateUpdateBookDto
    {

        public Guid AuthorId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }

    }
}
