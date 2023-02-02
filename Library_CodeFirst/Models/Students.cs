using Library_CodeFirst.Enums;

namespace Library_CodeFirst.Models;

public class Students : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int SchollNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDay { get; set; }
    public int PhoneNumber { get; set;}

    public ICollection<Books> Book { get; set; }

}
