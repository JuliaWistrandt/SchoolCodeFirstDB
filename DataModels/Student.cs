using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SchoolCodeFirstDB.DataModels
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; }

        public List<Class> studentClasses { get; set; }
    }
}
