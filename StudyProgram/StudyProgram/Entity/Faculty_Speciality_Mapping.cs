using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class Faculty_Speciality_Mapping:BaseEntity
    {
       
        public string FacultyId { get; set; }
        public string SpecialityId { get; set; }
    }
}
