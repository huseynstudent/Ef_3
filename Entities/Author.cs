using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;

public class Author
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }   
    
    public string LastName { get; set; }

    [ForeignKey("Book")]
    
    public int BookId { get; set; }
}
