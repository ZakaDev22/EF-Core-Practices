



using EF_Core_Practices;

// Print All
//using (var context = new AppDBContext())
//{
//    Console.WriteLine($"\n\nPrint All The Records In Students Tabel Using EF Core");
//    foreach (var Student in context.students)
//    {
//        Console.WriteLine(Student);
//    }
//}

//---------------------------------------------------------------------------------------------------
//// Print By ID

//int IdToRetrive = 1;
//using (var context = new AppDBContext())
//{
//    Console.WriteLine($"\n\nPrint Record With ID {IdToRetrive} ");

//     var student = context.students.FirstOrDefault(x => x.StudentID == IdToRetrive);

//     Console.WriteLine(student);
//}

//-------------------------------------------------------------------------------------------
// Add Student

//var student = new Students
//{
//    Name = "Zakaria",
//    Subject = "Programming",
//    Grade = 80,
//    IsActive = true
//};

//using (var context = new AppDBContext())
//{
//    context.students.Add(student);
//    context.SaveChanges();
//}

//-------------------------------------------------------------------
// Update Student 

//using (var context = new AppDBContext())
//{
//    var student = context.students.Single(x => x.StudentID == 11);
//    student.Grade = 99;

//    context.SaveChanges();
//}

//-------------------------------------------------------------------
// Update Student 

using (var context = new AppDBContext())
{
    var student = context.students.Single(x => x.StudentID == 8);

    context.students.Remove(student);

    context.SaveChanges();
}
