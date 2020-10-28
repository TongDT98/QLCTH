using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class Course_Speciality_Mapping : BaseEntity
    {
        public string CourseId { get; set; }
        public string SpecialityId { get; set; }
    }
}
