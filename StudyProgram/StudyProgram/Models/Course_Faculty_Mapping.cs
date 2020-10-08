using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class Course_Faculty_Mapping
    {
        public int Id { get; set; }
        public string CourseId { get; set; }
        public string FacultyId { get; set; } 
    }
}
