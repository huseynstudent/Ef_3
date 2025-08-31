using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;

public class Press
{
    [Key]
    public int Id { get; set; }

    
    public string Name { get; set; }

    [ForeignKey("Book")]
    public int BookId { get; set; }
}
