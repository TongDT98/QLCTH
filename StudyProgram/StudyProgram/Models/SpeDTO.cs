using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class SpeDTO
    {
        public IEnumerable<SpecialityDTO> Specialities { get; set; }

        public IEnumerable<CourseDTO> Courses { get; set; }
    }
}
