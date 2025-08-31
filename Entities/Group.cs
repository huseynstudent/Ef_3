using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;

public class Group
{
    [Key]
    public int Id { get; set; }

    
    public string Name { get; set; }

    [ForeignKey("Faculty")]
    public int Id_Faculty { get; set; }

    public Faculty Faculty { get; set; }

    [ForeignKey("Student")]
    public int StudentId { get; set; }
}

