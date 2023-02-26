using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Linq;
using SchoolCodeFirstDB.DataModels;

namespace SchoolCodeFirstDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();

            // select data from the database

            //var myClasses = myContext
            //    .Classes
            //    .Where(c => c.MaxClassSize > 0)
            //    .ToList();

            
            //update data into the database

            var myClass = myContext
                .Classes
                .FirstOrDefault(c => c.MaxClassSize > 0);

            myClass.ClassName = "Changed Name!";

            
            // add data into the database

            //myContext.Students.Add(new Student()
            //{
            //    Name = "John Doe",
            //    studentClasses =  new List<Class>()
            //    { 
            //        new Class()
            //        {
            //            ClassLanguage = Enums.Language.French,
            //            ClassName = "FrenchClass",
            //            MaxClassSize = 10
            //        },
            //        new Class()
            //        { 
            //            ClassLanguage = Enums.Language.Spanish,
            //            ClassName = "SpanichClass",
            //            MaxClassSize = 24
            //        }

            //    }


            //}
            //);

            myContext.SaveChanges();
        }
    }
}