using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;

public class Student
{
    [Key]
    public int Id { get; set; }

    
    public string FirstName { get; set; }

    
    public string LastName { get; set; }

    [ForeignKey("Group")]
    public int Id_Group { get; set; }

    
    public int Term { get; set; }

    public Group Group { get; set; }

    [ForeignKey("SCard")]
    public int SCardId { get; set; }
}
