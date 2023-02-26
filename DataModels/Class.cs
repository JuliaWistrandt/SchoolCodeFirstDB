using SchoolCodeFirstDB.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolCodeFirstDB.DataModels
{
    public class Class
    {
        public int ClassID { get; set; }
        [MaxLength(50)]
        
        public string ClassName { get; set; }
        
        [Required]
        public int MaxClassSize { get; set; }

        public Language ClassLanguage { get; set; }
    }
}
