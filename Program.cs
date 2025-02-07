



using EF_Core_Practices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

//using (var context = new AppDBContext())
//{
//    var student = context.students.Single(x => x.StudentID == 8);

//    context.students.Remove(student);

//    context.SaveChanges();
//}

//-------------------------------------------------------------------
// Select Student With Grade >= 80 

//using (var context = new AppDBContext())
//{
//    var students = context.students.Where(x => x.Grade >= 80);

//    foreach (var student in students)
//    {
//        Console.WriteLine(student);
//    }

//}

//-------------------------------------------------------------------
// Using Transaction 

//using (var context = new AppDBContext())
//{
//    using (var Transaction = context.Database.BeginTransaction())
//    {
//        var student1 = context.students.Single(x => x.StudentID == 1);
//        var student2 = context.students.Single(x => x.StudentID == 2);

//        student1.Grade = 99;
//        student2.Grade = 50;

//        context.SaveChanges();

//        Transaction.Commit();
//    }

//}

// --------------------------------------------------------------------------

// Using Dependancy Injection

var config = new ConfigurationBuilder()
                      .AddJsonFile("appSettings.json")
                      .Build();
var ConnectionString = config.GetSection("ConnectionStrings").Value;

var services = new ServiceCollection();

services.AddDbContext<AppDBContext>(options =>
   options.UseSqlServer(ConnectionString)
);

IServiceProvider serviceProvider = services.BuildServiceProvider();

using (var context = serviceProvider.GetService<AppDBContext>())
{
    foreach (var item in context!.students)
    {
        Console.WriteLine(item);
    }
}