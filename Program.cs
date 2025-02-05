



using EF_Core_Practices;

using (var context = new AppDBContext())
{
    Console.WriteLine($"\n\nPrint All The Records In Students Tabel Using EF Core");
    foreach (var Student in context.students)
    {
        Console.WriteLine(Student);
    }
}

int IdToRetrive = 1;
using (var context = new AppDBContext())
{
    Console.WriteLine($"\n\nPrint Record With ID {IdToRetrive} ");

    var student = context.students.FirstOrDefault(x => x.StudentID == IdToRetrive);

    Console.WriteLine(student);
}