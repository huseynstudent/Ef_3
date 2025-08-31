using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;
public class Department
{
    [Key]
    public int Id { get; set; }

    
    public string Name { get; set; }

    [ForeignKey("Teacher")]
    public int TeacherId { get; set; }
}
