namespace Ef_3.Entities;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Group { get; set; }
    public int Term { get; set; }

    public Group Group { get; set; }
    public int SCardId { get; set; }
}
