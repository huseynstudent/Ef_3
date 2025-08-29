namespace Ef_3.Entities;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Id_Faculty { get; set; }

    public Faculty Faculty { get; set; }
    public int StudentId { get; set; }
}

