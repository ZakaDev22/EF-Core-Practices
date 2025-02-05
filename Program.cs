



using EF_Core_Practices;

using (var context = new AppDBContext())
{
    foreach (var Student in context.students)
    {
        Console.WriteLine(Student);
    }
}