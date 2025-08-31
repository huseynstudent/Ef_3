using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_3.Entities;

public class SCard
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Student")]
    public int Id_Student { get; set; }

    [ForeignKey("Book")]
    public int Id_Book { get; set; }

    
    public DateTime DateOut { get; set; }

    public DateTime? DateIn { get; set; }

    [ForeignKey("Lib")]
    public int Id_Lib { get; set; }

    public Student Student { get; set; }
    public Book Book { get; set; }
    public Lib Lib { get; set; }
}