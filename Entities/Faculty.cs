using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;

public class Faculty
{
    [Key]
    public int Id { get; set; }

    
    public string Name { get; set; }

    [ForeignKey("Group")]
    public int GroupId { get; set; }
}

