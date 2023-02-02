using Library_CodeFirst.Contexts;
using Microsoft.EntityFrameworkCore;

using AppDbContext context = new AppDbContext();

context.SaveChanges();
var list = context.Students.Where(x => x.Id < 10)
                            .Select(x => new
                            {
                                x.Id,
                                x.FirstName,
                                x.LastName,
                                x.Gender,
                            });

foreach (var p in list)
{
    Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName} {p.Gender}");
}
