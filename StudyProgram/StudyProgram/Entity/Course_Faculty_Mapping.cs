using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class Course_Faculty_Mapping:BaseEntity
    {
     
        public string CourseId { get; set; }
        public string FacultyId { get; set; }
    }
}
