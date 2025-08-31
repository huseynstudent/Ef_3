using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int Pages { get; set; }
        public int YearPress { get; set; }
        [ForeignKey("Theme")]
        public int Id_Themes { get; set; }

        [ForeignKey("Category")]
        public int Id_Category { get; set; }

        [ForeignKey("Author")]
        public int Id_Author { get; set; }

        [ForeignKey("Press")]
        public int Id_Press { get; set; }

        public string Comment { get; set; }

        
        public int Quantity { get; set; }

        [ForeignKey("TCard")]
        public int TCardId { get; set; }

        [ForeignKey("SCard")]
        public int SCardId { get; set; }

        public Theme Theme { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
        public Press Press { get; set; }
    }
}
