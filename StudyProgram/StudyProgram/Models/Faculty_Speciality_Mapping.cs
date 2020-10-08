using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class Faculty_Speciality_Mapping
    {
        public int Id { get; set; }
        public string FacultyId { get; set; }
        public string SpecialityId { get; set; }
    }
}
