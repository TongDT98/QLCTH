using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Entity
{
    public class Speciality_Subject_Mapping:BaseEntity
    {
        
        public string SpecialityId { get; set; }
        public string SubjectId { get; set; }
    }
}
