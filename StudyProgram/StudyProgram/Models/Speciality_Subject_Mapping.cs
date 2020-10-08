using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class Speciality_Subject_Mapping
    {
        public int Id { get; set; }
        public string SpecialityId { get; set; }
        public string SubjectId { get; set; }
    }
}
