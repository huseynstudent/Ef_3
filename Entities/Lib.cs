using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;

public class Lib
{
    [Key]
    public int Id { get; set; }

    
    public string FirstName { get; set; }

    
    public string LastName { get; set; }

    [ForeignKey("TCard")]
    public int TCardId { get; set; }

    [ForeignKey("SCard")]
    public int SCardId { get; set; }
}

