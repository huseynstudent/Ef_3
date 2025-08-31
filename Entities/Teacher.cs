using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;
public class Teacher
{
    [Key]
    public int Id { get; set; }

    
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [ForeignKey("Department")]
    public int Id_Dep { get; set; }

    public Department Department { get; set; }

    [ForeignKey("TCard")]
    public int TCardId { get; set; }
}
