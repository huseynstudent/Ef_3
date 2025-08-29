namespace Ef_3.Entities;
public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Dep { get; set; }

    public Department Department { get; set; }
    public int TCardId { get; set; }
}
