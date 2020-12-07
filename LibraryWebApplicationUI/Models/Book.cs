using System.ComponentModel.DataAnnotations;

namespace LibraryWebApplicationUI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Авторы")]
        public string Authors { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Язык")]
        public string Language { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Обложка")]
        public byte[] CoverImage { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Файл")]
        public byte[] File { get; set; }
    }
}
